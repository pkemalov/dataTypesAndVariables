using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.travelingAtLightSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal secondsPerOneYear = 9450000000000 / 300000;
            decimal timeInWeeks = lightYears * secondsPerOneYear / 60 / 60 / 24 / 7;
            decimal timeInDays = lightYears * secondsPerOneYear / 60 / 60 / 24 % 7;
            decimal timeInHours = lightYears * secondsPerOneYear / 60 / 60 % 24;
            decimal timeInMinutes = lightYears * secondsPerOneYear / 60 % 60; 
            decimal timeInSeconds = lightYears * secondsPerOneYear % 60; 

            Console.WriteLine("{0:f0} weeks", Math.Round(timeInWeeks));
            Console.WriteLine("{0:f0} days", Math.Round(timeInDays));
            Console.WriteLine("{0:f0} hours", Math.Round(timeInHours));
            Console.WriteLine("{0:f0} minutes", Math.Round(timeInMinutes));
            Console.WriteLine("{0:f0} seconds", Math.Round(timeInSeconds));
        }
    }
}
