using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            int count = CountDivisions(number);
            Console.WriteLine($"Total number of divisions {count}");

            Console.ReadKey();
        }
        public static int CountDivisions(double number)
        {
            int count = 0;

            if (number > 0 && number % 2 == 0)
            {
                count++;
                number /= 2;
                return count += CountDivisions(number);
            }
            return count;
        }
    }
}
