using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            if (miArbol.Buscar(int.Parse(txtDato.Text), miArbol.RegresaRaiz()))
                MessageBox.Show("No se admiten datos duplicados");
            else
            {
                //Limpiamos la cadena donde se concatenan los nodos del arbol 
                miArbol.strArbol = "";

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                    ref miRaiz);

                //Leer arbol completo y mostrarlo en caja de texto
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                txtDato.Text = "";
            }

 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos =1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(textBox1.Text);


            if (miArbol.Buscar(valor, miArbol.RegresaRaiz()))
                MessageBox.Show("El " + valor + " se encontró en el árbol.");
            else
                MessageBox.Show("El valor no se encontró en el árbol.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPodar_Click(object sender, EventArgs e)
        {
            miArbol.PodarArbolCompleto();
            txtArbol.Text = "Árbol podado.";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btEliminarPredecesor_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtDato.Text);
            miArbol.EliminarPredecesor(miArbol.RegresaRaiz(), valor);
            miArbol.strArbol = "";
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btEliminarSucesor_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtDato.Text);
            miArbol.EliminarSucesor(miArbol.RegresaRaiz(), valor);
            miArbol.strArbol = "";
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void btRecorridoNiveles_Click(object sender, EventArgs e)
        {
            miArbol.RecorridoPorNiveles();
            lblRecorridoPorNiveles.Text = "Recorrido por Niveles: " + miArbol.strRecorrido;
        }

        private void btAltura_Click(object sender, EventArgs e)
        {
            int altura = miArbol.Altura(miRaiz);
            MessageBox.Show("La altura del árbol es: " + altura);
        }

        private void btContarHojas_Click(object sender, EventArgs e)
        {
            int hojas = miArbol.ContarHojas(miRaiz);
            MessageBox.Show("Cantidad de hojas en el árbol: " + hojas);
        }

        private void btContarNodos_Click(object sender, EventArgs e)
        {
            int nodos = miArbol.ContarNodos(miRaiz);
            MessageBox.Show("Cantidad de nodos en el árbol: " + nodos);
        }

        private void btEsCompleto_Click(object sender, EventArgs e)
        {
            int numNodos = miArbol.ContarNodos(miRaiz);
            bool esCompleto = miArbol.EsCompleto(miRaiz, 0, numNodos);
            MessageBox.Show("¿Es el árbol completo? " + (esCompleto ? "Sí" : "No"));
        }

        private void btEsLleno_Click(object sender, EventArgs e)
        {
            bool esLleno = miArbol.EsLleno(miRaiz);
            MessageBox.Show("¿Es el árbol lleno? " + (esLleno ? "Sí" : "No"));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
