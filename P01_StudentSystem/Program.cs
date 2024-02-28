using P01_StudentSystem.P01_StudentSystem.Data;
using P01_StudentSystem.P01_StudentSystem.Models;

namespace P01_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeedData();
      
        }
        public static void SeedData()
        {
            StudentSystemContext studentSystemContext = new StudentSystemContext();

            // seed students
            var Students = new List<Student>
            {
                new Student{Name="Nour",RegisterdOn=DateTime.Now},
                new Student{Name="Ali",RegisterdOn=DateTime.Now},
                new Student{Name="Saif",RegisterdOn=DateTime.Now}
            };
            studentSystemContext.students.AddRange(Students);
            studentSystemContext.SaveChanges(true);


            //seed courses
            var Courses = new List<Course>
            {
                new Course(){Name="Math",StartDate=DateTime.Now,EndDate=DateTime.Now,Price=4000},
                new Course(){Name="Science",StartDate=DateTime.Now,EndDate=DateTime.Now,Price=3000},
                new Course(){Name="English",StartDate=DateTime.Now,EndDate=DateTime.Now,Price=5000}
            };
            studentSystemContext.courses.AddRange(Courses);
            studentSystemContext.SaveChanges(true);


            //seed resources
            var Resources = new List<Resource>
            {
                new Resource(){ Name="CourseCatalog",Url="www.gmail.com",CourseId=2,ResourceType=Rtype.Video},
                new Resource(){ Name="AcademicPrograms",Url="www.Yahoo.com",CourseId=1,ResourceType=Rtype.Presentaion},
                new Resource(){ Name="ClassSchedules",Url="www.gmail.com",CourseId=3,ResourceType=Rtype.Other}
            };
            studentSystemContext.resources.AddRange(Resources);
            studentSystemContext.SaveChanges(true);


            //seed homeworks
            var Homeworks = new List<HomeWork>
            {
                new HomeWork(){Content="Solve",ContentType=Ctype.Application,SubmissionTime=DateTime.Now,StudentId=3,CourseId=1},
                new HomeWork(){Content="trace",ContentType=Ctype.Pdf,SubmissionTime=DateTime.Now,StudentId=1,CourseId=2},
                new HomeWork(){Content="try",ContentType=Ctype.Zip,SubmissionTime=DateTime.Now,StudentId=2,CourseId=3}
            };
            studentSystemContext.homeWorks.AddRange(Homeworks);
            studentSystemContext.SaveChanges(true);
        }
    }
}