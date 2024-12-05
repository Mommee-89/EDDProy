using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EDDemo.Recursividad
{
    public class Fibonacci
    {
        public static int Operaciones { get; private set; }
        public static BigInteger[] Calcular(int n)
        {
            Operaciones = 0;
            BigInteger[] secuencia = new BigInteger[n + 1];
            secuencia[0] = 0;
            Operaciones++;
            if (n > 0)
            {
                secuencia[1] = 1;
                Operaciones++;
            }
            for (int i = 2; i <= n; i++)
            {
                secuencia[i] = secuencia[i - 1] + secuencia[i - 2];
                Operaciones += 2;
            }
            return secuencia;
        }
        public static void ResetOperaciones()
        {
            Operaciones = 0;
        }
    }
}
