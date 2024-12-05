using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EDDemo.Recursividad
{
    public class Exponente
    {
        public static int Operaciones { get; private set; }

        public static BigInteger Calcular(BigInteger baseNum, BigInteger exponente)
        {
            Operaciones++;
            if (exponente == 0) return 1;
            return baseNum * Calcular(baseNum, exponente - 1);
        }

        public static void ResetOperaciones()
        {
            Operaciones = 0;
        }
    }
}