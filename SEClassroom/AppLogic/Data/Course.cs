using System;
using System.Collections.Generic;
using System.Text;

namespace SEClassroom.AppLogic.Data
{
    public class Course
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Grade> Grades { get; set; }

    }
}
