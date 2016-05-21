using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;

namespace Repositorio
{
   
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
        public List<Evento> obtenerEventos()
        {
            return ListaEventos;
        }

        //metodo de retorno de eventos por usuario
        public List<Evento> eventoPorUsuario(string autor)
        {
            List<Evento> eventoPorUser = new List<Evento>();
            foreach (Evento ev in ListaEventos)
            {
                if (ev.creadorEvento == autor)
                    eventoPorUser.Add(ev);
            }
            return eventoPorUser;
        }

        //metodo de retorno de eventos por estado
        public List<Evento> eventoPorEstado(string estado, string autor)
        {
            List<Evento> eventoPorStatus = new List<Evento>();
            foreach (Evento ev in ListaEventos)
            {
                if (ev.statusEvento != estado & ev.creadorEvento == autor)
                    eventoPorStatus.Add(ev);
            }
            return eventoPorStatus;
        }

        //Eventos disponibles para reservar
        public List<Evento> eventoDisponibles(string estado)
        {
            List<Evento> eventoAReservar = new List<Evento>();
            foreach (Evento ev in ListaEventos )
            {
                if (ev.statusEvento != estado & ev.comensalesEvento > ev.reservadosEvento)
                    eventoAReservar.Add(ev);
            }
            return eventoAReservar;
        }

        //carga ficticia de eventos
        public void cargaFicticiaEventos()
        {
            Evento nuevoEvento = new Evento();
            nuevoEvento.idEvento = 1;
            nuevoEvento.nombreEvento = "China Meal";
            nuevoEvento.fechaEvento = "24/12/2015";
            nuevoEvento.descripcionEvento = "Desgustacion de platos Asiaticos";
            nuevoEvento.precioEvento = 200;
            nuevoEvento.recetasEvento = "ChowFan";
            nuevoEvento.comensalesEvento = 20;
            nuevoEvento.direccionEvento = "Av. Rivadavia 2031";
            nuevoEvento.puntuacionEvento = 7.5;
            nuevoEvento.statusEvento = "Finalizado";
            nuevoEvento.creadorEvento = "cocinero@bodegon.com";
            ListaEventos.Add(nuevoEvento);

            Evento nuevoEvento1 = new Evento();
            nuevoEvento1.idEvento = 1;
            nuevoEvento1.nombreEvento = "China Meal";
            nuevoEvento1.fechaEvento = "24/12/2015";
            nuevoEvento1.descripcionEvento = "Desgustacion de platos Asiaticos";
            nuevoEvento1.precioEvento = 200;
            nuevoEvento1.recetasEvento = "ChowFan";
            nuevoEvento1.comensalesEvento = 20;
            nuevoEvento1.direccionEvento = "Av. Rivadavia 2031";
            nuevoEvento1.puntuacionEvento = 7.5;
            nuevoEvento1.statusEvento = "Finalizado";
            nuevoEvento1.creadorEvento = "cocinero@bodegon.com";
            ListaEventos.Add(nuevoEvento1);

            Evento nuevoEvento2 = new Evento();
            nuevoEvento2.idEvento = 1;
            nuevoEvento2.nombreEvento = "China Meal";
            nuevoEvento2.fechaEvento = "24/12/2015";
            nuevoEvento2.descripcionEvento = "Desgustacion de platos Asiaticos";
            nuevoEvento2.precioEvento = 200;
            nuevoEvento2.recetasEvento = "ChowFan";
            nuevoEvento2.comensalesEvento = 20;
            nuevoEvento2.direccionEvento = "Av. Rivadavia 2031";
            nuevoEvento2.puntuacionEvento = 7.5;
            nuevoEvento2.statusEvento = "Finalizado";
            nuevoEvento2.creadorEvento = "cocinero@bodegon.com";
            ListaEventos.Add(nuevoEvento2);
        }

        //carga ficticia de eventos2
        public void cargaFicticiaEventos2()
        {
            Evento nuevoEvento = new Evento();
            nuevoEvento.idEvento = 1;
            nuevoEvento.nombreEvento = "China Meal";
            nuevoEvento.fechaEvento = "24/12/2015";
            nuevoEvento.direccionEvento = "Av. Rivadavia 2031";
            nuevoEvento.comensalesEvento = 20;
            nuevoEvento.reservadosEvento = 2;
            nuevoEvento.statusEvento = "Finalizado";
            nuevoEvento.creadorEvento = "cocinero@bodegon.com";
            ListaEventos.Add(nuevoEvento);

            Evento nuevoEvento1 = new Evento();
            nuevoEvento1.idEvento = 2;
            nuevoEvento1.nombreEvento = "Sushi Meal";
            nuevoEvento1.fechaEvento = "24/12/2015";
            nuevoEvento1.direccionEvento = "Av. Rivadavia 2031";
            nuevoEvento1.comensalesEvento = 20;
            nuevoEvento1.reservadosEvento = 2;
            nuevoEvento1.statusEvento = "En curso";
            nuevoEvento1.creadorEvento = "cocinero@bodegon.com";
            ListaEventos.Add(nuevoEvento1);

            Evento nuevoEvento2 = new Evento();
            nuevoEvento2.idEvento = 3;
            nuevoEvento2.nombreEvento = "Todo pasta";
            nuevoEvento2.fechaEvento = "24/12/2015";
            nuevoEvento2.direccionEvento = "Av. Rivadavia 2031";
            nuevoEvento2.comensalesEvento = 20;
            nuevoEvento2.reservadosEvento = 2;
            nuevoEvento2.statusEvento = "En curso";
            nuevoEvento2.creadorEvento = "cocinero@bodegon.com";
            ListaEventos.Add(nuevoEvento2);

        }


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