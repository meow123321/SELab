using System;
using System.Collections.Generic;
using System.Text;

namespace SEClassroom.AppLogic.Abstractions
{
    public interface IRepository<T>
    {
        IEnumerable<T> Getall();
        T Add(T itemtoadd);
        T Update(T itemtoupdate);
        bool Delete(T itemtodelete);
    }
}
