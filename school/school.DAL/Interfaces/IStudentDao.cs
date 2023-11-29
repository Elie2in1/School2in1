using school.DAL.Entidades;
using school.DAL.Models;

namespace school.DAL.Interfaces
{
    public interface IStudentDao
    {
        void SaveStudent(Student student);
        void UpdateStudent(Student student);
        void RemoveStudent(Student student);
        List<StudentModel> GetStudents();
        StudentModel GetStudentById(int studentId);
    }
}
