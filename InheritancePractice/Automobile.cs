using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//// Child Class
//Inhetits from Parent class = Vehicle
namespace InheritancePractice
{
    class Automobile    : Vehicle
    {
        //fields
        private int numWheels;
        private int numDoors;
        private float wheelSize;

        //properties

        public int NumWheels { get; }
        public int NumDoors { get; }
        public float WheelSize { get; }

        //Constructor

        public Automobile()
        {
            //default constructor
        }

        public Automobile(int numWheels, float wheelSize, int numDoors, int seats, 
            int carryingCapacity, string color, double movementSpeed )
        {
            this.numDoors = numWheels;
            this.numWheels = numWheels;
            this.wheelSize = wheelSize;
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }


    }
}
