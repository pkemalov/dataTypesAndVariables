using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.triangleFormations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSide = int.Parse(Console.ReadLine());
            int secondSide = int.Parse(Console.ReadLine());
            int thirdSide = int.Parse(Console.ReadLine());

            if (firstSide+secondSide>thirdSide & firstSide+thirdSide>secondSide & secondSide+thirdSide>firstSide)
            {
                Console.WriteLine("Triangle is valid.");

                if (firstSide*firstSide+secondSide*secondSide==thirdSide*thirdSide)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }

                else if (firstSide * firstSide + thirdSide * thirdSide == secondSide * secondSide )
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }

                else if (secondSide * secondSide + thirdSide * thirdSide == firstSide * firstSide)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }

                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }

            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
