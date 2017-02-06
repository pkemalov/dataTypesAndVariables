using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.trickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());
            string text = "";
            string lastText = "";

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                if (n-1>i)
                {
                    text = text + word;
                    text = text + delimiter;
                }
                else if (n-1==i)
                {
                    lastText = lastText + word;
                }
                
            }
            Console.Write(text);
            Console.WriteLine(lastText);
        }
    }
}
