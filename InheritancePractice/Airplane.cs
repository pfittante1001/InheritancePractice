using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//// Child Class
//Inhetits from Parent class = Vehicle
namespace InheritancePractice
{
    class Airplane : Vehicle
    {
        //fields
        private double altitude;

        //Properties

        public double Altitude { get; }

        //constructors

        public Airplane()
        {
            //default constructor
        }

        //seats carryingCapacity color and movementSpeed are inherited from vehicle

        public Airplane(int seats, int carryCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            altitude = 0d;

        }

        public override void Move()
        {
            altitude += 10000.0d;
            base.Move();
        }

        public override string GetDistanceTraveled()
        {
            return  "Altitude " + altitude + "  " + base.GetDistanceTraveled();
        }
        
    }
}
