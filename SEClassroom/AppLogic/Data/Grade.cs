using System;
using System.Collections.Generic;
using System.Text;

namespace SEClassroom.AppLogic.Data
{
    public class Grade
    {
        public int ID { get; set; }
        public Student Student { get; set; }
        public float GradeValue { get; set; }
        public DateTime Date { get; set; }
    }
}
