using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter one number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isTrain(a));
            Console.ReadKey();
        }

        private static Boolean isTrain(int a)
        {
            int i;
            int sum = 0;
            for (i = 0; i <= a; i++)
            {
                sum = sum + i;

                if (sum == a)
                {
                    return true;
                }
            }
                    return false;
            
        }
    }
}
