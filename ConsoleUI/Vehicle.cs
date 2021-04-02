using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {

        public override string ToString()
        {
            return $"{Make} {Model} {Year}.";
        }

        public abstract string Year { get; set; }
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Drive Virtual");
        }


    }
}
