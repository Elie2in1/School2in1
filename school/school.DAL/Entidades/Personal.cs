using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Entidades
{
    public class Personal : Empleado
    {
        public int? PersonID {  get; set; }
        public DateTime? enrollmentDate { get; set; }
        public string? Discriminator { get; set; }
    }
        
}
