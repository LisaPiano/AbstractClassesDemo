﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This car can really drive!");
        }

    }
}
