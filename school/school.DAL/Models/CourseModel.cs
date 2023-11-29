using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Models
{
    public class CourseModel
    {
        public int CourseId { get; set; }
        public string? Name { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime CreationDate { get; set; }

        public string CreationDateDisplay
        {
            get { return this.CreationDate.ToString("dd/MM/yyyy"); }
        }
        public string EnrollmentDateDisplay
        {
            get { return this.EnrollmentDate.ToString("dd/MM/yyyy"); }
        }
    }
}
