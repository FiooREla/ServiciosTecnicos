﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosTecnicos.Domain.Entity
{
    public class Carrera
    {
        public int IdCarrera { get; set; }
        public int IdCategoia { get; set; }
        public string NombreCarrera { get; set; }
        public string Activo { get; set; }
        public string DescripcionCarr { get; set;}
    }
}
