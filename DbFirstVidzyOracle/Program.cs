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
                var video1 = new VIDEO()
                {
                    NAME = "Star Wars Episode 1",
                    RELEASEDATE = new DateTime(1978, 5, 25)

                };

                dbContext.AddVideo("Star Wars Episode 1", new DateTime(1978, 5, 25), "Action");
                Console.WriteLine("Star Wars Episode 1 added");
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
