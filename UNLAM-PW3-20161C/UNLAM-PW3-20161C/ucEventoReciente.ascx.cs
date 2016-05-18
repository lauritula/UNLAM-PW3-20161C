using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;


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


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbEventoReciente_Click(object sender, EventArgs e)
        {
            Evento eventoRecientes = new Evento();

            eventoRecientes.nombreEvento = lblNombre.Text;
            string Precio = lblPrecio.Text;
            eventoRecientes.precioEvento = Convert.ToDouble(Precio);
            string Puntuacion = lblPuntuacion.Text;
            eventoRecientes.puntuacionEvento = Convert.ToDecimal(Puntuacion);
            eventoRecientes.fotoEvento = imgEvento.ImageUrl;

            string urlDestino = string.Format("~/eventoReciente.aspx?n={0}&pr={1}&pu={2}&f={3}",
                eventoRecientes.nombreEvento, eventoRecientes.precioEvento, eventoRecientes.puntuacionEvento, eventoRecientes.fotoEvento);//qs-destino.aspx?u=Pepe&s=Masculino
            Server.Transfer(urlDestino);

     //       Response.Redirect("~/eventoReciente.aspx");


        }
    }
}