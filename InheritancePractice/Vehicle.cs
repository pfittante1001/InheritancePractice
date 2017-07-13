using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Parent class
//Children == Boat, Airplane

namespace InheritancePractice
{
    class Vehicle
    {

        //fields
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        protected double distanceTraveled;
        private float gearRatio;
        private float engineSize;

        //properties

        public int Seats { get; }
        public int CarryingCapacity { get; }
        public string Color { get; set; }
        public float GearRatio { get; set; }
        public float EngineSize { get; set; }
        public double DistanceTraveled { get; set; }

        //constructors

        public Vehicle()
        {
            //default constructor
        }

        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            distanceTraveled = 0;
        }

        public virtual void Move()// Virtual allow children class to edit the method to be inherited
        {
            distanceTraveled += movementSpeed;
        }

        public virtual string GetDistanceTraveled()
        {
            return "Distance Traveled: " + distanceTraveled + "\n";
        }
    }
}
