using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter one even number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int i;
            if (a % 2 == 0)
            {
                for (i = 3; i <= Math.Sqrt(a); i+=2) ;
                {
                    while (a % i == 0)
                    {
                        Console.WriteLine(i + " ");
                        a /= i;
                    }
                }
                if (a > 2)
                    Console.WriteLine(a);
            }
            else
                Console.WriteLine("number isn't even");

            Console.ReadKey();
        }
    }
}
