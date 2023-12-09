using school.DAL.Context;
using school.DAL.Entidades;
using school.DAL.Exceptions;
using school.DAL.Interfaces;
using school.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DAL.Daos
{
    public class StudentGradeDao : IStudentGradeDao
    {
        private readonly SchoolDbContext schoolDb;

        public StudentGradeDao(SchoolDbContext schoolDb)
        {
            this.schoolDb = schoolDb;
        }
        public StudentGradeModel GetStudentGradeById(int studentGradeId)
        {
            StudentGradeModel model = new StudentGradeModel();
            try
            {
                StudentGrade? studentGrade = schoolDb.StudentGrades.Find(studentGradeId);

                if (studentGrade is null)
                    throw new StudentGradeDaoException("El Grado del estudiante no se encuentra registrado.");


                model.StudentId = studentGrade.StudentId;
                model.EnrollmentId = studentGrade.EnrollmentId;
                model.CourseId = studentGrade.CourseId;
                model.Grade = studentGrade.Grade;


            }
            catch (Exception ex)
            {
                throw new StudentGradeDaoException(ex.Message);
            }
            return model;
        }

        public List<StudentGradeModel> GetStudentGrades()
        {
            List<StudentGradeModel> studentGrades = new List<StudentGradeModel>();
            try
            {
                ///LINQ QUERY
                var query = from stg in this.schoolDb.StudentGrades
                            select new StudentGradeModel()
                            {
                                EnrollmentId = stg.EnrollmentId,
                                CourseId = stg.CourseId,
                                StudentId = stg.StudentId,
                                Grade = stg.Grade,
                            };

                studentGrades = query.ToList();

            }
            catch (Exception ex)
            {
                throw new StudentGradeDaoException(ex.Message);
            }
            return studentGrades;
        }
        /*
        public void RemoveStudentGrade(StudentGrade studentGrade)
        {
            try
            {
                StudentGrade? studentGradeToRemove = this.schoolDb.StudentGrades.Find(studentGrade.StudentId);

                if (studentGradeToRemove is null)
                    throw new StudentDaoException("El estudiante no se encuentra registrado.");


                studentGradeToRemove.Deleted = studentGrade.Deleted;
                studentGradeToRemove.DeletedDate = studentGrade.DeletedDate;
                studentGradeToRemove.UserDeleted = studentGrade.UserDeleted;

                this.schoolDb.Students.Update(studentGradeToRemove);
                this.schoolDb.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new StudentGradeDaoException(ex.Message);
            }
        }
        */
        public void SaveStudentGrade(StudentGrade studentGrade)
        {
            try
            {
                if (studentGrade is null)
                    throw new StudentGradeDaoException("la clase debe de ser instaciada.");


                this.schoolDb.StudentGrades.Add(studentGrade);
                this.schoolDb.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new StudentGradeDaoException(ex.Message);
            }
        }
        /* public void SaveStudentGrade(StudentGrade studentGrades)
         {
             try
             {
                 if (studentGrade is null)
                     throw new StudentGradeDaoException("la clase debe de ser instaciada.");


                 this.schoolDb.StudentGrades.Add(studentGrades);
                 this.schoolDb.SaveChanges();
             }
             catch (Exception ex)
             {
                 throw new StudentGradeDaoException(ex.Message);
             }
         }
         */
        public void UpdateStudentGrade(StudentGrade studentGrade)
        {
            try
            {
                StudentGrade? studentGradeToUpdate = this.schoolDb.StudentGrades.Find(studentGrade.StudentId);

                if (studentGradeToUpdate is null)
                    throw new StudentGradeDaoException("El estudiante no se encuentra registrado.");


                studentGradeToUpdate.CourseId = studentGrade.CourseId;
                studentGradeToUpdate.EnrollmentId = studentGrade.EnrollmentId;
                studentGradeToUpdate.StudentId = studentGrade.StudentId;
                studentGradeToUpdate.Grade = studentGrade.Grade;
                

                this.schoolDb.StudentGrades.Update(studentGradeToUpdate);
                this.schoolDb.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new StudentGradeDaoException(ex.Message);
            }
        }
    }
}
