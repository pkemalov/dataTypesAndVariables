using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.incrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number <=255)
            {
                Console.WriteLine(number);
                
            }
            else
            {
                int Overflows = number / 256;
                Console.WriteLine(number-Overflows*256);
                Console.WriteLine($"Overflowed {Overflows} times");
            }
            
        }
    }
}
