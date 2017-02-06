using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (symbol=='+')
            {
                int result = firstNumber + secondNumber;
                Console.WriteLine("{0} {1} {2} = {3}", firstNumber, symbol, secondNumber, result);
            }
            else if (symbol == '-')
            {
                int result = firstNumber - secondNumber;
                Console.WriteLine("{0} {1} {2} = {3}", firstNumber, symbol, secondNumber, result);
            }
            else if (symbol == '*')
            {
                int result = firstNumber * secondNumber;
                Console.WriteLine("{0} {1} {2} = {3}", firstNumber, symbol, secondNumber, result);
            }
            else if (symbol == '/')
            {
                int result = firstNumber / secondNumber;
                Console.WriteLine("{0} {1} {2} = {3}", firstNumber, symbol, secondNumber, result);
            }
        }
    }
}
