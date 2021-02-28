using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proceso iniciado.");
            try
            {
                var dbContext = new PlutoContext();

                //LINQ Syntax
                var query =
                    from c in dbContext.Courses
                    where c.Name.Contains("c#")
                    orderby c.Name
                    select c;

                Console.WriteLine("LINQ Sintax Results;");
                foreach (var course in query)
                    Console.WriteLine($"Course name: {course.Name}");

                //Extension Methods
                var query2 = dbContext.Courses
                    .Where(c => c.Name.Contains("c#"))
                    .OrderBy(c => c.Name);

                Console.WriteLine("Extension Methods Results;");
                foreach (var course in query2)
                    Console.WriteLine($"Course name: {course.Name}");

                //Deferred Execution
                //var beginnerCourses = dbContext.Courses.Where(c => c.IsBeginnerCourse == true); //Error because IsBeginnerCourse is a property that is functional only in memory
                //There are somo options to run the case like before, they will be see later in the course
                var beginnerCourses = dbContext.Courses.ToList().Where(c => c.IsBeginnerCourse == true); //This will work but has to load all courses in the memory of the app to use the property of IsBeginnerCourse

                //IQueryable ---> IEnumerable
                //IQueryable: Allows queries to be extended without being executed.

                //One query run in the database, but with the filter of the where
                IQueryable<Course> coursesIQ = dbContext.Courses;
                var filteredIQ = coursesIQ.Where(c => c.Level == 1);
                foreach (var course in filteredIQ)
                    Console.WriteLine(course.Name);

                //One query with all the courses, and the in memory the filter is applied
                IEnumerable<Course> coursesIE= dbContext.Courses;
                var filteredIE = coursesIQ.Where(c => c.Level == 1);
                foreach (var course in filteredIE)
                    Console.WriteLine(course.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            Console.WriteLine("Proceso terminado.");
            Console.ReadLine();
        }
    }
}
