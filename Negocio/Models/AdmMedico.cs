using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public class AdmMedico
    {
        List<Medico> medicos;

        public List<Medico> Listar()
        {
            //TODO...
            medicos = new List<Medico>();



            medicos.Add(new Medico(1, "Juan", "Suares", "Calle1 111", "22333332", "emailmedico1@gmail.com", "1111", "clinico"));
            medicos.Add(new Medico(1, "Pablo", "Español", "Calle2 222", "22333332", "emailmedico2@gmail.com", "2222", "clinico"));
            medicos.Add(new Medico(1, "Gaston", "Migone", "Calle3 333", "22333332", "emailmedico3@gmail.com", "3333", "traumatologo"));
            medicos.Add(new Medico(1, "Riki", "Mendoza", "Calle4 444", "22333332", "emailmedico4@gmail.com", "4444", "pediatra"));



            //TODO...
            return medicos;
            
        }

        public List<Medico> Listar(string especialidad)
        {
            List<Medico> tempMedicos = new List<Medico> { };
            foreach (Medico medico in medicos)
            {
                if (medico.Especialidad == especialidad)
                {
                    tempMedicos.Add(medico);
                }
            }
            return tempMedicos;
        }

        public int Insertar(Medico medico)
        {
            //TODO...
            return 0;
        }

        public int Eliminar(int indice)
        {
            //TODO...
            return 0;
        }

        public int TraerUno(Medico medico)
        {
            //TODO...
            return 0;
        }
    }

}
