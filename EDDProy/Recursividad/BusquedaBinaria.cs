using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad
{
    internal class BusquedaBinaria
    {
        public static int Operaciones { get; private set; }
        public static int Realizar(int[] arr, int izquierda, int derecha, int objetivo)
        {
            Operaciones++;
            if (izquierda > derecha)
                return -1;

            int medio = (izquierda + derecha) / 2;

            if (arr[medio] == objetivo)
                return medio;
            if (arr[medio] > objetivo)
                return Realizar(arr, izquierda, medio - 1, objetivo);
            return Realizar(arr, medio + 1, derecha, objetivo);
        }

        public static void ResetOperaciones()
        {
            Operaciones = 0;
        }
    }
}
