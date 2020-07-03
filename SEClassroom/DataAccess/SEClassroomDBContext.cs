using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SEClassroom.AppLogic.Data;

namespace SEClassroom.DataAccess
{
    public class SEClassroomDBContext: DbContext
    {
        public SEClassroomDBContext(DbContextOptions<SEClassroomDBContext> options) : base(options){

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
