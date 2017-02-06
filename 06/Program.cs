using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.fromTerabytesToBits
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            decimal bits = (decimal)number * 1024 * 1024 * 1024 * 1024 * 8;

            Console.WriteLine(Math.Round(bits));

        }
    }
}
