using EDDemo.Metodos_de_Busqueda_y_Ordenamiento.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_Busqueda_y_Ordenamiento
{
    public partial class FormMetodos : Form
    {
        public FormMetodos()
        {
            InitializeComponent();
        }

        private void btBurbuja_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los datos del TextBox
                string input = txtIngresar.Text;

                // Convertir los datos a un arreglo de enteros
                int[] numeros = input.Split(',')
                                     .Select(num => int.Parse(num.Trim()))
                                     .ToArray();

                // Crear una instancia de la clase Ordenamiento
                Ordenamiento ordenamiento = new Ordenamiento();

                // Ordenar los números
                ordenamiento.OrdenarBurbuja(numeros);

                // Mostrar el resultado en el Label
                lblResultado.Text = "Ordenado: " + string.Join(", ", numeros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Asegúrate de ingresar números válidos separados por comas.\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btQuicksort_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los datos del TextBox
                string input = txtIngresar.Text;

                // Convertir los datos a un arreglo de enteros
                int[] numeros = input.Split(',')
                                     .Select(num => int.Parse(num.Trim()))
                                     .ToArray();

                // Crear una instancia de la clase Ordenamiento
                Ordenamiento ordenamiento = new Ordenamiento();

                // Ordenar los números usando Quicksort
                ordenamiento.OrdenarQuicksort(numeros);

                // Mostrar el resultado en el Label
                lblResultado.Text = "Ordenado: " + string.Join(", ", numeros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Asegúrate de ingresar números válidos separados por comas.\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btShellSort_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los datos del TextBox
                string input = txtIngresar.Text;

                // Convertir los datos a un arreglo de enteros
                int[] numeros = input.Split(',')
                                     .Select(num => int.Parse(num.Trim()))
                                     .ToArray();

                // Crear una instancia de la clase Ordenamiento
                Ordenamiento ordenamiento = new Ordenamiento();

                // Ordenar los números usando ShellSort
                ordenamiento.OrdenarShellSort(numeros);

                // Mostrar el resultado en el Label
                lblResultado.Text = "Ordenado: " + string.Join(", ", numeros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Asegúrate de ingresar números válidos separados por comas.\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRadix_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los datos del TextBox
                string input = txtIngresar.Text;

                // Convertir los datos a un arreglo de enteros
                int[] numeros = input.Split(',')
                                     .Select(num => int.Parse(num.Trim()))
                                     .ToArray();

                // Crear una instancia de la clase Ordenamiento
                Ordenamiento ordenamiento = new Ordenamiento();

                // Ordenar los números usando Radix Sort
                ordenamiento.OrdenarRadixSort(numeros);

                // Mostrar el resultado en el Label
                lblResultado.Text = "Ordenado: " + string.Join(", ", numeros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Asegúrate de ingresar números válidos separados por comas.\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btBusquedaBinaria_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los datos del TextBox del arreglo
                string inputArray = txtArray.Text;

                // Leer el valor a buscar
                string inputValor = txtValor.Text;
                int valor = int.Parse(inputValor.Trim());

                // Convertir el arreglo a un arreglo de enteros
                int[] numeros = inputArray.Split(',')
                                          .Select(num => int.Parse(num.Trim()))
                                          .ToArray();

                // Ordenar el arreglo (la búsqueda binaria requiere un arreglo ordenado)
                Array.Sort(numeros);

                // Crear una instancia de la clase Busqueda
                Busqueda busqueda = new Busqueda();

                // Realizar la búsqueda binaria
                int resultado = busqueda.BusquedaBinaria(numeros, valor);

                // Mostrar el resultado en el Label
                if (resultado != -1)
                {
                    lblResultado2.Text = $"Valor encontrado en el índice: {resultado}";
                }
                else
                {
                    lblResultado2.Text = "Valor no encontrado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Asegúrate de ingresar números válidos separados por comas y un valor a buscar.\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btBusquedaHash_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los datos del TextBox del arreglo
                string inputArray = txtArray.Text;

                // Leer el valor a buscar
                string inputValor = txtValor.Text;
                int valor = int.Parse(inputValor.Trim());

                // Convertir el arreglo a un arreglo de enteros
                int[] numeros = inputArray.Split(',')
                                          .Select(num => int.Parse(num.Trim()))
                                          .ToArray();

                // Crear una instancia de la clase Busqueda
                Busqueda busqueda = new Busqueda();

                // Realizar la búsqueda utilizando la tabla hash
                bool encontrado = busqueda.BusquedaHash(numeros, valor);

                // Mostrar el resultado en el Label
                lblResultado2.Text = encontrado ? "Valor encontrado en la tabla hash" : "Valor no encontrado en la tabla hash";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Asegúrate de ingresar números válidos separados por comas y un valor a buscar.\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }  
}
