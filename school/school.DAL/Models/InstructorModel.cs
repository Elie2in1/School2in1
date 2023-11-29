using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Models
{
    public class InstructorModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime CreationDate { get; set; }

        public string CreationDateDisplay
        {
            get { return this.CreationDate.ToString("dd/MM/yyyy"); }
        }
        public string HireDateDisplay
        {
            get { return this.HireDate.ToString("dd/MM/yyyy"); }
        }
    }
}
