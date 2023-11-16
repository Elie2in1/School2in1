using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Entidades
{
    public class OnsiteCurso : Curso
    {
        public string Localizacion { get; set; }
        public string Dias { get; set; }
        public DateTime Tienpo { get; set; }
    }
}
