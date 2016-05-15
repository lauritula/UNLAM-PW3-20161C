using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNLAM_PW3_20161C
{
    public partial class ucEventoReciente : System.Web.UI.UserControl
    {
        public string textoLabelNombre
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }
        public string textoLabelPrecio
        {
            get { return lblPrecio.Text; }
            set { lblPrecio.Text = value; }
        }
        public string textoLabelPuntua
        {
            get { return lblPuntuacion.Text; }
            set { lblPuntuacion.Text = value; }
        }
        public string imagenSource
        {
            get { return imgEvento.ImageUrl; }
            set { imgEvento.ImageUrl = value; }
        }

        public string eventoSource
        {
            get { return hlEventoReciente.NavigateUrl; }
            set { hlEventoReciente.NavigateUrl = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}