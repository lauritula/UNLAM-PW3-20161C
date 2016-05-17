using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNLAM_PW3_20161C
{
    public partial class Base : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                Usuario objUsuario = (Usuario)Session["objUsuario"];
                if (objUsuario == null)
                {
                    ucMenuComensal.Visible = false;
                    ucMenuCocinero.Visible = false;
                }
                else
                {
                    switch (objUsuario.TipoUsuario)
                    {
                        case "cocinero":
                            ucMenuComensal.Visible = false;
                            ucMenuAnonimo.Visible = false;
                            break;
                        case "comensal":
                            ucMenuCocinero.Visible = false;
                            ucMenuAnonimo.Visible = false;
                            break;
                        default:
                            ucMenuComensal.Visible = false;
                            ucMenuCocinero.Visible = false;
                            break;
                    }
                }
            

            

    //        
    //       tipoUsuario = Request.Cookies["objUsuario"]["tipoUsuario"];   
            

          

        }

    }
}