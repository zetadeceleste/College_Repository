namespace TP_LINQ_ABM
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
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.lbl_ContactName = new System.Windows.Forms.Label();
            this.lbl_ContactTitle = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Region = new System.Windows.Forms.Label();
            this.lbl_PostalCode = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Fax = new System.Windows.Forms.Label();
            this.lbl_HomePage = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtHomePage = new System.Windows.Forms.TextBox();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1152, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(30, 25);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(54, 13);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "SupplierId";
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AutoSize = true;
            this.lbl_CompanyName.Location = new System.Drawing.Point(30, 60);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(79, 13);
            this.lbl_CompanyName.TabIndex = 2;
            this.lbl_CompanyName.Text = "CompanyName";
            // 
            // lbl_ContactName
            // 
            this.lbl_ContactName.AutoSize = true;
            this.lbl_ContactName.Location = new System.Drawing.Point(30, 95);
            this.lbl_ContactName.Name = "lbl_ContactName";
            this.lbl_ContactName.Size = new System.Drawing.Size(72, 13);
            this.lbl_ContactName.TabIndex = 3;
            this.lbl_ContactName.Text = "ContactName";
            // 
            // lbl_ContactTitle
            // 
            this.lbl_ContactTitle.AutoSize = true;
            this.lbl_ContactTitle.Location = new System.Drawing.Point(277, 25);
            this.lbl_ContactTitle.Name = "lbl_ContactTitle";
            this.lbl_ContactTitle.Size = new System.Drawing.Size(64, 13);
            this.lbl_ContactTitle.TabIndex = 4;
            this.lbl_ContactTitle.Text = "ContactTitle";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(277, 60);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(45, 13);
            this.lbl_Address.TabIndex = 5;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(277, 95);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(24, 13);
            this.lbl_City.TabIndex = 6;
            this.lbl_City.Text = "City";
            // 
            // lbl_Region
            // 
            this.lbl_Region.AutoSize = true;
            this.lbl_Region.Location = new System.Drawing.Point(510, 25);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(41, 13);
            this.lbl_Region.TabIndex = 7;
            this.lbl_Region.Text = "Region";
            // 
            // lbl_PostalCode
            // 
            this.lbl_PostalCode.AutoSize = true;
            this.lbl_PostalCode.Location = new System.Drawing.Point(510, 60);
            this.lbl_PostalCode.Name = "lbl_PostalCode";
            this.lbl_PostalCode.Size = new System.Drawing.Size(61, 13);
            this.lbl_PostalCode.TabIndex = 8;
            this.lbl_PostalCode.Text = "PostalCode";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(510, 95);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(43, 13);
            this.lbl_Country.TabIndex = 9;
            this.lbl_Country.Text = "Country";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(762, 25);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(38, 13);
            this.lbl_Phone.TabIndex = 10;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_Fax
            // 
            this.lbl_Fax.AutoSize = true;
            this.lbl_Fax.Location = new System.Drawing.Point(762, 60);
            this.lbl_Fax.Name = "lbl_Fax";
            this.lbl_Fax.Size = new System.Drawing.Size(24, 13);
            this.lbl_Fax.TabIndex = 11;
            this.lbl_Fax.Text = "Fax";
            // 
            // lbl_HomePage
            // 
            this.lbl_HomePage.AutoSize = true;
            this.lbl_HomePage.Location = new System.Drawing.Point(762, 95);
            this.lbl_HomePage.Name = "lbl_HomePage";
            this.lbl_HomePage.Size = new System.Drawing.Size(60, 13);
            this.lbl_HomePage.TabIndex = 12;
            this.lbl_HomePage.Text = "HomePage";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(116, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 13;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(116, 53);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 20);
            this.txtCName.TabIndex = 14;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(116, 88);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(100, 20);
            this.txtContactName.TabIndex = 15;
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(360, 18);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(100, 20);
            this.txtContactTitle.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(360, 53);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 17;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(360, 88);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 18;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(595, 18);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(100, 20);
            this.txtRegion.TabIndex = 19;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(595, 53);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 20;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(595, 88);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 21;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(847, 18);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 22;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(847, 53);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 23;
            // 
            // txtHomePage
            // 
            this.txtHomePage.Location = new System.Drawing.Point(847, 88);
            this.txtHomePage.Name = "txtHomePage";
            this.txtHomePage.Size = new System.Drawing.Size(100, 20);
            this.txtHomePage.TabIndex = 24;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(1029, 16);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_Insertar.TabIndex = 25;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(1029, 50);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 26;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1029, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(1089, 211);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 28;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(942, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "FiltroXNombreCompañia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.txtHomePage);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContactTitle);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbl_HomePage);
            this.Controls.Add(this.lbl_Fax);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_PostalCode);
            this.Controls.Add(this.lbl_Region);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_ContactTitle);
            this.Controls.Add(this.lbl_ContactName);
            this.Controls.Add(this.lbl_CompanyName);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.Label lbl_ContactName;
        private System.Windows.Forms.Label lbl_ContactTitle;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Region;
        private System.Windows.Forms.Label lbl_PostalCode;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Fax;
        private System.Windows.Forms.Label lbl_HomePage;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtHomePage;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button button1;
    }
}

