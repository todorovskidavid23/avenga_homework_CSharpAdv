using Task__2___Shape_interface.Interfaces;

namespace Task__2___Shape_interface.Models
{
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double tbase, double height)
        {
            Base = tbase;
            Height = height;
        }
        public double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
