using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_LINQ_ABM
{
    public partial class Form1 : Form
    {

        private static Suppliers supplier = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            supplier = new Suppliers();
            supplier.SupplierID = Int32.Parse(txtId.Text);
            supplier.CompanyName = txtCName.Text;
            supplier.ContactName = txtContactName.Text;
            supplier.ContactTitle = txtContactTitle.Text;
            supplier.Address = txtAddress.Text;
            supplier.City = txtCName.Text;
            supplier.Region = txtRegion.Text;
            supplier.PostalCode = txtPostalCode.Text;
            supplier.Country = txtCountry.Text;
            supplier.Phone = txtPhone.Text;
            supplier.Fax = txtFax.Text;
            supplier.HomePage = txtHomePage.Text;
            GestorSupplier.insertar(supplier);
            supplier = null;
            mostrarDatos();
        }



        public void mostrarDatos()
        {
            SuppliersBDDataContext dataSource = new SuppliersBDDataContext();
            var qry = from sup in dataSource.Suppliers
                      select sup;
            ;
            //dataGridView1.DataSource = null;
            dataGridView1.ColumnCount = 12;
            dataGridView1.ColumnHeadersVisible = true;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.Columns[0].Name = "SupplierId";
            dataGridView1.Columns[1].Name = "CompanyName";
            dataGridView1.Columns[2].Name = "ContactName";
            dataGridView1.Columns[3].Name = "ContactTitle";
            dataGridView1.Columns[4].Name = "Address";
            dataGridView1.Columns[5].Name = "City";
            dataGridView1.Columns[6].Name = "Region";
            dataGridView1.Columns[7].Name = "PostalCode";
            dataGridView1.Columns[8].Name = "Country";
            dataGridView1.Columns[9].Name = "Phone";
            dataGridView1.Columns[10].Name = "Fax";
            dataGridView1.Columns[11].Name = "HomePage";

            dataGridView1.Rows.Clear();
            foreach (var i in qry)
            {
                dataGridView1.Rows.Add(i.SupplierID, i.CompanyName, i.ContactName, i.ContactTitle, i.Address, i.City, i.Region, i.PostalCode, i.Country, i.Phone, i.Fax, i.HomePage);
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            supplier = new Suppliers();
            supplier.SupplierID = Int32.Parse(txtId.Text);
            supplier.CompanyName = txtCName.Text;
            supplier.ContactName = txtContactName.Text;
            supplier.ContactTitle = txtContactTitle.Text;
            supplier.Address = txtAddress.Text;
            supplier.City = txtCName.Text;
            supplier.Region = txtRegion.Text;
            supplier.PostalCode = txtPostalCode.Text;
            supplier.Country = txtCountry.Text;
            supplier.Phone = txtPhone.Text;
            supplier.Fax = txtFax.Text;
            supplier.HomePage = txtHomePage.Text;
            GestorSupplier.actualizar(supplier, supplier.SupplierID);
            supplier = null;
            mostrarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            supplier = new Suppliers();
            supplier.SupplierID = Int32.Parse(txtId.Text);
            GestorSupplier.eliminar(supplier);
            supplier = null;
            mostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> companies = GestorSupplier.filtrarCompanies();


            dataGridView1.ColumnCount = 2;
            dataGridView1.ColumnHeadersVisible = true;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.Rows.Clear();
            
            foreach (var i in companies)
            {
                IQueryable<Suppliers> sup = GestorSupplier.filtrarXNombreCompañia(i);
                foreach (var j in sup)
                {
                    dataGridView1.Rows.Add(j.SupplierID, j.CompanyName);
                }
            }

        }
    }
}
