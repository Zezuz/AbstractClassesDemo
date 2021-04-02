using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override string Year { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("This car does something.");
        }

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Drive Virtual");
        }
    }
}
