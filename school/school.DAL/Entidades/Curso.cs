using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Entidades
{
    public class Curso : Departamento
    {
        public int Cursoid { get; set; }
        public string? Titulo { get; set; }
        public int Creditos { get; set; }
    }
}
