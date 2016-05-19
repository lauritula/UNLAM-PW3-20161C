using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Entidades
{
    public class Evento
    {
        public int idEvento { get; set; }
        public string creadorEvento { get; set; }
        public string nombreEvento { get; set; }
        public string fechaEvento { get; set; }
        public string descripcionEvento { get; set; }
        public double precioEvento { get; set; }
        public string recetasEvento { get; set; }
        public int comensalesEvento { get; set; }
        public string direccionEvento { get; set; }
        public double puntuacionEvento { get; set; }
        public string fotoEvento { get; set; }
   //     public List<Comentario> comentariosEvento { get; set; }
        public string statusEvento { get; set; }
    }
}