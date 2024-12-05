using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
   
    public class Nodo
    {
        public String Dato;
        public Nodo sig;

        public Nodo(string dato)
        {
            this.Dato = dato;
            this.sig = null;
        }
    }
    public class NodoC
    {
        public string Dat;
        public NodoC siguiente;

        public NodoC(string dat)
        {
            this.Dat = dat;
            this.siguiente = null;
        }
    }
}

