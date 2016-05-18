using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNLAM_PW3_20161C
{
    public partial class _default : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            ucEventoReciente.textoLabelNombre = "China Meal";
            ucEventoReciente.textoLabelPrecio = "200";
            ucEventoReciente.textoLabelPuntua = " 7,5 ";
            ucEventoReciente.imagenSource = "~/img/eventos/chinaMeal.jpg";
    //        ucEventoReciente.eventoSource = "registracion.aspx";
            ucEventoReciente1.textoLabelNombre = "Gourmet";
            ucEventoReciente1.textoLabelPrecio = "500";
            ucEventoReciente1.textoLabelPuntua = " 7,5 ";
    //        ucEventoReciente1.eventoSource = "registracion.aspx";
            ucEventoReciente1.imagenSource = "~/img/eventos/gourmet.jpg";
            ucEventoReciente2.textoLabelNombre = "Italia Mia";
            ucEventoReciente2.textoLabelPrecio = "100";
            ucEventoReciente2.textoLabelPuntua = " 7,5 ";
            ucEventoReciente2.imagenSource = "~/img/eventos/italiaMia.jpg";
    //        ucEventoReciente2.eventoSource = "registracion.aspx";
            ucEventoReciente3.textoLabelNombre = "Sushi";
            ucEventoReciente3.textoLabelPrecio = "70";
            ucEventoReciente3.textoLabelPuntua = " 9 ";
            ucEventoReciente3.imagenSource = "~/img/eventos/sushi.jpg";
   //         ucEventoReciente3.eventoSource = "registracion.aspx";
            ucEventoReciente4.textoLabelNombre = "Todo Asado";
            ucEventoReciente4.textoLabelPrecio = "800";
            ucEventoReciente4.textoLabelPuntua = " 6,5 ";
            ucEventoReciente4.imagenSource = "~/img/eventos/todo asado.jpg";
  //          ucEventoReciente4.eventoSource = "registracion.aspx";
            ucEventoReciente5.textoLabelNombre = "Todo Postre";
            ucEventoReciente5.textoLabelPrecio = "90";
            ucEventoReciente5.textoLabelPuntua = " 8,3 ";
            ucEventoReciente5.imagenSource = "~/img/eventos/todo postre.jpg";
    //        ucEventoReciente5.eventoSource = "registracion.aspx";
           

        }
    }
}