using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TextBoxCuit : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        validateCuit(txtBCuit.Text);
    }
    private bool validateCuit(string Cuit)
    {
        //20 - 123456 - 123 Con ese valor funciona
        Regex rg = new Regex("[A-Z_a-z]");
        Cuit = Cuit.Replace("-", "");
        if (rg.IsMatch(Cuit))
        {
            txtBCuit.BorderColor = Color.Red;
            return false;
        }

        if (Cuit.Length != 11)
        {
            txtBCuit.BorderColor = Color.Red;
            return false;
        }

        char[] cuitArray = Cuit.ToCharArray();
        double sum = 0;
        int bint = 0;
        int j = 7;
        for (int i = 5, c = 0; c != 10; i--, c++)
        {
            if (i >= 2)
                sum += (Char.GetNumericValue(cuitArray[c]) * i);
            else
                bint = 1;
            if (bint == 1 && j >= 2)
            {
                sum += (Char.GetNumericValue(cuitArray[c]) * j);
                j--;
            }
        }
        if ((cuitArray.Length - (sum % 11)) == Char.GetNumericValue(cuitArray[cuitArray.Length - 1]))
        {
            txtBCuit.BorderColor = Color.Green;
            return true;
        }
        txtBCuit.BorderColor = Color.Red;
        return false;

    }
}