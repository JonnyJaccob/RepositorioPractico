namespace PracticaOrdenar
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBurSeñal = new System.Windows.Forms.Button();
            this.btnBurDer = new System.Windows.Forms.Button();
            this.btnBurIzq = new System.Windows.Forms.Button();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnRadix = new System.Windows.Forms.Button();
            this.btnShaker = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVaciar);
            this.groupBox1.Controls.Add(this.btnExam);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(388, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 435);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(7, 331);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(109, 23);
            this.btnVaciar.TabIndex = 7;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(8, 285);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(125, 40);
            this.btnExam.TabIndex = 6;
            this.btnExam.Text = "Ordenar descendente por izquierda";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 395);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(6, 360);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(110, 29);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "Burbuja con señal";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Burbuja Derecha";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Burbuja izquierda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.com,
            this.comm,
            this.Column1});
            this.Tabla.Location = new System.Drawing.Point(13, 12);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(344, 426);
            this.Tabla.TabIndex = 2;
            // 
            // com
            // 
            this.com.HeaderText = "Nombre";
            this.com.Name = "com";
            this.com.ReadOnly = true;
            // 
            // comm
            // 
            this.comm.HeaderText = "ID";
            this.comm.Name = "comm";
            this.comm.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sueldo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShaker);
            this.groupBox2.Controls.Add(this.btnRadix);
            this.groupBox2.Controls.Add(this.btnShell);
            this.groupBox2.Controls.Add(this.btnBurSeñal);
            this.groupBox2.Controls.Add(this.btnBurDer);
            this.groupBox2.Controls.Add(this.btnBurIzq);
            this.groupBox2.Controls.Add(this.btnQuick);
            this.groupBox2.Location = new System.Drawing.Point(546, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 419);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Botones Prueba";
            // 
            // btnBurSeñal
            // 
            this.btnBurSeñal.Location = new System.Drawing.Point(108, 68);
            this.btnBurSeñal.Name = "btnBurSeñal";
            this.btnBurSeñal.Size = new System.Drawing.Size(96, 42);
            this.btnBurSeñal.TabIndex = 3;
            this.btnBurSeñal.Text = "Burbuja con señal";
            this.btnBurSeñal.UseVisualStyleBackColor = true;
            // 
            // btnBurDer
            // 
            this.btnBurDer.Location = new System.Drawing.Point(6, 68);
            this.btnBurDer.Name = "btnBurDer";
            this.btnBurDer.Size = new System.Drawing.Size(96, 42);
            this.btnBurDer.TabIndex = 2;
            this.btnBurDer.Text = "Burbuja Derecha";
            this.btnBurDer.UseVisualStyleBackColor = true;
            this.btnBurDer.Click += new System.EventHandler(this.btnBurDer_Click);
            // 
            // btnBurIzq
            // 
            this.btnBurIzq.Location = new System.Drawing.Point(105, 20);
            this.btnBurIzq.Name = "btnBurIzq";
            this.btnBurIzq.Size = new System.Drawing.Size(96, 42);
            this.btnBurIzq.TabIndex = 1;
            this.btnBurIzq.Text = "Burbuja izquierda";
            this.btnBurIzq.UseVisualStyleBackColor = true;
            this.btnBurIzq.Click += new System.EventHandler(this.btnBurIzq_Click);
            // 
            // btnQuick
            // 
            this.btnQuick.Location = new System.Drawing.Point(6, 19);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(92, 43);
            this.btnQuick.TabIndex = 0;
            this.btnQuick.Text = "QuickSort";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // btnShell
            // 
            this.btnShell.Location = new System.Drawing.Point(6, 116);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(96, 42);
            this.btnShell.TabIndex = 4;
            this.btnShell.Text = "Shell sort";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnRadix
            // 
            this.btnRadix.Location = new System.Drawing.Point(105, 116);
            this.btnRadix.Name = "btnRadix";
            this.btnRadix.Size = new System.Drawing.Size(96, 42);
            this.btnRadix.TabIndex = 5;
            this.btnRadix.Text = "Radix";
            this.btnRadix.UseVisualStyleBackColor = true;
            this.btnRadix.Click += new System.EventHandler(this.btnRadix_Click);
            // 
            // btnShaker
            // 
            this.btnShaker.Location = new System.Drawing.Point(6, 164);
            this.btnShaker.Name = "btnShaker";
            this.btnShaker.Size = new System.Drawing.Size(96, 42);
            this.btnShaker.TabIndex = 6;
            this.btnShaker.Text = "Shaker Sort";
            this.btnShaker.UseVisualStyleBackColor = true;
            this.btnShaker.Click += new System.EventHandler(this.btnShaker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn com;
        private System.Windows.Forms.DataGridViewTextBoxColumn comm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Button btnBurIzq;
        private System.Windows.Forms.Button btnBurSeñal;
        private System.Windows.Forms.Button btnBurDer;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnShaker;
        private System.Windows.Forms.Button btnRadix;
        private System.Windows.Forms.Button btnShell;
    }
}

