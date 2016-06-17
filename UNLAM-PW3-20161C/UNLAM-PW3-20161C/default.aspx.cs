using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorio;

namespace UNLAM_PW3_20161C
{
    public partial class _default : System.Web.UI.Page
    {
        public CocineroRepositorio cociRepo = new CocineroRepositorio();
  
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i == 6; i++)
            {
                var objEvento = cociRepo.ObtenerRecientes(i);
                ucEventoReciente0.ID = "ucEventoReciente" + i;
                ucEventoReciente0.textoLabelNombre = objEvento.Nombre;
                ucEventoReciente0.textoLabelPrecio = Convert.ToString(objEvento.Precio);
                ucEventoReciente0.textoLabelPuntua = " 4,5 ";
                ucEventoReciente0.imagenSource = objEvento.NombreFoto;
            }

        }
    }
}