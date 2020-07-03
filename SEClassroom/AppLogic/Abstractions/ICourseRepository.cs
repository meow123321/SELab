using System;
using System.Collections.Generic;
using System.Text;
using SEClassroom.AppLogic.Data;

namespace SEClassroom.AppLogic.Abstractions
{
    public interface ICourseRepository: IRepository<Course>
    {
        Grade GetStudentByGrade(Student student);
    }
}
