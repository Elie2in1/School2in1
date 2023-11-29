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
    public class CourseDao : ICourseDao
    {
        private readonly SchoolDbContext schoolDb;

        public CourseDao(SchoolDbContext schoolDb)
        {
            this.schoolDb = schoolDb;
        }
        public CourseModel GetCourseById(int courseId)
        {
            CourseModel model = new CourseModel();
            try
            {
                Course? course = schoolDb.Courses.Find(courseId);

                if (course is null)
                    throw new CourseDaoException("El curso no se encuentra registrado.");


                model.CreationDate = course.CreationDate;
                model.CreationDate = course.CreationDate;
                model.CourseId = course.CourseId;
                model.Name = string.Concat(course.Title, " ");


            }
            catch (Exception ex)
            {
                throw new CourseDaoException(ex.Message);
            }
            return model;
        }

        public List<CourseModel> GetCourses()
        {
            List<CourseModel> courses = new List<CourseModel>();
            try
            {
                ///LINQ QUERY
                var query = from cou in this.schoolDb.Courses
                            where cou.Deleted == false
                            select new CourseModel()
                            {
                                CreationDate = cou.CreationDate,
                                EnrollmentDate = cou.CreationDate,
                                CourseId = cou.CourseId,
                                Name = string.Concat(cou.Title, " ")
                            };

                courses = query.ToList();

            }
            catch (Exception ex)
            {
                throw new CourseDaoException(ex.Message);
            }
            return courses;
        }

        public void RemoveCourse(Course course)
        {
            try
            {
                Course? courseToRemove = this.schoolDb.Courses.Find(course.CourseId);

                if (courseToRemove is null)
                    throw new CourseDaoException("El Curso no se encuentra registrado.");


                courseToRemove.Deleted = course.Deleted;
                courseToRemove.DeletedDate = course.DeletedDate;
                courseToRemove.UserDeleted = course.UserDeleted;

                this.schoolDb.Courses.Update(courseToRemove);
                this.schoolDb.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new CourseDaoException(ex.Message);
            }
        }

        public void SaveCourse(Course course)
        {
            try
            {
                if (course is null)
                    throw new CourseDaoException("la clase debe de ser instaciada.");


                this.schoolDb.Courses.Add(course);
                this.schoolDb.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new CourseDaoException(ex.Message);
            }
        }

        public void UpdateCourse(Course course)
        {
            try
            {
                Course? courseToUpdate = this.schoolDb.Courses.Find(course.CourseId);

                if (courseToUpdate is null)
                    throw new CourseDaoException("El curso no se encuentra registrado.");


                courseToUpdate.ModifyDate = course.ModifyDate;
                courseToUpdate.UserMod = course.UserMod;
                courseToUpdate.CourseId = course.CourseId;
                courseToUpdate.Title = course.Title;
                courseToUpdate.Title = course.Title;
                courseToUpdate.CreationDate = course.CreationDate;


                this.schoolDb.Courses.Update(courseToUpdate);
                this.schoolDb.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new CourseDaoException(ex.Message);
            }
        }
    }
}
