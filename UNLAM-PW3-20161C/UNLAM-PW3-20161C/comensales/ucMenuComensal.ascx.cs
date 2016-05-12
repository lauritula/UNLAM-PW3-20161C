using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNLAM_PW3_20161C
{
    public partial class ucMenuComensal : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            lblUsuarioConectado.Text = (string) Session["Usuario"];
            Usuario objUsuario = (Usuario)Session["objUsuario"];

        }

        protected void lbLogOut_Click(object sender, EventArgs e)
        {
            var objUsuario = new Usuario();
            objUsuario.User = "anonimo";
            objUsuario.TipoUsuario = "anonimo";
            Session["objUsuario"] = objUsuario;
            Response.Redirect("~/default.aspx");

        }
    }
}