using school.DAL.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Entidades
{
    public class Instructor : Persona
    {
        public int Id { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
