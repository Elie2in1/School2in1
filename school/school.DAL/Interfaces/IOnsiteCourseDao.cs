using school.DAL.Entidades;
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
        void SaveOnsiteCourse(OnsiteCourse onsiteCourse);
        void UpdateOnsiteCourse(OnsiteCourse onsiteCourse);
        List<OnsiteCourseModel> GetOnsiteCourses();
        OnsiteCourseModel GetOnsiteCourseById(int onsiteCourseId);
    }
}
