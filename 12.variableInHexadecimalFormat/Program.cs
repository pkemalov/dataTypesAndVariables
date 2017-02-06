using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.variableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int final = Convert.ToInt32(number, 16);

            Console.WriteLine(final);
        }
    }
}
