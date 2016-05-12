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

        }

        public class SessionManager //no me acuerdo para que era... pero habia que ponerlo en el TP
        {
            private const String UsuarioKey = "usuario";

            public static Usuario UsuarioActual
            {
                get
                {
                    return (Usuario)HttpContext.Current.Session[UsuarioKey];
                }
                set
                {
                    HttpContext.Current.Session[UsuarioKey] = value;
                }
            }
        }
    }
}