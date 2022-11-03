using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ayudantes
{
    public static class UtilidadesFechas
    {
        public static int CalcularEdad(DateTime fecha)
        {
            int edad = DateTime.Today.AddTicks(-fecha.Ticks).Year - 1;
            return edad;
        }
    }
}
