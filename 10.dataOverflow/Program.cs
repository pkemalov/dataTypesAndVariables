using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.dataOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber = ulong.Parse(Console.ReadLine());

            ulong minNumber = Math.Min(firstNumber, secondNumber);
            ulong maxNumber = Math.Max(firstNumber, secondNumber);

            if (maxNumber>= ushort.MinValue && maxNumber <= ushort.MaxValue)
            {
                Console.WriteLine("bigger type: ushort");
            }

            else
            {
                if (maxNumber >= uint.MinValue && maxNumber <= uint.MaxValue)
                {
                    Console.WriteLine("bigger type: uint");
                }

                else 
                {
                    if (maxNumber >= ulong.MinValue && maxNumber <= ulong.MaxValue)
                    {
                        Console.WriteLine("bigger type: ulong");
                    }
                }
            }


            if (minNumber>= byte.MinValue && minNumber<= byte.MaxValue)
            {
                Console.WriteLine("smaller type: byte");
                Console.WriteLine("{0} can overflow byte {1} times", maxNumber, Math.Round(maxNumber/255.0));
            }

            else
            {
                if (minNumber >= ushort.MinValue && minNumber <= ushort.MaxValue)
                {
                    Console.WriteLine("smaller type: ushort");
                    Console.WriteLine("{0} can overflow ushort {1} times", maxNumber, Math.Round(maxNumber / 65535.0));
                }

                else
                {
                    if (minNumber >= uint.MinValue && minNumber <= uint.MaxValue)
                    {
                        Console.WriteLine("smaller type: uint");
                        Console.WriteLine("{0} can overflow unit {1} times", maxNumber, Math.Round(maxNumber / 4294967295.0));
                    }
                }
            }
            
        }
    }
}
