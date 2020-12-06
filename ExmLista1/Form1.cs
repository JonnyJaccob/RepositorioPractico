using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  ClaseListaSimpleOrdenada;

namespace ListaSimpleBomberos
{
    public partial class Form1 : Form
    {
        public ClaseListaSimpleOrdenada<Bomberos> lista = new ClaseListaSimpleOrdenada<Bomberos>(true, false);
        public Bomberos bom = new Bomberos();
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bom = new Bomberos();
                bom.ID = int.Parse(txtID.Text);
                bom.Nombre = txtNombre.Text;
                bom.Puesto = cmbRango.Text;
                bom.Seguro = bool.Parse(chbSeguro.Text);
                bom.Sueldo = double.Parse(txtSueldo.Text);
                bom.Fecha = (DateTime)dtpFecha.Value;
                lista.AgregarNodo(bom);
                AgregarTabla();
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult comprobar = MessageBox.Show("¿Desea borrar el dato seleccionado?", "Borrar Datos", MessageBoxButtons.YesNoCancel);
            switch (comprobar)
            {
                case DialogResult.Yes:
                    try
                    {
                        var x = Buscando();
                        var y = lista.EliminarNodo(x);
                        AgregarTabla();
                        MessageBox.Show("Se borro: \n"+ y.ToString());
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private Bomberos Buscando()
        {
            DataGridViewRow row = Tabla.CurrentRow;
            if (row != null)//Para cuando hago click en la tabla
            {
                try
                {
                    Bomberos empresa = new Bomberos();
                    empresa.Nombre = Tabla.CurrentRow.Cells[1].Value.ToString();
                    empresa.ID = int.Parse(Tabla.CurrentRow.Cells[0].Value.ToString());
                    empresa.Sueldo = int.Parse(Tabla.CurrentRow.Cells[3].Value.ToString());
                    empresa.Inicial = char.Parse(Tabla.CurrentRow.Cells[2].Value.ToString());
                    empresa.Fecha = (DateTime)Tabla.CurrentRow.Cells[4].Value;
                    empresa.Puesto = Tabla.CurrentRow.Cells[6].Value.ToString();
                    string x = Tabla.CurrentRow.Cells[5].Value.ToString();
                    if (x == "Si")
                    {
                        empresa.Seguro = true;
                    }
                    else
                    {
                        empresa.Seguro = false;
                    }
                   
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var random = new Random();

                for (int i = 0; i < 10; i++)
                {
                    var value = random.Next(1, 200);
                    var opc = random.Next(1, 4);
                    Bomberos b = new Bomberos();
                    b.ID = value;
                    b.Nombre = RandomString(4);
                    b.Inicial = RandomString();
                    b.Sueldo = value;
                    b.Fecha = DateTime.Now;
                    b.Seguro = true;
                    b.Puesto = RandomString(6);
                    lista.AgregarNodo(b);
                    AgregarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }
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
        char RandomString()
        {

            {
                var random = new Random();

                char cadena;


                {
                    var value = random.Next(1, 26);
                    cadena = NextLetra(value,"");
                }
                return cadena;
            }
            throw new Exception("Error");
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
        char NextLetra(int letra, string extra)
        {
            switch (letra)
            {
                case 1:
                    return 'a';
                case 2:
                    return 'b';
                case 3:
                    return 'c';
                case 4:
                    return 'd';
                case 5:
                    return 'e';
                case 6:
                    return 'f';
                case 7:
                    return 'g';
                case 8:
                    return 'h';
                case 9:
                    return 'i';
                case 10:
                    return 'j';
                case 11:
                    return 'k';
                case 12:
                    return 'l';
                case 13:
                    return 'm';
                case 14:
                    return 'n';
                case 15:
                    return 'o';
                case 16:
                    return 'p';
                case 17:
                    return 'q';
                case 18:
                    return 'r';
                case 19:
                    return 's';
                case 20:
                    return 't';
                case 21:
                    return 'u';
                case 22:
                    return 'v';
                case 23:
                    return 'w';
                case 24:
                    return 'x';
                case 25:
                    return 'y';
                case 26:
                    return 'z';
                default:
                    throw new Exception("Fuera del rango");
            }
        }
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            lista.VaciarLista();
            AgregarTabla();
        }
        private void AgregarTabla()
        {
            Tabla.Rows.Clear();
            foreach (Bomberos b in lista)
            {
                string x;
                if(b.Seguro)
                {
                    x = "si";
                }
                else
                {
                    x = "no";
                }
                Tabla.Rows.Add(b.ID, b.Nombre, b.Inicial, b.Sueldo, b.Fecha, x, b.Puesto);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var x = Buscando();
                MessageBox.Show("Datos que busca: \n" + x.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }
    }
}
