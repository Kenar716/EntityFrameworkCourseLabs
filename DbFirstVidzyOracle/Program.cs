using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstVidzyOracle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proceso iniciado.");
            try
            {
                var dbContext = new VidzyDbContext();

                //1st Iteration
                //var video1 = new VIDEO()
                //{
                //    NAME = "Star Wars Episode 1",
                //    RELEASEDATE = new DateTime(1978, 5, 25)

                //};
                //dbContext.AddVideo("Star Wars Episode 1", new DateTime(1978, 5, 25), "Action");
                //Console.WriteLine("Star Wars Episode 1 added");

                //2nd Iteration
                dbContext.AddVideo("It", new DateTime(1985, 10, 20), "Horror");
                Console.WriteLine("It added");
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
