using school.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Interfaces
{
    public interface IOnsiteCourseDao
    {
        List<OnsiteCourseModel> GetOnsiteCourses();
        OnsiteCourseModel GetOnsiteCourseById(int onsiteCourseId);
    }
}
