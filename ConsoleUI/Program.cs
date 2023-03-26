using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var vehicles = new List<Vehicle>();







            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            Car toyota = new Car()
            {
                Year = "2020",
                HasTrunk = true,
                Make = "Toyota",
                Model = "Highlander",
            };

            Motorcycle fasty = new Motorcycle()
            {
                Year = "2030",
                HasSideCart = true,
                Make = "Amazing Motorcycle Make",
                Model = "Spectacular Motorcycle Make"
            };

            Vehicle vehicle = new Car()
            {
                Year = "0",
                HasTrunk = false,
                Make = "Jeep",
                Model = "Cherokee"
            };

            Vehicle scooty = new Motorcycle()
            {
                Year = "2010",
                Make = "Wondercycle",
                Model = "GoodLookingCycle",
                HasSideCart = false
            };

            vehicles.Add(toyota);
            vehicles.Add(fasty);
            vehicles.Add(vehicle);
            vehicles.Add(scooty);






            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle


        }
    }
}

