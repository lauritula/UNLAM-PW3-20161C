using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNLAM_PW3_20161C
{
    public class Evento
    {
        public string nombreEvento { get; set; }
        public string fechaEvento { get; set; }
        public string descripcionEvento { get; set; }
        public double precioEvento { get; set; }
        public string recetasEvento { get; set; }
        public int comensalesEvento { get; set; }
        public string direccionEvento { get; set; }
        public decimal puntuacionEvento { get; set; }
        public string fotoEvento { get; set; }
        //public List<Comentario> comentariosEvento { get; set; }
        public string statusEvento { get; set; }
    }
}