using System;
using System.Collections.Generic;
using System.Text;
using SEClassroom.AppLogic.Data;

namespace SEClassroom.AppLogic.Abstractions
{
    public interface ICourseRepository: IRepository<Course>
    {
        Course GetCourse(Guid Id);
        IEnumerable<Course> GetCourse();
        Course Add(Course course);
        Course Update(Course courseChanges);
        Course Delete(Guid Id);

    }
}
