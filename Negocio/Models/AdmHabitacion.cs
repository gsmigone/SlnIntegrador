using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class AdmHabitacion
    {
        public List<Habitacion> Listar()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            habitaciones.Add(new Habitacion(0,10,"ocupada") );
            habitaciones.Add(new Habitacion(1, 11, "ocupada"));
            habitaciones.Add(new Habitacion(2, 12, "libre") );
            habitaciones.Add(new Habitacion(3, 13, "ocupada"));
            return habitaciones;
        }

        public List<Habitacion> Listar(string estado)
        {
            //TODO...
            return null;
        }

        public int Insertar(Habitacion habitacion)
        {
            //TODO...
            return 0;
        }

        public int Eliminar(int indice)
        {
            //TODO...
            return 0;
        }

        public int TraerUno(Habitacion habitacion)
        {
            //TODO...
            return 0;
        }
    }
}
