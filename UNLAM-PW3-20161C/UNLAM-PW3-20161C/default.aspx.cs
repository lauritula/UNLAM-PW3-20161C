using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio;
using Entidades;

namespace UNLAM_PW3_20161C
{
    public partial class _default : System.Web.UI.Page
    {
        public CocineroRepositorio cociRepo = new CocineroRepositorio();
        public ComentariosRepositorio comenRepo = new ComentariosRepositorio();
  
        protected void Page_Load(object sender, EventArgs e)
        {
                                      
                for (int i = 0; i < 6; i++)
                {
                    Control ctl = Page.LoadControl("~/ucEventoReciente.ascx");
                    PlaceHolder1.Controls.Add(ctl);
                                                            
                }
            

        }
    }
}