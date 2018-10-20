using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstVidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proceso iniciado.");
            try
            {
                var dbContext = new VizdyDbContext();
                //var video1 = new Video()
                //{
                //    Name = "Star Wars Episode 1",
                //    ReleaseDate = new DateTime(1978, 5, 25)

                //};

                //dbContext.AddVideo("Star Wars Episode 1", new DateTime(1978, 5, 25), "Action");
                //Console.WriteLine("Star Wars Episode 1 added");

                //dbContext.AddVideo("It", new DateTime(1985, 10, 20), "Horror");
                //Console.WriteLine("It added");

                //dbContext.AddVideo("Star Wars Episode III", new DateTime(2005, 5, 25), "Horror");
                //Console.WriteLine("Star Wars Episode III added");

                dbContext.AddVideo("Clone Wars", new DateTime(2008, 5, 25), "Horror", ClasificationTypes.Platinum);
                Console.WriteLine("Clone Warsadded");
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
