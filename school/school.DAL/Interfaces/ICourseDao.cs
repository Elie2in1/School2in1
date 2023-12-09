using school.DAL.Entidades;
using school.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Interfaces
{
    public interface ICourseDao
    {
        void SaveCourse(Course course);
        void UpdateCourse(Course course);
        void RemoveCourse(Course course);
        List<CourseModel> GetCourses();
        CourseModel GetCourseById(int courseId);
        object GetDepartments();
    }
}
