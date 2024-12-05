using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Busqueda_y_Ordenamiento.Clases
{
    internal class Ordenamiento
    {
        /// <summary>
        /// Método para ordenar un arreglo de enteros utilizando el algoritmo de burbuja.
        /// </summary>
        /// <param name="array">Arreglo de enteros a ordenar.</param>
        public void OrdenarBurbuja(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Intercambio de elementos
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swapped = true;
                    }
                }

                // Si no hubo intercambios, el arreglo ya está ordenado
                if (!swapped)
                    break;
            }
        }

        /// <summary>
        /// Método público para iniciar el algoritmo de Quicksort.
        /// </summary>
        /// <param name="array">Arreglo de enteros a ordenar.</param>
        public void OrdenarQuicksort(int[] array)
        {
            Quicksort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Método recursivo del algoritmo de Quicksort.
        /// </summary>
        /// <param name="array">Arreglo a ordenar.</param>
        /// <param name="low">Índice inicial.</param>
        /// <param name="high">Índice final.</param>
        private void Quicksort(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Particiona el arreglo y obtiene el índice del pivote
                int pivotIndex = Particionar(array, low, high);

                // Ordena recursivamente los elementos a la izquierda y derecha del pivote
                Quicksort(array, low, pivotIndex - 1);
                Quicksort(array, pivotIndex + 1, high);
            }
        }

        /// <summary>
        /// Método para particionar el arreglo y colocar el pivote en su posición correcta.
        /// </summary>
        /// <param name="array">Arreglo a particionar.</param>
        /// <param name="low">Índice inicial.</param>
        /// <param name="high">Índice final.</param>
        /// <returns>Índice del pivote.</returns>
        private int Particionar(int[] array, int low, int high)
        {
            int pivot = array[high]; // Elegimos el último elemento como pivote
            int i = low - 1;         // Índice del elemento más pequeño

            for (int j = low; j < high; j++)
            {
                // Si el elemento actual es menor o igual al pivote
                if (array[j] <= pivot)
                {
                    i++;
                    // Intercambiar elementos
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            // Colocar el pivote en su posición correcta
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }

        /// <summary>
        /// Método para ordenar un arreglo utilizando el algoritmo ShellSort.
        /// </summary>
        /// <param name="array">Arreglo de enteros a ordenar.</param>
        public void OrdenarShellSort(int[] array)
        {
            int n = array.Length;

            // Inicializamos el intervalo (gap) a la mitad del tamaño del arreglo
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Realizamos una ordenación por inserción modificada para el intervalo actual
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;

                    // Comparamos y movemos los elementos del intervalo
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }

                    // Colocamos el elemento en su posición correcta
                    array[j] = temp;
                }
            }
        }

        /// <summary>
        /// Método para ordenar un arreglo utilizando el algoritmo Radix Sort.
        /// </summary>
        /// <param name="array">Arreglo de enteros a ordenar.</param>
        public void OrdenarRadixSort(int[] array)
        {
            // Obtener el número más grande para conocer el número de dígitos
            int max = ObtenerMaximo(array);

            // Realizar un conteo para cada posición de dígito
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                ContarPorDígitos(array, exp);
            }
        }

        /// <summary>
        /// Método para encontrar el valor máximo en el arreglo.
        /// </summary>
        private int ObtenerMaximo(int[] array)
        {
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        /// <summary>
        /// Método para ordenar los elementos de acuerdo con un dígito específico (exp).
        /// </summary>
        private void ContarPorDígitos(int[] array, int exp)
        {
            int n = array.Length;
            int[] output = new int[n]; // Arreglo temporal para almacenar resultados ordenados
            int[] count = new int[10]; // Cuenta de dígitos (0-9)

            // Contar ocurrencias de cada dígito
            for (int i = 0; i < n; i++)
            {
                int index = (array[i] / exp) % 10;
                count[index]++;
            }

            // Cambiar count[i] para que contenga las posiciones reales en output[]
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Construir el arreglo de salida ordenado
            for (int i = n - 1; i >= 0; i--)
            {
                int index = (array[i] / exp) % 10;
                output[count[index] - 1] = array[i];
                count[index]--;
            }

            // Copiar los elementos ordenados de output[] al array original
            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }
        }
    }
}

