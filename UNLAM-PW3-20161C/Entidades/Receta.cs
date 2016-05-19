using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Receta
    {
        public string nombreReceta { get; set; }
        public int tiempoReceta { get; set; }
        public string descripcionPasosReceta { get; set; }
        public string ingredientesReceta { get; set; }
        public string tipoReceta { get; set; }
        public string autorReceta { get; set; }
    }
}
