using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListaS
    {
        private Nodo primero;
        private Nodo ultimo;

        public ListaS()
        {
            primero = null;
            ultimo = null;
        }

        public void Push(string dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.sig = nuevo;
                ultimo = nuevo;
            }
            Console.WriteLine($"Dato {dato} insertado en la lista.");
        }

        public void Pop()
        {
            if (primero == null)
            {
                Console.WriteLine("Lista vacía.");
            }
            else
            {
                string dato = primero.Dato;
                primero = primero.sig;
                Console.WriteLine($"Dato {dato} eliminado de la lista.");
            }
        }

        public void Buscar(string dato)
        {
            Nodo actual = primero;
            int posicion = 0;
            while (actual != null)
            {
                if (actual.Dato == dato)
                {
                    Console.WriteLine($"Dato {dato} encontrado en posición {posicion}.");
                    return;
                }
                actual = actual.sig;
                posicion++;
            }
            Console.WriteLine($"Dato {dato} no encontrado.");
        }

        public void Mostrar()
        {
            if (primero == null)
            {
                Console.WriteLine("Lista vacía.");
            }
            else
            {
                Console.WriteLine("Contenido de la lista:");
                Nodo actual = primero;
                int posicion = 0;
                while (actual != null)
                {
                    Console.WriteLine($"[{posicion}] -> {actual.Dato}");
                    actual = actual.sig;
                    posicion++;
                }
            }
        }
        public List<string> ObtenerDatos()
        {
            List<string> datos = new List<string>();
            Nodo actual = primero;
            while (actual != null)
            {
                datos.Add(actual.Dato);
                actual = actual.sig;
            }
            return datos;
        }
    }
}
