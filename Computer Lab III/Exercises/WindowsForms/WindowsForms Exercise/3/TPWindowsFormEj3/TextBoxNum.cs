using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
namespace TPWindowsFormEj3
{
    public class TextBoxNum : TextBox
    {
        private char[] digitos = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', ',', '-', '\b' };
        private bool conDecimales = true; 
        
        [Description("Indica si se admitira decimales o no")]
        public bool ConDecimales{ get { return conDecimales; } set { conDecimales = value; } }

        protected virtual bool CaracterCorrecto(char c)
        {
            if(ConDecimales == false)
            {
                if (c == '.' || c == ',')
                {
                    return false;
                }
            }
            return (Array.IndexOf(digitos, c) != -1);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!CaracterCorrecto(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                string s = "";
                foreach (char c in value)
                {
                    if (CaracterCorrecto(c))
                    {
                        s += c;
                    }
                    base.Text = s;
                }
            }
        }
    }
}
