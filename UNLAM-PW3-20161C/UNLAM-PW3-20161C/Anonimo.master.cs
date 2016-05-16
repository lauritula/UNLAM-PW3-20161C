using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNLAM_PW3_20161C
{
    public partial class Anonimo : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario objUsuario = (Usuario)Session["objUsuario"];
            if (objUsuario == null)
            {
            }
            else
            {
                switch (objUsuario.TipoUsuario)
                {
                    case "comensal":
                        Response.Redirect("~/comensarles/reservas.aspx");
                        break;
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