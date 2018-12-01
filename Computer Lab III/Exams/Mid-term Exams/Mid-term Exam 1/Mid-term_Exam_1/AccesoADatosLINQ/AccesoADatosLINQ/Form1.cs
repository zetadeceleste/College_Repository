using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoADatosLINQ
{
    public partial class Form1 : Form
    {
        private PubsStoresDataContext data;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            data = new PubsStoresDataContext();

            var query = from s in data.GetTable<stores>()
                        select s;

            dataGridView1.DataSource = query.ToList();
        }

        private void btnEjercicioA_Click(object sender, EventArgs e)
        {
            data = new PubsStoresDataContext();

            var query = from s in data.GetTable<stores>()
                        where s.stor_name.Contains("B") || s.state == "WA"
                        orderby s.city
                        select s;
            
            dataGridView1.DataSource = query.ToList();
        }

        private void btnEjercicioB_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Celes\source\repos\EjercicioB\EjercicioB\bin\Debug\EjercicioB.exe");
        }

        private void btnEjercicioC_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Celes\source\repos\EjercicioC\EjercicioC\bin\Debug\EjercicioC.exe");
        }

        private void btnEjercicioD_Click(object sender, EventArgs e)
        {
            data = new PubsStoresDataContext();

            stores store = new stores();

            store.stor_id = "8085";
            store.stor_name = "Atlantida";
            store.stor_address = "Rioja 1555";
            store.city = "Mendoza";
            store.state = "MZ";
            store.zip = "55000";

            data.stores.InsertOnSubmit(store);
            data.SubmitChanges();
        }

        private void btnEjercicioE_Click(object sender, EventArgs e)
        {
            data = new PubsStoresDataContext();

            var query = (from s in data.GetTable<stores>()
                        where s.stor_id == "8085"
                        select s).SingleOrDefault();

                    query.stor_name = "Yennis";
                    query.stor_address = "Salta 3566";

            data.SubmitChanges();
        }

        private void btnEjercicioF_Click(object sender, EventArgs e)
        {
            data = new PubsStoresDataContext();

            var store = (from s in data.stores
                         where s.stor_id == "8085"
                         select s).SingleOrDefault();

            data.stores.DeleteOnSubmit(store);

            data.SubmitChanges();
        }
    }
}
