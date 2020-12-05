namespace ListaSimpleBomberos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbInicial = new System.Windows.Forms.ComboBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.chbSeguro = new System.Windows.Forms.CheckBox();
            this.cmbRango = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stringNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chrInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dblSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtmFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbRango);
            this.groupBox1.Controls.Add(this.chbSeguro);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.cmbInicial);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Letra Inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sueldo al mes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de ingreso al equipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Puesto o rango preferido:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(150, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // cmbInicial
            // 
            this.cmbInicial.FormattingEnabled = true;
            this.cmbInicial.Location = new System.Drawing.Point(150, 77);
            this.cmbInicial.Name = "cmbInicial";
            this.cmbInicial.Size = new System.Drawing.Size(47, 21);
            this.cmbInicial.TabIndex = 9;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(150, 105);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 10;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(150, 131);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 11;
            // 
            // chbSeguro
            // 
            this.chbSeguro.AutoSize = true;
            this.chbSeguro.Location = new System.Drawing.Point(148, 157);
            this.chbSeguro.Name = "chbSeguro";
            this.chbSeguro.Size = new System.Drawing.Size(102, 17);
            this.chbSeguro.TabIndex = 12;
            this.chbSeguro.Text = "¿Tiene Seguro?";
            this.chbSeguro.UseVisualStyleBackColor = true;
            this.chbSeguro.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmbRango
            // 
            this.cmbRango.FormattingEnabled = true;
            this.cmbRango.Location = new System.Drawing.Point(148, 181);
            this.cmbRango.Name = "cmbRango";
            this.cmbRango.Size = new System.Drawing.Size(121, 21);
            this.cmbRango.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(1, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(42, 118);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVaciar);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.btnCapturar);
            this.groupBox3.Location = new System.Drawing.Point(425, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 240);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Botones";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(7, 20);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(100, 35);
            this.btnCapturar.TabIndex = 0;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(7, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 34);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(7, 104);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Enabled = false;
            this.btnVaciar.Location = new System.Drawing.Point(7, 150);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(100, 40);
            this.btnVaciar.TabIndex = 3;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.stringNombre,
            this.chrInicial,
            this.dblSueldo,
            this.dtmFechaIngreso,
            this.Seguro,
            this.txtPuesto});
            this.Tabla.Location = new System.Drawing.Point(13, 259);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(535, 179);
            this.Tabla.TabIndex = 2;
            // 
            // intID
            // 
            this.intID.HeaderText = "ID";
            this.intID.Name = "intID";
            this.intID.ReadOnly = true;
            // 
            // stringNombre
            // 
            this.stringNombre.HeaderText = "Nombre";
            this.stringNombre.Name = "stringNombre";
            this.stringNombre.ReadOnly = true;
            // 
            // chrInicial
            // 
            this.chrInicial.HeaderText = "Inicial";
            this.chrInicial.Name = "chrInicial";
            this.chrInicial.ReadOnly = true;
            // 
            // dblSueldo
            // 
            this.dblSueldo.HeaderText = "Sueldo";
            this.dblSueldo.Name = "dblSueldo";
            this.dblSueldo.ReadOnly = true;
            // 
            // dtmFechaIngreso
            // 
            this.dtmFechaIngreso.HeaderText = "Fecha Ingreso";
            this.dtmFechaIngreso.Name = "dtmFechaIngreso";
            this.dtmFechaIngreso.ReadOnly = true;
            // 
            // Seguro
            // 
            this.Seguro.HeaderText = "¿Tiene Seguro?";
            this.Seguro.Name = "Seguro";
            this.Seguro.ReadOnly = true;
            // 
            // txtPuesto
            // 
            this.txtPuesto.HeaderText = "Puesto";
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Administracion de bomberos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbSeguro;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.ComboBox cmbInicial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbRango;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stringNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn chrInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dblSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtmFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPuesto;
    }
}

