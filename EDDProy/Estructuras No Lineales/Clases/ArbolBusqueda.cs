using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {            
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);          
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public  String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
            
            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo )
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
         }

        public bool Buscar(int valor, NodoBinario nodo)
        {
            if (nodo == null)
                return false;

            if (nodo.Dato == valor)
                return true;

            if (valor < nodo.Dato)
                return Buscar(valor, nodo.Izq);

            else
                return Buscar(valor, nodo.Der);

        }
        public void Muestra(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            Muestra(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "     ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            Muestra(nivel + 1, nodo.Izq);
        }

        public void PodarArbol(ref NodoBinario nodo)
        {
            if (nodo == null)
                return;
            PodarArbol(ref nodo.Izq);
            PodarArbol(ref nodo.Der);
            nodo = null;
        }

        public void PodarArbolCompleto()
        {
            if (Raiz == null)
            {
                Console.WriteLine("Arbol vacío");
                return;
            }

            PodarArbol(ref Raiz);
            Raiz = null;
            Console.WriteLine("El árbol ha sido podado por completo");
        }

        public NodoBinario EliminarPredecesor(NodoBinario nodo, int valor)
        {
            if (nodo == null) return nodo;

            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarPredecesor(nodo.Izq, valor);
            }
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarPredecesor(nodo.Der, valor);
            }
            else
            {
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario predecesor = EncontrarMaximo(nodo.Izq);
                    nodo.Dato = predecesor.Dato;
                    nodo.Izq = EliminarPredecesor(nodo.Izq, predecesor.Dato);
                }
                else
                {
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;
                }
            }

            return nodo;
        }

        private NodoBinario EncontrarMaximo(NodoBinario nodo)
        {
            while (nodo.Der != null)
            {
                nodo = nodo.Der;
            }
            return nodo;
        }

        public NodoBinario EliminarSucesor(NodoBinario nodo, int valor)
        {
            if (nodo == null) return nodo;

            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarSucesor(nodo.Izq, valor);
            }
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarSucesor(nodo.Der, valor);
            }
            else
            {
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario sucesor = EncontrarMinimo(nodo.Der);
                    nodo.Dato = sucesor.Dato;
                    nodo.Der = EliminarSucesor(nodo.Der, sucesor.Dato);
                }
                else
                {
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;
                }
            }

            return nodo;
        }

        private NodoBinario EncontrarMinimo(NodoBinario nodo)
        {
            while (nodo.Izq != null)
                nodo = nodo.Izq;
            return nodo;
        }

        public void RecorridoPorNiveles()
        {
            if (Raiz == null)
                return;

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(Raiz);

            strRecorrido = "";
            while (cola.Count > 0)
            {
                NodoBinario nodoActual = cola.Dequeue();
                strRecorrido += nodoActual.Dato + ", ";

                if (nodoActual.Izq != null)
                    cola.Enqueue(nodoActual.Izq);
                if (nodoActual.Der != null)
                    cola.Enqueue(nodoActual.Der);
            }


        }

        public int Altura(NodoBinario nodo)
        {
            if (nodo == null)
                return -1;
            return 1 + Math.Max(Altura(nodo.Izq), Altura(nodo.Der));
        }

        public int ContarHojas(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;
            if (nodo.Izq == null && nodo.Der == null)
                return 1;
            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }

        public int ContarNodos(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;
            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }

        public bool EsCompleto(NodoBinario nodo, int indice, int numeroNodos)
        {
            if (nodo == null)
                return true;

            if (indice >= numeroNodos)
                return false;

            return EsCompleto(nodo.Izq, 2 * indice + 1, numeroNodos) &&
                   EsCompleto(nodo.Der, 2 * indice + 2, numeroNodos);
        }

        public bool EsLleno(NodoBinario nodo)
        {
            if (nodo == null)
                return true;

            if ((nodo.Izq == null && nodo.Der == null) ||
                (nodo.Izq != null && nodo.Der != null))
            {
                return EsLleno(nodo.Izq) && EsLleno(nodo.Der);
            }

            return false;
        }
    }
}
