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
        public ClaseListaSimpleOrdenada<EmpresaBomberosFuego> lista= new ClaseListaSimpleOrdenada<EmpresaBomberosFuego>(true,false);
        public EmpresaBomberosFuego bom = new EmpresaBomberosFuego();
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
                bom = new EmpresaBomberosFuego();
                bom.ID = int.Parse(txtID.Text);
                bom.Nombre = txtNombre.Text;
                bom.Puesto = cmbRango.Text;
                bom.Seguro = bool.Parse(chbSeguro.Text);
                bom.Sueldo = double.Parse(txtSueldo.Text);
                bom.Fecha = (DateTime)dtpFecha.Value;
                lista.AgregarNodo(bom);
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
