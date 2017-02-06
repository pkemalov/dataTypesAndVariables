using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCIIString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            String result = "";
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                char a = (char)number;
                result += a.ToString();
                                
            }
            Console.WriteLine(result);
        }
    }
}
