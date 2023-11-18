using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Entidades
{
    public class GradoEstudiante : Curso
    {
        public DateTime? enrollmentID { get; set; }
        public int? CourseID { get; set; }

        public int? EstudianteID { get; set; }

        public string? Grado { get; set;}
    }
}
