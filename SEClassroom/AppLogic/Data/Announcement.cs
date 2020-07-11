using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEClassroom.AppLogic.Data
{
    public class Announcement
    {   
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
