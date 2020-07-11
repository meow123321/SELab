using System;
using System.Collections.Generic;
using System.Text;
using SEClassroom.AppLogic.Data;

namespace SEClassroom.AppLogic.Abstractions
{
    public interface ITeacherRepository: IRepository<Teacher>
    {
        Teacher GetTeacherByUserId(Guid userId);
        Teacher Add(Teacher teacher);
        Teacher Update(Teacher teacherChanges);
        Teacher Delete(Guid Id);
    }
}
