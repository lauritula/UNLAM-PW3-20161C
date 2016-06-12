//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Eventos
    {
        public Eventos()
        {
            this.Comentarios = new HashSet<Comentarios>();
            this.Reservas = new HashSet<Reservas>();
            this.Recetas = new HashSet<Recetas>();
        }
    
        public int IdEvento { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int CantidadComensales { get; set; }
        public string Ubicacion { get; set; }
        public string NombreFoto { get; set; }
        public decimal Precio { get; set; }
        public byte Estado { get; set; }
    
        public virtual ICollection<Comentarios> Comentarios { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual ICollection<Reservas> Reservas { get; set; }
        public virtual ICollection<Recetas> Recetas { get; set; }
    }
}
