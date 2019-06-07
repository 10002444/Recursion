using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = RecursivlyAdd(num1, num2);
            Console.WriteLine($"The sum of the numbers form {num1} and {num2} is {sum}");

        }
        public static int RecursivlyAdd(int num1, int num2)
        {
            int sum = num1;

            if(num1 < num2)
            {
                num1++;
                return sum += RecursivlyAdd(num1, num2);
            }
            return sum;
        }
    }
}
