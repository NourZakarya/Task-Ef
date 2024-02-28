using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01_StudentSystem.Models
{
    [Table("students")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime RegisterdOn { get; set; }
        public DateTime? Birthday { get; set; }

        public List<HomeWork> HomeWorks { get; set; }
        public List<Course> Courses { get; set; }
    }
}
