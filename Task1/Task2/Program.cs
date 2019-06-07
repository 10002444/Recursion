using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number that is greater than the first: ");
            int num2 = int.Parse(Console.ReadLine());

            int numbersBetween = 0;
            //int numbersBetween = recursive(num1, num2);
            Console.WriteLine($"The numbers between {num1} and {num2} are {numbersBetween}");

            Console.ReadKey();

        }
        public static int recursive(int num1, int num2, int numbersBetween)
        {
            while (num1 > num2)
            {
                num1++;
                //numbersBetween++;
                //return numbersBetween * (numbersBetween + 1) / 2;
            }
            return numbersBetween;
        }
    }
}
