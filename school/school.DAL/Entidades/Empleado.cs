﻿using school.DAL.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Entidades
{
    public class Empleado : Persona
    {
        public DateTime? HireDate { get; set; }
    }
}