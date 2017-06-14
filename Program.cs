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
            Console.WriteLine("Enter Number of Elements you Want to Hold in the Array ? ");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            int[] a = new int[x];
            Console.WriteLine("Enter Array Elements :");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Array.Sort(a);
            Console.WriteLine("Sorted Array : ");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("{0}", a[i]);
            }
            Console.Read();
        }
    }
}
