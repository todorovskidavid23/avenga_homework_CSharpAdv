using System;
using System.Collections.Generic;
using System.Text;

namespace Task__3___Shape_abstract_class.Models
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public override double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Round(Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC)), 2);
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
