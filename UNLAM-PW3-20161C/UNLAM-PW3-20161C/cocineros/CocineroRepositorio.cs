using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;

namespace UNLAM_PW3_20161C
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

    public class Cocinero 
    { 

    }
    
    public class CocineroRepositorio
    {
        //////////EVENTOS
        
        //creacion de la lista de eventos
        public static List<Evento> ListaEventos = new List<Evento>();

        //método para añadir nuevo evento a la lista
        public void CrearEvento(Evento nuevoEvento) 
        {
            nuevoEvento.statusEvento = "Programado";
            ListaEventos.Add(nuevoEvento);
        }

        //método para obtener un evento por su nombre
        public Evento ObtenerPorNombre(string nombreEvento)
        {
            foreach (Evento ev in ListaEventos)
            {
                if (ev.nombreEvento == nombreEvento)
                    return ev;
            }

            throw new Exception("Evento no encontrado");
        }
        
        //método para cancelar un evento
        public void cancelarEvento(string nombreEventoACancelar)
        {
            Evento eventoACancelar = new Evento();
            eventoACancelar = ObtenerPorNombre(nombreEventoACancelar);
            eventoACancelar.statusEvento = "Cancelado";
        }

        //método para finalizar un evento
        public void finalizarEvento()
        {
            //foreach (Eventos ev in ListaEventos)
            //{
                //if (ev.fechaEvento == fechaActual)
                    //ev.statusEvento = "Finalizado";
            //}
            
        }

        //metodo de retorno de todos los eventos
        public List<Evento> obtenerEventos(){return ListaEventos;}

        //////////RECETAS

        //creacion de la lista de recetas
        public static List<Receta> ListaRecetas = new List<Receta>();

        //método para añadir nueva receta a la lista
        public void CrearReceta(Receta nuevaReceta)
        {
            ListaRecetas.Add(nuevaReceta);
        }

        //metodo de retorno de recetas por usuario
        public List<Receta> recetasPorUsuario(string autor) 
        { 
            List<Receta> recetasPorUser = new List<Receta>();
            foreach (Receta re in ListaRecetas)
            {
                if (re.autorReceta == autor)
                    recetasPorUser.Add(re);
            }
            return recetasPorUser; 
        }

        //carga ficticia de recetas
        public void cargaFicticiaRecetas (){
            Receta nuevaReceta = new Receta();
            nuevaReceta.nombreReceta = "Nombre 1";
            nuevaReceta.tiempoReceta = 10;
            nuevaReceta.tipoReceta = "Tipo 1";
            nuevaReceta.ingredientesReceta = "Ingredientes 1";
            nuevaReceta.descripcionPasosReceta = "Descripcion 1";
            nuevaReceta.autorReceta = "cocinero@bodegon.com";
            ListaRecetas.Add(nuevaReceta);
            Receta nuevaReceta2 = new Receta();
            nuevaReceta2.nombreReceta = "Nombre 2";
            nuevaReceta2.tiempoReceta = 10;
            nuevaReceta2.tipoReceta = "Tipo 2";
            nuevaReceta2.ingredientesReceta = "Ingredientes 2";
            nuevaReceta2.descripcionPasosReceta = "Descripcion 1";
            nuevaReceta2.autorReceta = "cocinero@bodegon.com";
            ListaRecetas.Add(nuevaReceta2);
            Receta nuevaReceta3 = new Receta();
            nuevaReceta3.nombreReceta = "Nombre 3";
            nuevaReceta3.tiempoReceta = 10;
            nuevaReceta3.tipoReceta = "Tipo 2";
            nuevaReceta3.ingredientesReceta = "Ingredientes 3";
            nuevaReceta3.descripcionPasosReceta = "Descripcion 3";
            nuevaReceta3.autorReceta = "cocinero@bodegon.com";
            ListaRecetas.Add(nuevaReceta3);
        }

    }
}