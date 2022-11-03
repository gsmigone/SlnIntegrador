using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public static class AdmPaciente
    {
        static List<Paciente> pacientes;
        public static List<Paciente> Listar()
        {
            List<Paciente> pacientes = new List<Paciente>();



            pacientes.Add(new Paciente(1, "Mariano", "Gob", "Calle1 555", "22333332", "emailpaciente1@gmail.com", "1111", new DateTime(2001,10,1)));
            pacientes.Add(new Paciente(1, "Enzo", "Mastro", "Calle2 666", "22333332", "emailpaciente2@gmail.com", "2222", new DateTime(2002, 10, 1)));
            pacientes.Add(new Paciente(1, "Marcelo", "Della", "Calle3 777", "22333332", "emailpaciente3@gmail.com", "3333", new DateTime(2003, 10, 1)));
            pacientes.Add(new Paciente(1, "Fernando", "Casta", "Calle4 888", "22333332", "emailpaciente4@gmail.com", "4444", new DateTime(2004, 10, 1)));



            //TODO...
            return pacientes;
        }

        public static int Insertar(Paciente paciente)
        {
            pacientes.Add(paciente);
            //TODO...
            return 0;
        }

        public static int Eliminar(int indice)
        {
            //TODO...
            return 0;
        }

        public static int TraerUno(Paciente paciente)
        {
            //TODO...
            return 0;
        }
    }
}
