namespace Task__3___Shape_abstract_class.Models
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public void DisplayInfo()
        {
            Console.WriteLine($"Shape: {GetType().Name}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
        }
    }
}
