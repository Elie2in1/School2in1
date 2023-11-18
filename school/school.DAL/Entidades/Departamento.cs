using school.DAL.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Entidades
{
    public class Departamento : BaseEntidad
    {
        public int DepartmentID { get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator { get; set; }
    }
}
