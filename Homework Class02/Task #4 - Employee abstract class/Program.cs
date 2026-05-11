using Task__4___Employee_abstract_class.Models;

Employee[] employees = new Employee[]
{
    new Manager(1,"Bob",2000,100),
    new Programmer(7,"David",50,40)
};

foreach(var employee in employees)
{
    employee.DisplayInfo();
}