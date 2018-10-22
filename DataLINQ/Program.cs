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

                //Extensio Methods
                var query2 = dbContext.Courses
                    .Where(c => c.Name.Contains("c#"))
                    .OrderBy(c => c.Name);

                Console.WriteLine("Extension Methods Results;");
                foreach (var course in query2)
                    Console.WriteLine($"Course name: {course.Name}");
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
