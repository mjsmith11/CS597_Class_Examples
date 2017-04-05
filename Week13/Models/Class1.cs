using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Week13.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double gpa { get; set; }
    }
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}