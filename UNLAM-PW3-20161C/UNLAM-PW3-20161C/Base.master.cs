using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Repositorio;

namespace UNLAM_PW3_20161C
{
    public partial class Base : System.Web.UI.MasterPage
    {
        public UsuarioRepositorio userRepo = new UsuarioRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {

                Usuarios objUsuario = (Usuarios)Session["objUsuario"];
                if (objUsuario == null)
                {
                    ucMenuComensal.Visible = false;
                    ucMenuCocinero.Visible = false;
                }
                else
                {
                    switch (objUsuario.IdTipoUsuario)
                    {
                        case 0:
                            ucMenuComensal.Visible = false;
                            ucMenuAnonimo.Visible = false;
                            break;
                        case 1:
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