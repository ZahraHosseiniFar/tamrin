using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter one number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isSquare(a));
            Console.ReadKey();
        }

        private static Boolean isSquare(int x)
        {
            int i;
            for (i = 1; i <= (x / 2); i++)
            {
                if (x == i * i)
                    return true;
            }
            return false;
        }
    }
   
}
