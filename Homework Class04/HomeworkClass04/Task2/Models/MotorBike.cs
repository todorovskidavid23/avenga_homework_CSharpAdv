using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Task3.Models
{
    public class MotorBike : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Im a motorbike and i drive on 2 wheels :)");
        }

        public void Wheelie()
        {
            Console.WriteLine("Driving on one wheel");
        }

    }
}
