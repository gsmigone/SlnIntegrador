using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public static class AdmHabitacion
    {
        static List<Habitacion> habitaciones;
        public static List<Habitacion> Listar()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            habitaciones.Add(new Habitacion(0,10,"ocupada") );
            habitaciones.Add(new Habitacion(1, 11, "ocupada"));
            habitaciones.Add(new Habitacion(2, 12, "libre") );
            habitaciones.Add(new Habitacion(3, 13, "ocupada"));
            return habitaciones;
        }

        public static List<Habitacion> Listar(string estado)
        {
            //TODO...
            return null;
        }

        public static int Insertar(Habitacion habitacion)
        {
            //TODO...
            return 0;
        }

        public static int Eliminar(int indice)
        {
            //TODO...
            return 0;
        }

        public static int TraerUno(Habitacion habitacion)
        {
            //TODO...
            return 0;
        }
    }
}
