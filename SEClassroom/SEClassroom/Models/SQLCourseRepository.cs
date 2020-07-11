using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEClassroom.DataAccess;
using SEClassroom.AppLogic.Abstractions;
using SEClassroom.AppLogic.Data;

namespace SEClassroom.Models
{
    public class SQLCourseRepository : ICourseRepository
    {
        private readonly SEClassroomDBContext context;

        public SQLCourseRepository(SEClassroomDBContext context)
        {
            this.context = context;
        }

        public Course Add(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return course;
        }

        public Course Delete(Guid Id)
        {
            Course course = context.Courses.Find(Id);
            if (course != null)
            {
                context.Courses.Remove(course);
                context.SaveChanges();
            }
            return course;
        }

        public Course GetCourse(Guid Id)
        {
            return context.Courses.Find(Id);
        }

        public IEnumerable<Course> GetCourses()
        {
            return context.Courses;
        }

        public Course Update(Course CourseChanges)
        {
            var Course = context.Courses.Attach(CourseChanges);
            Course.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return CourseChanges;
        }
    }
}
