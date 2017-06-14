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
            Console.WriteLine("Enter number of array you want: ");
            string s= Console.ReadLine();
            int x = Convert.ToInt32(s);

            int[] a= new int [x];
            Console.WriteLine("Enter array elements: ");

            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Convert.ToInt32(s1);

            }

            Array.Sort(a);
            Console.WriteLine("Sorted array: ");

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Elements: {0}",a[i]);
            }
            Console.Read();
        }
    }
}
