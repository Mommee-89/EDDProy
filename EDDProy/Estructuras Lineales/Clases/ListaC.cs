using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListaC
    {
        private NodoC cabeza;

        public ListaC()
        {
            cabeza = null;
        }

        public void Insertar(string dato)
        {
            NodoC nuevo = new NodoC(dato);

            if (cabeza == null)
            {
                cabeza = nuevo;
                cabeza.siguiente = cabeza;
            }
            else
            {
                NodoC temp = cabeza;
                while (temp.siguiente != cabeza)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevo;
                nuevo.siguiente = cabeza;
            }
        }
        public string Eliminar(int posicion)
        {
            if (cabeza == null)
                return null;

            NodoC temp = cabeza;
            NodoC anterior = null;
            if (posicion == 1)
            {
                if (cabeza.siguiente == cabeza)
                {
                    string dato = cabeza.Dat;
                    cabeza = null;
                    return dato;
                }
                else
                {
                    while (temp.siguiente != cabeza)
                    {
                        temp = temp.siguiente;
                    }
                    string dato = cabeza.Dat;
                    cabeza = cabeza.siguiente;
                    temp.siguiente = cabeza;
                    return dato;
                }
            }
            for (int i = 1; temp != null && i < posicion; i++)
            {
                anterior = temp;
                temp = temp.siguiente;
            }

            if (temp == null)
                return null;

            anterior.siguiente = temp.siguiente;
            return temp.Dat;
        }
        public List<string> ObtenerDatos()
        {
            List<string> datos = new List<string>();
            if (cabeza != null)
            {
                NodoC temp = cabeza;
                do
                {
                    datos.Add(temp.Dat);
                    temp = temp.siguiente;
                } while (temp != cabeza);
            }
            return datos;
        }
    }
}