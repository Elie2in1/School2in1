using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Entidades
{
    public class Oficinista : Personal
    {
        public int? InstructorID { get; set; }
        public string? Location { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
