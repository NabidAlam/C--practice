using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime sd= new DateTime(2017,6,15);
            Console.WriteLine("Starting date: {0}",sd);

            DateTime ed = sd.AddDays(10);
            Console.WriteLine("Ending date: {0}",ed);


            if (ed > sd)
            {
                Console.WriteLine("{0} occurs after {1}",sd,ed);
            }

            Console.Read();
        }
    }
}
