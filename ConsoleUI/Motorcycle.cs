using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override string Year { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public bool HasaSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Can drive real well.");

        }

        public override void DriveVirtual()
        {
            Console.WriteLine("What can I say this thing can move.");
        }


    }
}
