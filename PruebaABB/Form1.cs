using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaABB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string DireccionPath = @"C:\Users\DELL\Downloads\CarpetsJosue\RepositorioPractico-main\PruebaABB\bin\Debug";
        private void Form1_Load(object sender, EventArgs e)
        {
           
            rdbPreOrden.Checked = true;
            btnExam.Text = "";//boton extra
            campo1 = "Nombre";//string
            campo2 = "Numero de identificacion";//int
            campo3 = "Sueldo al año";//double
            //campo4 = "Inicial del empleado";//char
            //campo5 = "Fecha de ingreso";//DateTime
            //campo6 = "Puesto que elabora";//string
            //campo7 = "¿Tiene seguro?";//checkbox bool
            //campo8 = "Sexo del empleado/a";//cabecera groupbox
            //rdbC1 = "Masculino";//RadioBotton 1
            //rdbC2 = "Femenino";//RadioBotton 2
            {
                lblC1.Text = campo1;
                lblC2.Text = campo2;
                lblC3.Text = campo3;
                
                TCampo1.HeaderText = campo1;//0
                TCampo2.HeaderText = campo2;
                TCampo3.HeaderText = campo3;
                
            }
        }
        
        ClaseABB<ClaseVar> arbol = new ClaseABB<ClaseVar>();
        string PathDireccion = @"C:\Users\DELL\Downloads\CarpetsJosue\Repositorio\Practico-main\PruebaABB\Draw\Perfil.png";
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var x = ObtenerObjeto("Agregar","");//Obtiene el objeto de clase b
                arbol.AgregarNodo(x);
                AgregarTabla("");//agrega la tabla de la clase b
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private new void Click(object sender, EventArgs e)
        {
            string strNombreArchivo = CargarImagen();
            if (strNombreArchivo != null)
                MostrarImagenPerfil(strNombreArchivo);
        }
        private string CargarImagen()
        {
            string strNombreArchivo = null;
            // Declaración de variable para seleccionar el archivo

            OpenFileDialog miArchivoFoto = new OpenFileDialog();
            miArchivoFoto.Title = "Seleccione la imagen que desea cargar";
            miArchivoFoto.Filter = "Archivos JPEG (*.jpg) | *.jpg";
            miArchivoFoto.InitialDirectory = "Mis documentos";
            if (miArchivoFoto.ShowDialog() == DialogResult.OK)
            {
                strNombreArchivo = miArchivoFoto.FileName;
                PathDireccion = strNombreArchivo;
                return (strNombreArchivo);
            }
            else return (null);
        }
        private void MostrarImagenPerfil(string strNombreArchivo)
        {
            Bitmap miImagen = new Bitmap(strNombreArchivo);
            pcbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagen.Image = (Image)miImagen;
            pcbImagen.Refresh();
        }
        string campo1, campo2, campo3;// campo4, campo5, campo6, campo7, campo8, rdbC1, rdbC2;

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (!arbol.Vacio) // Si no está vacío ..
                DibujarFigura(); // Invoca el método para dibujar la figura
            else
                MessageBox.Show("Árbol Binario de Búsqueda vacío", "E R R O R",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        

        private void rdbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbInOrden_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFacil_Click_1(object sender, EventArgs e)
        {
            txtCampo1.Text = "Mauricio";
            txtCampo2.Text = "1";
            txtCampo3.Text = "1000";
           
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var x = ObtenerObjeto("Agregar","");//agrega el objeto de la clase B
                arbol.AgregarNodo(x);
                AgregarTabla("");//Agrega la tabla de la clase B
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnDibujar_Click_1(object sender, EventArgs e)
        {
            if (!arbol.Vacio) // Si no está vacío ..
                DibujarFigura(); // Invoca el método para dibujar la figura
            else
                MessageBox.Show("Árbol Binario de Búsqueda vacío", "E R R O R",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {
            string strNombreArchivo = CargarImagen();
            if (strNombreArchivo != null)
                MostrarImagenPerfil(strNombreArchivo);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var x = ObtenerObjeto("Buscar","");//obtiene el objeto de la clase b
                MessageBox.Show("El objeto que busca es \n"+x.ToStringAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                throw;
            }
        }

        private void clickdata(object sender, EventArgs e)
        {
            if (chbBuscar.Checked)
            { 
                try
                {
                    var x = ObtenerObjeto("Tabla","");
                    MessageBox.Show("El objeto que busca es\n " + x.ToStringAll());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                var random = new Random();

                for (int i = 0; i < 10; i++)
                {
                    var value = random.Next(1, 200);
                    var opc = random.Next(1, 4);
                    ClaseVar Aux = new ClaseVar();//genera para la clase b
                    Aux.Nombre = RandomString(4);
                    Aux.ID = value;
                    Aux.Sueldo = value;
                  
                    
                   
                    
                    Aux.Direccion = PathDireccion;
                    arbol.AgregarNodo(Aux);
                    AgregarTabla("");
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

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            DialogResult comprobar = MessageBox.Show("¿Desea borrar todos los datos?", "Borrar Datos", MessageBoxButtons.YesNoCancel);
            switch (comprobar)
            {
                case DialogResult.Yes:
                    try
                    { 
                        arbol.Vaciar();//Vacia
                        AgregarTabla("");//Agrega a tabla elemento b
                    }catch(Exception ex)
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

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            try
            {

                string x = AgregarTabla("");//obtiene objeto clase b
                if(x=="ID:"|| x == "ID: "|| x == "ID:   "|| x == "ID: ")
                {
                    MessageBox.Show("La lista esta vacia", "Lista de identificaciones");
                }
                else
                {
                    MessageBox.Show(x, "Lista de identificaciones");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult comprobar = MessageBox.Show("¿Desea borrar el dato seleccionado?", "Borrar Datos", MessageBoxButtons.YesNoCancel);
            switch (comprobar)
            {
                case DialogResult.Yes:
                    try
                    {
                        var x = ObtenerObjeto("Buscar","a");//busca elemento clase b
                        var y = arbol.EliminarNodo(x);//Elimina de la clase b
                        AgregarTabla("");//arefresca la tabla con clase b
                        MessageBox.Show("Se borro: \n" + y.ToStringAll());
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

        private void btnRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                DireccionPath = $"{folder.SelectedPath}";
                Environment.SpecialFolder root = folder.RootFolder;

            }
            else
            {
                MessageBox.Show("A ocurrido un error inesperado");
            }
            MessageBox.Show("Resultado:" + DireccionPath);

        }

        private void btnExam_Click(object sender, EventArgs e)
        {

        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            txtCampo1.Text = "Mauricio";
            txtCampo2.Text = "1";
            txtCampo3.Text = "1000";
           

        }

        
       
        private ClaseVar ObtenerObjeto(string Tipo,string x)
        {
            ClaseVar empresa = new ClaseVar();
            if (Tipo == "Agregar")
            {
                try
                {
                    empresa.Nombre = txtCampo1.Text;
                    empresa.ID = int.Parse(txtCampo2.Text);
                    empresa.Sueldo = int.Parse(txtCampo3.Text);
                    
                    empresa.Direccion = PathDireccion;
                    return empresa;

                }
                catch (Exception ex)
                {
                    throw new Exception("" + ex);
                }
            }
            DataGridViewRow row = Tabla.CurrentRow;
            if (Tipo == "Tabla" && row != null)//Para cuando hago click en la tabla
            {
                try
                {
                    empresa.Nombre = Tabla.CurrentRow.Cells[0].Value.ToString();
                    empresa.ID = int.Parse(Tabla.CurrentRow.Cells[1].Value.ToString());
                    empresa.Sueldo = int.Parse(Tabla.CurrentRow.Cells[2].Value.ToString());
                   
                    empresa.Direccion = Tabla.CurrentRow.Cells[3].Value.ToString();
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
            if (Tipo == "Buscar" && row != null)//Para el boton buscar
            {
                try
                {
                    ClaseVar Aux = new ClaseVar();
                    txtCampo1.Text = Tabla.CurrentRow.Cells[0].Value.ToString();
                    txtCampo2.Text = Tabla.CurrentRow.Cells[1].Value.ToString();
                    txtCampo3.Text = Tabla.CurrentRow.Cells[2].Value.ToString();
                   
                    MostrarImagenPerfil(Tabla.CurrentRow.Cells[3].Value.ToString());
                    return (ObtenerObjeto("Agregar",""));
                }
                catch (Exception)
                {
                    throw new Exception("Error");
                }
            }

            if (row == null)
            {
                throw new Exception("Seleccione un renglon de la tabla");
            }
            throw new Exception("El metodo no encontro la palabra " + Tipo);
        }
        /*private string AgregarTabla()
        {
            string resultado = "ID: ";
            {
                if (rdbPreOrden.Checked)
                {

                    Tabla.Rows.Clear();
                    foreach (EmpresaCurtidoraPieles Empresa in arbol.RecorrerPreOrden())
                    {
                        IntroducirTabla(Empresa.Nombre, Empresa.ID, Empresa.Genero, Empresa.Sueldo, Empresa.Inicial, Empresa.Fecha, Empresa.Puesto, Empresa.Seguro, Empresa.Direccion);
                        resultado += $"{Empresa.ID}, ";
                    }
                    return resultado;
                }
                if (rdbInOrden.Checked)
                {
                    Tabla.Rows.Clear();
                    foreach (EmpresaCurtidoraPieles Empresa in arbol.RecorrerInOrden())
                    {
                        IntroducirTabla(Empresa.Nombre, Empresa.ID, Empresa.Genero, Empresa.Sueldo, Empresa.Inicial, Empresa.Fecha, Empresa.Puesto, Empresa.Seguro, Empresa.Direccion);
                        resultado += $"{Empresa.ID}, ";
                    }
                    return resultado;
                }
                if (rdbPostOrden.Checked)
                {
                    Tabla.Rows.Clear();
                    foreach (EmpresaCurtidoraPieles Empresa in arbol.RecorrerPostOrden())
                    {
                        IntroducirTabla(Empresa.Nombre, Empresa.ID, Empresa.Genero, Empresa.Sueldo, Empresa.Inicial, Empresa.Fecha, Empresa.Puesto, Empresa.Seguro, Empresa.Direccion);
                        resultado += $"{Empresa.ID}, ";
                    }
                    return resultado;
                }
                throw new Exception("Ocurrio un error inesperado");
            }
        }*/
        private string AgregarTabla(string x)
        {
                string resultado = "ID: ";
                {
                    if (rdbPreOrden.Checked)
                    {

                        Tabla.Rows.Clear();
                        foreach (ClaseVar Empresa in arbol.RecorrerPreOrden())
                        {
                            IntroducirTabla(Empresa.Nombre, Empresa.ID, Empresa.Sueldo,Empresa.Direccion);
                            resultado += $"{Empresa.ID}, ";
                        }
                        return resultado;
                    }
                    if (rdbInOrden.Checked)
                    {
                        Tabla.Rows.Clear();
                        foreach (ClaseVar Empresa in arbol.RecorrerInOrden())
                        {
                            IntroducirTabla(Empresa.Nombre, Empresa.ID, Empresa.Sueldo, Empresa.Direccion);
                            resultado += $"{Empresa.ID}, ";
                        }
                        return resultado;
                    }
                    if (rdbPostOrden.Checked)
                    {
                        Tabla.Rows.Clear();
                        foreach (ClaseVar Empresa in arbol.RecorrerPostOrden())
                        {
                            IntroducirTabla(Empresa.Nombre, Empresa.ID, Empresa.Sueldo, Empresa.Direccion);
                            resultado += $"{Empresa.ID}, ";
                        }
                        return resultado;
                    }
                    throw new Exception("Ocurrio un error inesperado");
                }
            }
        public void IntroducirTabla(string Name, int id,double s,  string direccion)
        {
          
            Tabla.Rows.Add(Name, id, s, direccion);
        }
    
    private void DibujarFigura()
        {
            try
            {
                string Resultado = CrearArchivoDot();
                InvocaDibujar();
                MessageBox.Show("Código para generar el archivo FIGURA.jpg con la imagen:\n\n" + Resultado + "\n\nEjecutar mediante: DOT - TJPG - O \\Figura", "CREACIÓN DEL ARCHIVO EN LENGUAJE DOT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PonerDibujo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inseperado: Pulsa de nuevo el boton \n\n\n{ex}","Error inesperado: Pulse de nuevo");
            }
        }

        private void PonerDibujo()
        {
            //pcbGrafico.Image = "";
            System.IO.FileStream AliasFigura; // Declaración del alias del archivo Figura.jpg
            
            try        // Intenta abrir el archivo
            {
                AliasFigura = new System.IO.FileStream(DireccionPath+"\\Figura.jpg",
               System.IO.FileMode.Open, System.IO.FileAccess.Read);
            }
            catch (Exception x)
            {
                throw new Exception("" + x);
            }
            try // Intenta cargar la imagen en el pictureBox
            {
                pcbGrafico.Image = System.Drawing.Bitmap.FromStream(AliasFigura);
            }//error
            catch (Exception) // En caso de error ...
            {
                MessageBox.Show("No se pudo cargar la imagen del archivo c:\\Datos\\FIGURA.jpg",
               "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AliasFigura.Close(); // Cierra el archivo ArbolBinarioBusqueda.jpg
                return;
            }
            AliasFigura.Close();
            pcbGrafico.Refresh();
        }

        private void rdbPreOrden_CheckedChanged_1(object sender, EventArgs e)
        {
            AgregarTabla("");
        }

        private void rdbInOrden_CheckedChanged_1(object sender, EventArgs e)
        {
            AgregarTabla("");
        }

        private void rdbPostOrden_CheckedChanged_1(object sender, EventArgs e)
        {
            AgregarTabla("");
        }

        private void InvocaDibujar()
        {
            // El archivo por lotes DIBUJAR.bat contiene el siguiente código:
            // @echo off
            // del \Figura.jpg
            // \"Archivos de programa\Graphviz 2.28"\bin\DOT -Tjpg -O \Figura
            //"Archivos de programa\Graphviz 2.44.1"\bin\DOT -Tjpg -O \Figura
            // Ejecuta DIBUJAR.bat ubicado en la carpeta raíz de la unidad de disco
            
            try
            {
                System.Diagnostics.Process.Start(DireccionPath+"\\DIBUJAR.bat");
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
                throw new Exception("Error al cargar el proceso");
            }
            

        }
        
        private string CrearArchivoDot()
        {
            string Resultado = "";
            arbol.CrearArchivoDot(ref  Resultado);
            
            try
            {
                System.IO.StreamWriter AliasArchivo = new System.IO.StreamWriter(DireccionPath+"\\Figura");
                AliasArchivo.WriteLine(Resultado);
                AliasArchivo.Close();
                return (Resultado);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error");
                throw new Exception("" + x);
            }
        }
    }
}
