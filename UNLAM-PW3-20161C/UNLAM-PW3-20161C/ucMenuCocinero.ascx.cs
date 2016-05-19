using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace UNLAM_PW3_20161C
{
    public partial class ucMenuCocinero : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsuarioConectado.Text = (string)Session["Usuario"];
            Usuario objUsuario = (Usuario)Session["objUsuario"]; 
        }

        protected void lbLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/default.aspx");
           
        }
    }
}