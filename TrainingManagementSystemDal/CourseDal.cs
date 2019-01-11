using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystemDal
{
   public  class CourseDal
    {
        SwatiTmsEntities db = new SwatiTmsEntities();
        public List<Course> GetCourse()
        {
            return db.usp_Course_getCourse().ToList();

        }
        public int InsertCourse(Course course) {

          return db.usp_Course_InsertCourse( course.CourseCode, course.CourseName, course.CreatedBy,course.CourseDuration);
           

        }
        public int UpdateCourse(Course course) {
            db.usp_Course_UpdateCourseRecord(course.CourseId, course.CourseName, course.CourseStatus, course.CourseDuration, course.ModifiedBy, course.ModifiedOn);
            return 1;
        }
        public int DeleteCourse(int CourseId) {
            db.usp_Course_Delete(CourseId);
            return 1;
        } 

    }
}
