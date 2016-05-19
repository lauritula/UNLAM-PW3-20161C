using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace UNLAM_PW3_20161C.cocineros
{
    public partial class Cocinero : System.Web.UI.MasterPage
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
                    case "comensal":
                        Response.Redirect("~/comensales/reservas.aspx");
                        break;
                    default:
                        break;
                }
            }

        }
    }
}