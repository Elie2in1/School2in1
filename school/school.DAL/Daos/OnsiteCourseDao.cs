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
    public class OnsiteCourseDao : IOnsiteCourseDao
    {
        private readonly SchoolDbContext schoolDb;

        public OnsiteCourseDao(SchoolDbContext schoolDb)
        {
            this.schoolDb = schoolDb;
        }
        public OnsiteCourseModel GetOnsiteCourseById(int onsiteCourseId)
        {
            OnsiteCourseModel model = new OnsiteCourseModel();
            try
            {
                OnsiteCourse? onsiteCourse = schoolDb.OnsiteCourses.Find(onsiteCourseId);

                if (onsiteCourse is null)
                    throw new OnsiteCourseDaoException("El curso no se encuentra registrado.");

                model.CourseId = onsiteCourse.CourseId;
                model.Location = string.Concat(onsiteCourse.Location, " ");
                model.Days = string.Concat(onsiteCourse.Days, " ");
                model.Time = onsiteCourse.Time;


            }
            catch (Exception ex)
            {
                throw new OnsiteCourseDaoException(ex.Message);
            }
            return model;
        }

        public List<OnsiteCourseModel> GetOnsiteCourses()
        {
            List<OnsiteCourseModel> onsiteCourses = new List<OnsiteCourseModel>();
            try
            {
                ///LINQ QUERY
                var query = from osc in this.schoolDb.OnsiteCourses
                            select new OnsiteCourseModel()
                            {

                                CourseId = osc.CourseId,
                                Location = string.Concat(osc.Location, " "),
                                Days = string.Concat(osc.Days, " "),
                                Time = osc.Time,
                            };

                onsiteCourses = query.ToList();

            }
            catch (Exception ex)
            {
                throw new OnsiteCourseDaoException(ex.Message);
            }
            return onsiteCourses;
        }
        /*
        public void RemoveOfficeAssignment(OfficeAssignment officeAssignment)
        {
            try
            {
                OfficeAssignment? officeAssignmentToRemove = this.schoolDb.OfficeAssignments.Find(officeAssignment.InstructorId);

                if (officeAssignmentToRemove is null)
                    throw new StudentDaoException("El officeAssignment no se encuentra registrado.");


                officeAssignmentToRemove.Deleted = officeAssignment.Deleted;
                officeAssignmentToRemove.DeletedDate = officeAssignment.DeletedDate;
                officeAssignmentToRemove.UserDeleted = officeAssignment.UserDeleted;

                this.schoolDb.OfficeAssignments.Update(officeAssignmentToRemove);
                this.schoolDb.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new OfficeAssignmentDaoException(ex.Message);
            }
        }
        */
        public void SaveOnsiteCourse(OnsiteCourse onsiteCourse)
        {
            try
            {
                if (onsiteCourse is null)
                    throw new OnsiteCourseDaoException("la clase debe de ser instaciada.");


                this.schoolDb.OnsiteCourses.Add(onsiteCourse);
                this.schoolDb.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new OnsiteCourseDaoException(ex.Message);
            }
        }
        /*
        public void UpdateOfficeAssignment(OfficeAssignment officeAssignment)
        {
            try
            {
                OfficeAssignment? officeAssignmentToUpdate = this.schoolDb.OfficeAssignments.Find(officeAssignment.InstructorId);

                if (officeAssignmentToUpdate is null)
                    throw new OfficeAssignmentDaoException("El OfficeAssignment no se encuentra registrado.");


                officeAssignmentToUpdate.ModifyDate = officeAssignment.ModifyDate;
                officeAssignmentToUpdate.UserMod = officeAssignment.UserMod;
                officeAssignmentToUpdate.InstructorId = officeAssignment.InstructorId;
                officeAssignmentToUpdate.Location = officeAssignment.Location;
              
                officeAssignmentToUpdate.Timestamp = officeAssignment.Timestamp;


                this.schoolDb.OfficeAssignments.Update(officeAssignmentToUpdate);
                this.schoolDb.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new OfficeAssignmentDaoException(ex.Message);
            }
        }
        */
    }
}