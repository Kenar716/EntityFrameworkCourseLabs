using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    public enum Level : byte
    {
        Beginner = 1,
        Intermediate = 2,
        Advances = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var dbContext = new PlutoDbContext();            
            //var courses = dbContext.GetCourses();
            //foreach (var course in courses)
            //{
            //    Console.WriteLine(course.Title);
            //}

            var course = new Course();
            course.Level = Level.Beginner; // 1

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
