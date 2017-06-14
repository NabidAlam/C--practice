using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = @"c:\srip\sri.txt";
            string p2 = @"c:\srip\sri";
            string p3 = @"srip";
            if (Path.HasExtension(p))
            {
                Console.WriteLine("{0} has an extension.", p);
            }
            if (!Path.HasExtension(p2))
            {
                Console.WriteLine("{0} has no extension.", p2);
            }
            if (!Path.IsPathRooted(p3))
            {
                Console.WriteLine("The string {0} contains no root information.", p3);
            }
            Console.WriteLine("Location for Temporary Files : {0}", Path.GetTempPath());
            Console.WriteLine("Full path of {0} is {1}.", p3, Path.GetFullPath(p3));
            Console.WriteLine("File available for Use : {0} ", Path.GetTempFileName());
            Console.Read();
 
        }
    }
}
