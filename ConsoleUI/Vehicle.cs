using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle_
    {
        public string Year { get; set; } = "2013";
        public string Make { get; set; } = "default make";
        public string Model { get; set; } = "default model";

        public abstract void DriveAbstract(); //stubbed out method
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This sure is a virtual vehicle!");
        }
    }
}
