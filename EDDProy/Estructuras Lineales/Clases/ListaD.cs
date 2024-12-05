using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListaD
    {
        private Nodo inicio;
        private Nodo fin;

        public ListaD()
        {
            inicio = null;
            fin = null;
        }

        public void Push(int posicion, String dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (inicio == null && fin == null)
            {
                inicio = nuevo;
                fin = nuevo;
                return;
            }

            if (posicion == 0 || posicion == 1)
            {
                nuevo.sig = inicio;
                inicio = nuevo;
                return;
            }

            Nodo aux = inicio;
            int pos = 1;

            while (pos < posicion && aux.sig != null)
            {
                aux = aux.sig;
                pos++;
            }

            if (aux.sig == null)
            {
                aux.sig = nuevo;
                fin = nuevo;
            }
            else
            {
                nuevo.sig = aux.sig;
                aux.sig = nuevo;
            }
        }
        public string Pop(int posicion)
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacía");
                return null;
            }
            Nodo aux = inicio;
            int pos = 1;
            if (posicion == 1)
            {
                inicio = inicio.sig;
                if (inicio == null) fin = null;
                return aux.Dato;
            }
            while (pos < posicion && aux.sig != null)
            {
                aux = aux.sig;
                pos++;
            }
            if (aux == null || aux.sig == null) return null;
            if (aux.sig == fin)
            {
                fin = aux;
            }
            aux.sig = aux.sig.sig;
            return aux.Dato;
        }

        public List<string> ObtenerDatos()
        {
            List<string> datos = new List<string>();
            Nodo aux = inicio;
            while (aux != null)
            {
                datos.Add(aux.Dato);
                aux = aux.sig;
            }
            return datos;
        }
    }
}
