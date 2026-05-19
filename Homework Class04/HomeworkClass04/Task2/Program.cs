using Task2.Task3.Helper;
using Task2.Task3.Models;

//Task2

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();


Console.WriteLine();


//Task3

car.Drive();
motorBike.Wheelie();
boat.Sail();
plane.Fly();

