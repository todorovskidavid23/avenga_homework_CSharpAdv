using Task__2___Shape_interface.Interfaces;
using Task__2___Shape_interface.Models;

IShape[] shapes =
{
    new Rectangle(5,4),
    new Circle(4),
    new Triangle(4,2)
};

foreach (IShape shape in shapes)
{
    Console.WriteLine(shape.GetArea());
}