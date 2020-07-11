using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEClassroom.DataAccess;
using SEClassroom.AppLogic.Abstractions;
using SEClassroom.AppLogic.Data;

namespace SEClassroom.Models
{
    public class SQLTeacherRepository: ITeacherRepository
    {
        private readonly SEClassroomDBContext context;

        public SQLTeacherRepository(SEClassroomDBContext context)
        {
            this.context = context;
        }

        public Teacher GetTeacherByUserIds(Guid Id)
        {
            return context.Teachers.Find(Id);
        }

        public Teacher Add(Teacher teacher)
        {
            context.Teachers.Add(teacher);
            context.SaveChanges();
            return teacher;
        }

        public Teacher Delete(Guid Id)
        {
            Teacher teacher = context.Teachers.Find(Id);
            if (teacher != null)
            {
                context.Teachers.Remove(teacher);
                context.SaveChanges();
            }
            return teacher;
        }

        public IEnumerable<Teacher> GetTeacherByUserId()
        {
            return context.Teachers;
        }

        public Teacher Update(Teacher teacherChanges)
        {
            var teacher = context.Teachers.Attach(teacherChanges);
            teacher.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return teacherChanges;
        }
    }
}
