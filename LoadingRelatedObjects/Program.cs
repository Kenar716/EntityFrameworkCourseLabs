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
