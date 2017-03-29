using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Week11.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstname { get; set; }
        public double Gpa { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}