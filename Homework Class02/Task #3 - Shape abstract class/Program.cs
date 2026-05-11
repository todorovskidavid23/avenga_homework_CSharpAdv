using Task__3___Shape_abstract_class.Models;

Shape[] shapes = new Shape[]
{
    new Rectangle(8,9),
    new Circle(5),
    new Triangle(5,6,7)
};

foreach(var shape in shapes)
{
    shape.DisplayInfo();
}