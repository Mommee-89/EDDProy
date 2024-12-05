using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public class Pilas
    {
            public Nodo top;

            public Pilas()
            {
                top = null;
            }
            public Nodo ObtenerTop()
            {
                return top;
            }
            public void Push(int dato, ListBox lstPila)
            {
                Nodo nuevo = new Nodo(" " + dato);
                nuevo.sig = top;
                top = nuevo;

                lstPila.Items.Add($"Dato {dato} insertado en la pila.");
            }

            public void Pop(ListBox lstPila)
            {
                if (top == null)
                {
                    lstPila.Items.Add("Pila vacía.");
                }
                else
                {
                    Nodo aux = top;
                    top = top.sig;
                    lstPila.Items.Add($"Dato {aux.Dato} eliminado de la pila.");
                }
            }

            public void Mostrar(ListBox lstPila)
            {
                if (top == null)
                {
                    lstPila.Items.Add("Pila vacía.");
                }
                else
                {
                    lstPila.Items.Add("Contenido de la pila:");
                    Nodo actual = top;
                    int posicion = 0;
                    while (actual != null)
                    {
                        lstPila.Items.Add($"[{posicion}] -> {actual.Dato}");
                        actual = actual.sig;
                        posicion++;
                    }
                }
            }
        }
    }

