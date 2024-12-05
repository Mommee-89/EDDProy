using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad
{
    internal class Hanoi
    {
        public static int Operaciones { get; private set; }
        public static void Resolver(int discos, char desde, char hacia, char auxiliar, Action<string> registrarMovimiento)
        {
            Operaciones++;
            if (discos == 1)
            {
                registrarMovimiento($"Mover disco 1 de {desde} a {hacia}");
                return;
            }
            Resolver(discos - 1, desde, auxiliar, hacia, registrarMovimiento);
            registrarMovimiento($"Mover disco {discos} de {desde} a {hacia}");
            Resolver(discos - 1, auxiliar, hacia, desde, registrarMovimiento);
        }
        public static void ResetOperaciones()
        {
            Operaciones = 0;
        }
    }
}
