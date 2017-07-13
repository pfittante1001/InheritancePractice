using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Child Class
//Inhetits from Parent class = Vehicle
namespace InheritancePractice
{
    class Boat : Vehicle//Sets inheritence from Vehicle Class
    {
        //Fields
        private double waterDrag;

        //constructor

        public Boat()
        {
                //default constructor
        }

        public Boat(int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
        }

        public override void Move()//Override allow the child class (Boat)to edit methods 
                                   //from the Parent class (Vehicle)
        {
            distanceTraveled += movementSpeed * waterDrag;
        }
    }
}
