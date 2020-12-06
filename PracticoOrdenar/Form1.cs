using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseListaSimpleOrdenada;
using System.Windows.Forms;

namespace PracticaOrdenar
{
    public partial class Form1 : Form
    {
        public ClaseListaDoble<Bomberos> lista = new ClaseListaDoble<Bomberos>(true);
        public Bomberos b = new Bomberos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                var random = new Random();

                for (int i = 0; i < 10; i++)
                {
                    var value = random.Next(1, 200);
                    var opc = random.Next(1, 4);
                    EmpresaCurtidoraPieles Aux = new EmpresaCurtidoraPieles();
                    Aux.Nombre = RandomString(4);
                    Aux.ID = value;
                    Aux.Sueldo = value;
                    Aux.Fecha = DateTime.Now;
                    Aux.Inicial = char.Parse(RandomString(1));
                    Aux.Puesto = "Empreado";
                    Aux.Seguro = false;
                    Aux.Genero = "Masculino";
                    Aux.Direccion = PathDireccion;
                    arbol.AgregarNodo(Aux);
                    AgregarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }*/
        string RandomString(int lengt)
        {
            var random = new Random();

            string cadena = "";

            for (int i = 0; i < lengt; i++)
            {
                var value = random.Next(1, 26);
                cadena += $"{NextLetra(value)}";
            }
            return cadena;

        }
        string NextLetra(int letra)
        {
            switch (letra)
            {
                case 1:
                    return "a";
                case 2:
                    return "b";
                case 3:
                    return "c";
                case 4:
                    return "d";
                case 5:
                    return "e";
                case 6:
                    return "f";
                case 7:
                    return "g";
                case 8:
                    return "h";
                case 9:
                    return "i";
                case 10:
                    return "j";
                case 11:
                    return "k";
                case 12:
                    return "l";
                case 13:
                    return "m";
                case 14:
                    return "n";
                case 15:
                    return "o";
                case 16:
                    return "p";
                case 17:
                    return "q";
                case 18:
                    return "r";
                case 19:
                    return "s";
                case 20:
                    return "t";
                case 21:
                    return "u";
                case 22:
                    return "v";
                case 23:
                    return "w";
                case 24:
                    return "x";
                case 25:
                    return "y";
                case 26:
                    return "z";
                default:
                    throw new Exception("Fuera del rango");
            }
        }

        int[] Arreglo = new int[100];
        int Movimientos = 0;
        private void SeleccionarAccion(int a)
        {
            switch (a)
            {
                case 1: BurbujaIzquierda(Arreglo); break;
                case 2: BurbujaDerecha(Arreglo); break;
                case 3: BurbujaConSenal(Arreglo); break;
                case 4: BorrarArreglo(); break;
                default: Console.WriteLine("Comando no existente"); break;
            }
        }
        string RecorrerArreglo(int[] Arreglo)
        {
            string resultado = "[";
            for (int x = 0; x < Arreglo.Length; x++)
            {
                resultado += Arreglo[x].ToString() + " ";
            }
            return resultado + "]";
        }

        void BurbujaIzquierda(int[] Arreglo)
        {
            for (int i = 1; i <= Arreglo.Length - 1; i++)
                for (int j = Arreglo.Length - 1; j >= i; j--)
                {

                    if (Arreglo[j] < Arreglo[j - 1])  // Comparación
                    {
                        Intercambia(Arreglo, j - 1, j);  // Intercambio de datos
                        Movimientos++;
                    }
                }
        }

        void BurbujaDerecha(int[] Arreglo)
        {
            for (int i = Arreglo.Length - 2; i >= 0; i--)
                for (int j = 0; j <= i; j++)
                {
                    if (Arreglo[j] > Arreglo[j + 1]) // Comparación
                    {
                        Intercambia(Arreglo, j, j + 1); // Intercambio de datos
                        Movimientos++;
                    }
                }
        }
        void BurbujaConSenal(int[] Arreglo)
        {
            int i = 0;
            bool Bandera = true; // Declaración de la Bandera

            // Mientras haya celdas en el arreglo y la Bandera esté "encendida"
            while (i < Arreglo.Length && Bandera)
            {
                Bandera = false;  // "Apaga" la Bandera
                for (int j = 0; j <= Arreglo.Length - i - 2; j++)
                {

                    if (Arreglo[j] > Arreglo[j + 1]) // Comparación
                    {
                        Intercambia(Arreglo, j, j + 1); // Intercambio de datos
                        Bandera = true;  // "Enciende" la Bandera
                        Movimientos++;
                    }
                }

                i++;
            }
        }
        void BorrarArreglo()
        {
            Arreglo = new int[0];
        }

        void Intercambia(int[] Arreglo, int a, int b)
        {
            int x; // Objeto auxiliar

            x = Arreglo[a];
            Arreglo[a] = Arreglo[b];
            Arreglo[b] = x;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var random = new Random();

                for (int i = 0; i < 10; i++)
                {
                    var value = random.Next(1, 200);
                    var opc = random.Next(1, 4);
                    Bomberos b = new Bomberos();
                    b.Nombre = RandomString(5);
                    b.ID = value;
                    b.Sueldo = value / 2;
                    lista.AgregarNodo(b);
                    AgregarTabla();
                }
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }
        private void AgregarTabla()
        {
            Tabla.Rows.Clear();
            foreach (Bomberos b in lista)
            {
                Tabla.Rows.Add(b.Nombre,b.ID,b.Sueldo);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lista.VaciarLista();
            Arreglo = new int[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] a = new int[100];

            
        }
    }
}
