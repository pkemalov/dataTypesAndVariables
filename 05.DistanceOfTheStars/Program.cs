using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DistanceOfTheStars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYear = 9450000000000;
            decimal proximaCentauri = 4.22m * lightYear;
            decimal milkyWay = 26000m * lightYear;
            decimal diameterMilkyWay = 100000m * lightYear;
            decimal edgeDistance = 46500000000m * lightYear;

            Console.WriteLine(proximaCentauri.ToString("e2"));
            Console.WriteLine(milkyWay.ToString("e2"));
            Console.WriteLine(diameterMilkyWay.ToString("e2"));
            Console.WriteLine(edgeDistance.ToString("e2"));

        }
    }
}
