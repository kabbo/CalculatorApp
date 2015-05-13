using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("first number: ");
            int value1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("second number: ");
            int value2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("add: ");
            Console.WriteLine(AddNumber(value1, value2));
            Console.Write("subtract: ");
            Console.WriteLine(SubtractNumber(value1, value2));
            Console.Write("multiplyr: ");
            Console.WriteLine(MultiplyNumber(value1, value2));
            Console.Write("divide: ");
            Console.WriteLine(DivideNumber(value1, value2));
            Console.ReadKey();
        }

        static int AddNumber(int value1, int value2)
        {
            return value1 + value2;
        }

        static int SubtractNumber(int value1, int value2)
        {
            return value1 - value2;
        }

        static int MultiplyNumber(int value1, int value2)
        {
            return value1 * value2;
        }

        static int DivideNumber(int value1, int value2)
        {
            return value1 / value2;
        }

    }
}
