using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Parent class
//Children = vehicle

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat firstBoat = new Boat(2, 500, "red", 70d, .78d);
            firstBoat.Move();
            firstBoat.Move();
            Console.WriteLine("Boat distance traveled {0} :", firstBoat.GetDistanceTraveled());
        }
    }
}
