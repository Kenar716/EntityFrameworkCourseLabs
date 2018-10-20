using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstOracle
{
    public class Program
    {
        public enum Level : byte
        {
            Beginner = 1,
            Intermediate = 2,
            Advanced = 3
        }

        static void Main(string[] args)
        {
            var dbContext = new PlutoDbContext();

            //var courses1 = dbContext.GetAuthorCourses(1);
            //foreach (var c1 in courses1)
            //{
            //    Console.WriteLine(c1.Author.Name);
            //    Console.WriteLine(c1.Title);
            //}

            //var courses = dbContext.GetCourses();
            //foreach (var c in courses)
            //{
            //    Console.WriteLine(c.Author.Name); //Tambien funnciona si uso el Entities y no el complex Type
            //    Console.WriteLine(c.Title);
            //}

            //Lazy Loading ????
            var courses2 = dbContext.Courses;
            foreach (var c2 in courses2)
            {

                Console.WriteLine($"Author: {c2.Author.Name} \nTitle {c2.Title}");
                //if (c2.Levell == CourseLevel.Advance)
                //    Console.WriteLine("This is an advance course.");

                if (c2.Levell == Level.Advanced)
                    Console.WriteLine("This is an advance course.");
                else
                    Console.WriteLine("This is NOT an advance course.");
            }

            Console.WriteLine("Press a key...");
            Console.ReadKey();
        }
    }
}
