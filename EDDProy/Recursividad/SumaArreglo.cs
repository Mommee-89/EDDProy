using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad
{
    internal class SumaArreglo
    {
        public static int Operaciones { get; private set; }
        public static int Calcular(int[] arr, int n)
        {
            Operaciones++;
            if (n == 0) return 0;
            return arr[n - 1] + Calcular(arr, n - 1);
        }
        public static void ResetOperaciones()
        {
            Operaciones = 0;
        }
    }
}
