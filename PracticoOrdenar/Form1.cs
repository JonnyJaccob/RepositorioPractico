using System.Collections.Generic;
using System;
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
        public Bomberos[] miArregloBomberos;
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
                    double yy = value / 2;
                    b.Sueldo = yy;
                    lista.AgregarNodo(b);
                    AgregarTabla(b);
                }
                Bomberos bb = new Bomberos();
                bb.Nombre = "jgks";
                bb.ID = 34;
                bb.Sueldo = 12.5;
                lista.AgregarNodo(bb);
                AgregarTabla(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }
        private void AgregarTabla(Bomberos bomberos)
        {
            Tabla.Rows.Clear();
            foreach (Bomberos b in lista)
            {
                Tabla.Rows.Add(b.Nombre,b.ID,b.Sueldo);
            }
        }
        private void AgregarTabla(Bomberos bomberos,ClaseListaDoble<Bomberos> temp)
        {
            Tabla.Rows.Clear();
            foreach (Bomberos b in temp)
            {
                Tabla.Rows.Add(b.Nombre, b.ID, b.Sueldo);
            }
        }
        private Bomberos Buscando()
        {
            DataGridViewRow row = Tabla.CurrentRow;
            if (row != null)//Para cuando hago click en la tabla
            {
                try
                {
                    Bomberos empresa = new Bomberos();
                    empresa.Nombre = Tabla.CurrentRow.Cells[0].Value.ToString();
                    empresa.ID = int.Parse(Tabla.CurrentRow.Cells[1].Value.ToString());
                    empresa.Sueldo = int.Parse(Tabla.CurrentRow.Cells[2].Value.ToString());

                    return empresa;
                }
                catch (NullReferenceException exx)
                {
                    throw new Exception("" + exx);
                }
                catch (Exception ex)
                {
                    throw new Exception("" + ex);
                }
            }
            if (row == null)
            {
                throw new Exception("Seleccione un renglon de la tabla");
            }
            throw new Exception("No se encontro");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult comprobar = MessageBox.Show("¿Desea borrar el dato seleccionado?", "Borrar Datos", MessageBoxButtons.YesNoCancel);
                switch (comprobar)
                {
                    case DialogResult.Yes:
                        try
                        {
                            var x = Buscando();
                            var y = lista.EliminarNodo(x);
                            AgregarTabla(b);
                            MessageBox.Show("Se borro: \n" + y.ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            Arreglo = new int[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] a = new int[100];

            
        }
        int[] Numero;
        void AsignarValoresIniciales(ref int primer, ref int ultimo)
        {
            for (int i = 0; i < Numero.Length; i++)
            {
                if (i == 0)
                {
                    primer = Numero[i];
                }
                ultimo = Numero[i];
            }
        }
        string ObtenerDatos()
        {
            
            //Numero= new int[cant];
            int cont = 0;
            for (int fila = 0; fila < Tabla.Rows.Count - 1; fila++)
            {
                for (int col = 0; col < Tabla.Rows[fila].Cells.Count; col++)
                {
                    Numero[cont] = int.Parse(Tabla.Rows[fila].Cells[col].Value.ToString());
                    cont++;
                }
            }
            OrdenamientoRapido(Numero, 1);
            string g = "";
            for (int i = 0; i < 1; ++i)
            {
                g += ($"{Numero[i]},");
            }
            return g;
        }

        static int cont;
        private static int OrdenamientoRapido(int[] datos, int numero)
        {
            cont = 0;
            OrdenamientoRapido(datos, 0, numero );
            return cont;
        }
        public static void OrdenamientoRapido(int[] datos, int inf, int sup)
        {
            if (sup > inf)
            {
                int pivote = datos[sup];
                int i = inf - 1;
                int j = sup;
                do
                {
                    while (datos[++i] < pivote) ;
                    while (datos[--j] > pivote) ;
                    if (i < j)
                        swap(datos, i, j);
                }
                while (i < j);
                swap(datos, i, sup);
                OrdenamientoRapido(datos, inf, i - 1);
                OrdenamientoRapido(datos, i + 1, sup);
            }
        }
        private void Generar1()
        {
            
            Random ram = new Random();
            Numero = new int[1];
            for (int j = 0; j < 1; j++)
            {
                for (int i = 0; i < 1; i++)
                {

                    var Value = ram.Next(0, 20);
                    Tabla.Rows[j].Cells[i].Value = Value;
                    Numero[cont] = Value;
                    cont++;
                }
            }
            try
            {
                string g = ObtenerDatos();
                MessageBox.Show(g, "Numeros ordenados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        public static void swap(int[] datos, int i, int j)
        {
            int aux = datos[i];
            datos[i] = datos[j];
            datos[j] = aux;
            cont++; // variable global
        }
        public void Shell()
        {
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = Numero.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (Numero.Length - salto))
                    {
                        if (Numero[e - 1] > Numero[(e - 1) + salto])
                        {
                            auxi = Numero[(e - 1) + salto];
                            Numero[(e - 1) + salto] = Numero[e - 1];
                            Numero[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
        }
        public static void RadixSort(ref int[] data)
        {
            int i, j;
            int[] temp = new int[data.Length];

            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;

                for (i = 0; i < data.Length; ++i)
                {
                    bool move = (data[i] << shift) >= 0;

                    if (shift == 0 ? !move : move)
                        data[i - j] = data[i];
                    else
                        temp[j++] = data[i];
                }

                Array.Copy(temp, 0, data, data.Length - j, j);
            }
        }
        public void shaker(int[] numeros, int c)
        {
            int n = c;
            int izq = 1;
            int k = n;
            int aux;
            int der = n;

            do
            {
                for (int i = der; i >= izq; i--)
                {
                    if (numeros[i - 1] > numeros[i])
                    {
                        aux = numeros[i - 1];
                        numeros[i - 1] = numeros[i];
                        numeros[i] = aux;
                        k = i;
                    }
                }
                izq = k + 1;
                for (int i = izq; i <= der; i++)
                {
                    if (numeros[i - 1] > numeros[i])
                    {
                        aux = numeros[i - 1];
                        numeros[i - 1] = numeros[i];
                        numeros[i] = aux;
                        k = 1;
                    }
                }
                der = k - 1;
            }
            while (der >= izq);
        }

        public void MetodoQuickSort()
        {
            try
            {   
                int c = lista.ContarNodos();
                Numero = new int[c];
                int i = 0;
                foreach (Bomberos bomberos in lista)
                {
                    Numero[i] = bomberos.ID;
                    i++;
                }
                ClaseListaDoble<Bomberos> temporal = new ClaseListaDoble<Bomberos>(true);
                OrdenamientoRapido(Numero, c-1);
                for (int j = 0; j < c; j++)
                {
                    Bomberos e = new Bomberos();
                    e.ID = Numero[j];   
                    temporal.AgregarNodo(lista.BuscarNodo(e));
                }
                Bomberos b=new Bomberos();
                AgregarTabla(b, temporal);
                //MessageBox.Show($"Tiempo: {tim.Elapsed.TotalMilliseconds} ms");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void MetodoBurbujaIzquierda()
        {
            
            try
            {   
                int c = lista.ContarNodos();
                Numero = new int[c];
                int i = 0;
                foreach (Bomberos bomberos in lista)
                {
                    Numero[i] = bomberos.ID;
                    i++;
                }
                ClaseListaDoble<Bomberos> temporal = new ClaseListaDoble<Bomberos>(true);
                BurbujaIzquierda(Numero);
                for (int j = 0; j < c; j++)
                {
                    Bomberos e = new Bomberos();
                    e.ID = Numero[j];
                    temporal.AgregarNodo(lista.BuscarNodo(e));
                }
                Bomberos b = new Bomberos();
                AgregarTabla(b, temporal);
                //MessageBox.Show($"Tiempo: {tim.Elapsed.TotalMilliseconds} ms");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void MetodoOrdenamiento(string metodo)
        {
            try
            {
                int c = lista.ContarNodos();
                Numero = new int[c];
                int i = 0;
                foreach (Bomberos bomberos in lista)
                {
                    Numero[i] = bomberos.ID;
                    i++;
                }
                ClaseListaDoble<Bomberos> temporal = new ClaseListaDoble<Bomberos>(true);
                if (metodo == "QuickSort")
                {
                    OrdenamientoRapido(Numero, c);
                } else if (metodo == "BurIzq")
                {
                    BurbujaIzquierda(Numero);
                }
                else if (metodo == "BurDer")
                {
                    BurbujaDerecha(Numero);
                }
                else if (metodo == "BurSeñal")
                {
                    BurbujaConSenal(Numero);
                }
                else if (metodo == "Shell")
                {
                    Shell();
                }
                else if (metodo == "Radix")
                {
                    RadixSort(ref Numero);
                }
                else if (metodo == "Shaker")
                {
                    OrdenarShellSort<Bomberos>(ref miArregloBomberos);
                }
                else
                {
                    throw new Exception("Error en la palabra clave");
                }
                
                for (int j = 0; j < c; j++)
                {
                    Bomberos e = new Bomberos();
                    e.ID = Numero[j];
                    temporal.AgregarNodo(lista.BuscarNodo(e));
                }
                Bomberos b = new Bomberos();
                AgregarTabla(b, temporal);
                //MessageBox.Show($"Tiempo: {tim.Elapsed.TotalMilliseconds} ms");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void btnQuick_Click(object sender, EventArgs e)
        {
            MetodoQuickSort();
        }

        private void btnBurIzq_Click(object sender, EventArgs e)
        {
            MetodoOrdenamiento("BurIzq");
        }

        private void btnBurDer_Click(object sender, EventArgs e)
        {
            MetodoOrdenamiento("BurDer");
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult comprobar = MessageBox.Show("¿Desea borrar toda la lista?", "Borrar Datos", MessageBoxButtons.YesNoCancel);
                switch (comprobar)
                {
                    case DialogResult.Yes:
                        try
                        {
                            lista.VaciarLista();
                            AgregarTabla(b);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            MetodoOrdenamiento("Shell");
        }

        private void btnRadix_Click(object sender, EventArgs e)
        {
            MetodoOrdenamiento("Radix");
        }

        private void btnShaker_Click(object sender, EventArgs e)
        {
            miArregloBomberos = new Bomberos[lista.ContarNodos()];
            for (int i = 0; i < miArregloBomberos.Length; i++)
            {
                Bomberos r = new Bomberos();
                r.Nombre = Tabla.CurrentRow.Cells[0].Value.ToString();
                r.ID = int.Parse(Tabla.CurrentRow.Cells[1].Value.ToString());
                r.Sueldo = double.Parse(Tabla.CurrentRow.Cells[2].Value.ToString());

                miArregloBomberos[i] = r;

            }
            MetodoOrdenamiento("Shaker");
        }
        void BurbujaIzquierdaDes(int[] Arreglo,int c)
        {
            for (int i = c ; i >= 1; i--)
                for (int j = i; j <= Arreglo.Length - 1; j++)
                {

                    if (Arreglo[j] > Arreglo[j + 1])  // Comparación
                    {
                        Intercambia(Arreglo, j + 1, j);  // Intercambio de datos
                        Movimientos++;
                    }
                }
        }
        public void MetodoExam()
        {
            try
            {
                int c = lista.ContarNodos();
                Numero = new int[c];
                int i = 0;
                foreach (Bomberos bomberos in lista)
                {
                    Numero[i] = bomberos.ID;
                    i++;
                }
                ClaseListaDoble<Bomberos> temporal = new ClaseListaDoble<Bomberos>(true);
                ordenamientoBurbujaDescendente(ref Numero);
                for (int j = 0; j < c; j++)
                {
                    Bomberos e = new Bomberos();
                    e.ID = Numero[j];
                    temporal.AgregarNodo(lista.BuscarNodo(e));
                }
                Bomberos b = new Bomberos();
                AgregarTabla(b, temporal);
                //MessageBox.Show($"Tiempo: {tim.Elapsed.TotalMilliseconds} ms");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void btnExam_Click(object sender, EventArgs e)
        {
            MetodoExam();
            //OBSERVACION
        }
        public void OrdenarShellSort<Tipo>(ref Tipo[] arreglo) where Tipo : IComparable<Tipo>
        {
            int salto = arreglo.Length / 2;
            while (salto > 0)
            {
                bool bandera = true;
                while (bandera == true)
                {
                    bandera = false;
                    int posicion = 0;
                    while (posicion < (arreglo.Length - salto))
                    {
                        if (arreglo[posicion].CompareTo(arreglo[posicion + salto]) == 1)
                        {
                            Intercambiar(ref arreglo, posicion, posicion + salto);
                            bandera = true;
                        }
                        posicion++;
                    }

                }
                salto = salto / 2;
            }
        }
        void Intercambiar<Tipo>(ref Tipo[] arreglo, int intA, int intB)
        {
            Tipo aux;
            aux = arreglo[intA];
            arreglo[intA] = arreglo[intB];
            arreglo[intB] = aux;
        }
        public static void ordenamientoBurbujaDescendente(ref int[] numero)
        {
            
            int temp = 0;

            for (int index = 0; index < numero.Length- 1; index++)
            {


                for (int compare = 0; compare < numero.Length - 1; compare++)
                {


                    if (numero[compare] < numero[compare + 1])
                    {

                        temp = numero[compare];
                        numero[compare] = numero[compare + 1];
                        numero[compare + 1] = temp;

                    }

                }
            }

        }
    }
}

