using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01_StudentSystem.Models
{
    public enum Ctype
    {
        Application,
        Pdf,
        Zip
    }
    [Table("homeWorks")]
    public class HomeWork
    {
        [Key]
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public Ctype ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Student student { get; set; }
        public Course course { get; set; }

    }
}
