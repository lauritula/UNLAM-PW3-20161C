using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace UNLAM_PW3_20161C.comensales
{
    public partial class Comensal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario objUsuario = (Usuario)Session["objUsuario"];
            if (objUsuario == null)
            {
                Response.Redirect("~/default.aspx");
            }
            else
            {
                switch (objUsuario.TipoUsuario)
                {
                    case "cocinero":
                        Response.Redirect("~/cocineros/perfil.aspx");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}