
using Entidades.Models.Base;
using Entidades.Ayudantes;
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
        private DateTime FechaDeNacimiento { get; set; }

        private int Edad;

        
        public Paciente(int id, string nombre, string apellido, string domicilio, string telefono, string email, string nrohistcli, DateTime fechadenacimiento) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nrohistcli;
            FechaDeNacimiento = fechadenacimiento;
            
        }

        
        public int GetEdad
        {
            get { return UtilidadesFechas.CalcularEdad(this.FechaDeNacimiento); }
        }


    }
}
