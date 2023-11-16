using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Entidades.Base
{
    public abstract class Persona : BaseEntidad
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
