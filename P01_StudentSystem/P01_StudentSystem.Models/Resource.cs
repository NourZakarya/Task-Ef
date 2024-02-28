using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01_StudentSystem.Models
{
    public enum Rtype
    {
        Video,
        Presentaion,
        Document,
        Other
    }
    [Table("resources")]
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Rtype ResourceType { get; set; }
        public int CourseId { get; set; }

        public Course course { get; set; }
    }
}
