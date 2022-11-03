﻿using Entidades.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Director : Medico
    {

        
        public string PostGrado { get; set; }

        public Director(int id, string nombre, string apellido, string domicilio, string telefono, string email, string especialidad, string matricula, string postgrado) : base(id, nombre, apellido, domicilio, telefono, email, matricula, especialidad)
        {
            Especialidad = especialidad;
            PostGrado = postgrado;
        }
    }
}
