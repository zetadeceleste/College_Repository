using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_Click(object sender, EventArgs e)
    {
        txtNombreASP_result.Text = txtNombreASP.Text;
        txtComboASP_result.Text = comboASP.SelectedValue;
        imgASP_result.ImageUrl = imgASP.ImageUrl;
        txtCheckBoxASP_result.Text = checkBoxASP.SelectedValue;
        txtLinkASP_result.Text = linkASP.Text;
        txtRadioBtnASP_result.Text = radioBtnASP.SelectedValue;
        txtCampoOcultoASP_result.Text = campoOcultoASP.Value;
    }
}