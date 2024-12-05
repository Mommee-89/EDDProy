using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Busqueda_y_Ordenamiento.Clases
{
    internal class Busqueda
    {
        /// <summary>
        /// Método para realizar una búsqueda binaria en un arreglo ordenado.
        /// </summary>
        /// <param name="array">Arreglo de enteros ordenado.</param>
        /// <param name="valor">Valor a buscar.</param>
        /// <returns>Índice del valor si se encuentra; de lo contrario, -1.</returns>
        public int BusquedaBinaria(int[] array, int valor)
        {
            int izquierda = 0;
            int derecha = array.Length - 1;

            while (izquierda <= derecha)
            {
                // Calcular el índice del medio
                int medio = izquierda + (derecha - izquierda) / 2;

                // Verificar si el valor está en el medio
                if (array[medio] == valor)
                {
                    return medio; // Valor encontrado
                }

                // Si el valor es mayor, ignorar la mitad izquierda
                if (array[medio] < valor)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    // Si el valor es menor, ignorar la mitad derecha
                    derecha = medio - 1;
                }
            }

            return -1; // Valor no encontrado
        }

        /// <summary>
        /// Método para realizar una búsqueda utilizando una tabla hash.
        /// </summary>
        /// <param name="array">Arreglo de enteros a procesar.</param>
        /// <param name="valor">Valor a buscar.</param>
        /// <returns>True si el valor se encuentra, false en caso contrario.</returns>
        public bool BusquedaHash(int[] array, int valor)
        {
            // Crear la tabla hash
            HashSet<int> tablaHash = new HashSet<int>();

            // Insertar todos los elementos del arreglo en la tabla hash
            foreach (int num in array)
            {
                tablaHash.Add(num);
            }

            // Buscar el valor en la tabla hash
            return tablaHash.Contains(valor);
        }
    }
}

