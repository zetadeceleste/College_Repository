namespace AccesoADatosLINQ
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEjercicioA = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEjercicioE = new System.Windows.Forms.Button();
            this.btnEjercicioF = new System.Windows.Forms.Button();
            this.btnEjercicioB = new System.Windows.Forms.Button();
            this.btnEjercicioC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEjercicioA
            // 
            this.btnEjercicioA.Location = new System.Drawing.Point(296, 387);
            this.btnEjercicioA.Name = "btnEjercicioA";
            this.btnEjercicioA.Size = new System.Drawing.Size(75, 23);
            this.btnEjercicioA.TabIndex = 1;
            this.btnEjercicioA.Text = "Ejercicio A";
            this.btnEjercicioA.UseVisualStyleBackColor = true;
            this.btnEjercicioA.Click += new System.EventHandler(this.btnEjercicioA_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(635, 416);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(141, 23);
            this.btnTodo.TabIndex = 2;
            this.btnTodo.Text = "Mostrar Datos/Cambios";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ejercicio D";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEjercicioD_Click);
            // 
            // btnEjercicioE
            // 
            this.btnEjercicioE.Location = new System.Drawing.Point(620, 387);
            this.btnEjercicioE.Name = "btnEjercicioE";
            this.btnEjercicioE.Size = new System.Drawing.Size(75, 23);
            this.btnEjercicioE.TabIndex = 4;
            this.btnEjercicioE.Text = "Ejercicio E";
            this.btnEjercicioE.UseVisualStyleBackColor = true;
            this.btnEjercicioE.Click += new System.EventHandler(this.btnEjercicioE_Click);
            // 
            // btnEjercicioF
            // 
            this.btnEjercicioF.Location = new System.Drawing.Point(701, 387);
            this.btnEjercicioF.Name = "btnEjercicioF";
            this.btnEjercicioF.Size = new System.Drawing.Size(75, 23);
            this.btnEjercicioF.TabIndex = 5;
            this.btnEjercicioF.Text = "Ejercicio F";
            this.btnEjercicioF.UseVisualStyleBackColor = true;
            this.btnEjercicioF.Click += new System.EventHandler(this.btnEjercicioF_Click);
            // 
            // btnEjercicioB
            // 
            this.btnEjercicioB.Location = new System.Drawing.Point(377, 387);
            this.btnEjercicioB.Name = "btnEjercicioB";
            this.btnEjercicioB.Size = new System.Drawing.Size(75, 23);
            this.btnEjercicioB.TabIndex = 6;
            this.btnEjercicioB.Text = "Ejercicio B";
            this.btnEjercicioB.UseVisualStyleBackColor = true;
            this.btnEjercicioB.Click += new System.EventHandler(this.btnEjercicioB_Click);
            // 
            // btnEjercicioC
            // 
            this.btnEjercicioC.Location = new System.Drawing.Point(458, 387);
            this.btnEjercicioC.Name = "btnEjercicioC";
            this.btnEjercicioC.Size = new System.Drawing.Size(75, 23);
            this.btnEjercicioC.TabIndex = 7;
            this.btnEjercicioC.Text = "Ejercicio C";
            this.btnEjercicioC.UseVisualStyleBackColor = true;
            this.btnEjercicioC.Click += new System.EventHandler(this.btnEjercicioC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEjercicioC);
            this.Controls.Add(this.btnEjercicioB);
            this.Controls.Add(this.btnEjercicioF);
            this.Controls.Add(this.btnEjercicioE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnEjercicioA);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEjercicioA;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEjercicioE;
        private System.Windows.Forms.Button btnEjercicioF;
        private System.Windows.Forms.Button btnEjercicioB;
        private System.Windows.Forms.Button btnEjercicioC;
    }
}

