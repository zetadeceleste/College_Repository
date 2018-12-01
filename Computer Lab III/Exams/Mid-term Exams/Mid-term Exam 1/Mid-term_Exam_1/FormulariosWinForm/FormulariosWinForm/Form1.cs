using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtClave.Text == txtConfirmarClave.Text)
            {
                lblAlerta.Text = "Clave creada con éxito.";
            }
            else
            {
                lblAlerta.Text = "Las claves ingresadas\nno coinciden.";
                txtClave.Text = "";
                txtConfirmarClave.Text = "";
            }
            
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            txtClave.PasswordChar = '*';
        }

        private void txtConfirmarClave_TextChanged(object sender, EventArgs e)
        {
            txtConfirmarClave.PasswordChar = '*';
        }
    }
}
