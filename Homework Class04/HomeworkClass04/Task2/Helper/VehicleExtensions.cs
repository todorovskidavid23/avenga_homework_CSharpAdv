using System;
using System.Collections.Generic;
using System.Text;
using Task2.Task3.Models;

namespace Task2.Task3.Helper
{
    public static class VehicleExtensions
    {
        public static void Drive(this Vehicle vehicle)
        {
            Console.WriteLine("The car is driving");
        }

        public static void Wheelie(this Vehicle vehicle)
        {
            Console.WriteLine("The motorbike is driving on one wheel");
        }

        public static void Sail(this Vehicle vehicle)
        {
            Console.WriteLine("The boat is sailing");
        }

        public static void Fly(this Vehicle vehicle)
        {
            Console.WriteLine("The airplane is flying");
        }
    }
}
