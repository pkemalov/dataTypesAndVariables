using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.cypherRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string text = "";

            for (int i = 0; i < number; i++)
            {
                string randomCharacters = Console.ReadLine();

                if (randomCharacters != "spin")
                {
                    text = text + randomCharacters;
                }
                else
                {

                }
                
            }
            Console.WriteLine(text);
        }
    }
}
