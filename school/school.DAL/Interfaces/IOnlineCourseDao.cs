using school.DAL.Entidades;
using school.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Interfaces
{
    public interface IOnlineCourseDao
    {
        void SaveOnlineCourse(OnlineCourse onlineCourse);
        void UpdateOnlineCourse(OnlineCourse onlineCourse);
        List<OnlineCourseModel> GetOnlineCourses();
        OnlineCourseModel GetOnlineCourseById(int onlineCourseId);
    }
}
