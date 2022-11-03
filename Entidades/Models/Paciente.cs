
using Entidades.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Paciente:Persona
    {

        public string NroHistoriaClinica { get; set; }
        public Paciente(int id, string nombre, string apellido, string domicilio, string telefono, string email, string nrohistcli) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nrohistcli;
        }

        
    }
}
