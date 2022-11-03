using Entidades.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Medico : Persona
    {
        public string Matricula { get; set; }
        public string Especialidad { get; set; }
        public Medico(int id, string nombre, string apellido, string domicilio, string telefono, string email, string matricula, string especialidad) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Matricula = matricula; 
            Especialidad = especialidad;
        }
    }
}
