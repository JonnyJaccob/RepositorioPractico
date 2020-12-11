namespace PruebaABB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbPostOrden = new System.Windows.Forms.RadioButton();
            this.rdbInOrden = new System.Windows.Forms.RadioButton();
            this.rdbPreOrden = new System.Windows.Forms.RadioButton();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.TCampo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCampo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCampo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCampo9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCampo3 = new System.Windows.Forms.TextBox();
            this.txtCampo2 = new System.Windows.Forms.TextBox();
            this.txtCampo1 = new System.Windows.Forms.TextBox();
            this.lblC3 = new System.Windows.Forms.Label();
            this.lblC2 = new System.Windows.Forms.Label();
            this.lblC1 = new System.Windows.Forms.Label();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pcbGrafico = new System.Windows.Forms.PictureBox();
            this.chbBuscar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRuta = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbPostOrden);
            this.groupBox3.Controls.Add(this.rdbInOrden);
            this.groupBox3.Controls.Add(this.rdbPreOrden);
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 178);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de recorrido y desplege de datos";
            // 
            // rdbPostOrden
            // 
            this.rdbPostOrden.AutoSize = true;
            this.rdbPostOrden.Location = new System.Drawing.Point(29, 124);
            this.rdbPostOrden.Name = "rdbPostOrden";
            this.rdbPostOrden.Size = new System.Drawing.Size(75, 17);
            this.rdbPostOrden.TabIndex = 13;
            this.rdbPostOrden.TabStop = true;
            this.rdbPostOrden.Text = "PostOrden";
            this.rdbPostOrden.UseVisualStyleBackColor = true;
            this.rdbPostOrden.CheckedChanged += new System.EventHandler(this.rdbPostOrden_CheckedChanged_1);
            // 
            // rdbInOrden
            // 
            this.rdbInOrden.AutoSize = true;
            this.rdbInOrden.Location = new System.Drawing.Point(29, 79);
            this.rdbInOrden.Name = "rdbInOrden";
            this.rdbInOrden.Size = new System.Drawing.Size(63, 17);
            this.rdbInOrden.TabIndex = 0;
            this.rdbInOrden.TabStop = true;
            this.rdbInOrden.Text = "InOrden";
            this.rdbInOrden.UseVisualStyleBackColor = true;
            this.rdbInOrden.CheckedChanged += new System.EventHandler(this.rdbInOrden_CheckedChanged_1);
            // 
            // rdbPreOrden
            // 
            this.rdbPreOrden.AutoSize = true;
            this.rdbPreOrden.Location = new System.Drawing.Point(29, 34);
            this.rdbPreOrden.Name = "rdbPreOrden";
            this.rdbPreOrden.Size = new System.Drawing.Size(70, 17);
            this.rdbPreOrden.TabIndex = 12;
            this.rdbPreOrden.TabStop = true;
            this.rdbPreOrden.Text = "PreOrden";
            this.rdbPreOrden.UseVisualStyleBackColor = true;
            this.rdbPreOrden.CheckedChanged += new System.EventHandler(this.rdbPreOrden_CheckedChanged_1);
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TCampo1,
            this.TCampo2,
            this.TCampo3,
            this.TCampo9});
            this.Tabla.Location = new System.Drawing.Point(236, 328);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(609, 136);
            this.Tabla.TabIndex = 11;
            this.Tabla.Click += new System.EventHandler(this.clickdata);
            // 
            // TCampo1
            // 
            this.TCampo1.HeaderText = "Campo1";
            this.TCampo1.Name = "TCampo1";
            this.TCampo1.ReadOnly = true;
            // 
            // TCampo2
            // 
            this.TCampo2.HeaderText = "Campo2";
            this.TCampo2.Name = "TCampo2";
            this.TCampo2.ReadOnly = true;
            // 
            // TCampo3
            // 
            this.TCampo3.HeaderText = "Campo3";
            this.TCampo3.Name = "TCampo3";
            this.TCampo3.ReadOnly = true;
            // 
            // TCampo9
            // 
            this.TCampo9.HeaderText = "Campo9";
            this.TCampo9.Name = "TCampo9";
            this.TCampo9.ReadOnly = true;
            this.TCampo9.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCampo3);
            this.groupBox2.Controls.Add(this.txtCampo2);
            this.groupBox2.Controls.Add(this.txtCampo1);
            this.groupBox2.Controls.Add(this.lblC3);
            this.groupBox2.Controls.Add(this.lblC2);
            this.groupBox2.Controls.Add(this.lblC1);
            this.groupBox2.Controls.Add(this.pcbImagen);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 238);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtCampo3
            // 
            this.txtCampo3.Location = new System.Drawing.Point(108, 66);
            this.txtCampo3.Name = "txtCampo3";
            this.txtCampo3.Size = new System.Drawing.Size(100, 20);
            this.txtCampo3.TabIndex = 8;
            // 
            // txtCampo2
            // 
            this.txtCampo2.Location = new System.Drawing.Point(168, 39);
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(40, 20);
            this.txtCampo2.TabIndex = 7;
            // 
            // txtCampo1
            // 
            this.txtCampo1.Location = new System.Drawing.Point(108, 13);
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.Size = new System.Drawing.Size(100, 20);
            this.txtCampo1.TabIndex = 6;
            // 
            // lblC3
            // 
            this.lblC3.AutoSize = true;
            this.lblC3.Location = new System.Drawing.Point(8, 69);
            this.lblC3.Name = "lblC3";
            this.lblC3.Size = new System.Drawing.Size(35, 13);
            this.lblC3.TabIndex = 2;
            this.lblC3.Text = "label3";
            // 
            // lblC2
            // 
            this.lblC2.AutoSize = true;
            this.lblC2.Location = new System.Drawing.Point(7, 43);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(35, 13);
            this.lblC2.TabIndex = 1;
            this.lblC2.Text = "label2";
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.Location = new System.Drawing.Point(9, 20);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(35, 13);
            this.lblC1.TabIndex = 0;
            this.lblC1.Text = "label1";
            // 
            // pcbImagen
            // 
            this.pcbImagen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pcbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pcbImagen.Image")));
            this.pcbImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.InitialImage")));
            this.pcbImagen.Location = new System.Drawing.Point(12, 92);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(313, 147);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 7;
            this.pcbImagen.TabStop = false;
            this.pcbImagen.Click += new System.EventHandler(this.pcbImagen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExam);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.btnDibujar);
            this.groupBox1.Controls.Add(this.btnRecorrer);
            this.groupBox1.Controls.Add(this.btnVaciar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(733, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 301);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(3, 198);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(103, 23);
            this.btnExam.TabIndex = 10;
            this.btnExam.Text = "obtener cantidad";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(17, 272);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(6, 234);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 32);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar Aleatorio";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(17, 169);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 7;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click_1);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(17, 139);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrer.TabIndex = 6;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(17, 109);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 23);
            this.btnVaciar.TabIndex = 5;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(17, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(17, 49);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // pcbGrafico
            // 
            this.pcbGrafico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbGrafico.Location = new System.Drawing.Point(410, 12);
            this.pcbGrafico.Name = "pcbGrafico";
            this.pcbGrafico.Size = new System.Drawing.Size(308, 266);
            this.pcbGrafico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGrafico.TabIndex = 8;
            this.pcbGrafico.TabStop = false;
            // 
            // chbBuscar
            // 
            this.chbBuscar.AutoSize = true;
            this.chbBuscar.Location = new System.Drawing.Point(26, 271);
            this.chbBuscar.Name = "chbBuscar";
            this.chbBuscar.Size = new System.Drawing.Size(263, 17);
            this.chbBuscar.TabIndex = 13;
            this.chbBuscar.Text = "¿Desea buscar pulsando un elemento de la tabla?";
            this.chbBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ruta de la carpeta";
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(528, 284);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(140, 33);
            this.btnRuta.TabIndex = 15;
            this.btnRuta.Text = "Cambiar Ruta";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 476);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbBuscar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbGrafico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbPostOrden;
        private System.Windows.Forms.RadioButton rdbInOrden;
        private System.Windows.Forms.RadioButton rdbPreOrden;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCampo3;
        private System.Windows.Forms.TextBox txtCampo2;
        private System.Windows.Forms.TextBox txtCampo1;
        private System.Windows.Forms.Label lblC3;
        private System.Windows.Forms.Label lblC2;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pcbGrafico;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.CheckBox chbBuscar;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRuta;
    }
}

