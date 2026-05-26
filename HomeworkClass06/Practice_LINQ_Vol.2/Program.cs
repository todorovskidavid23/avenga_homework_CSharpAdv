using Practice_LINQ_Vol._2.Models;

List<Car> cars = CarsData.Cars; 


//1.Filter all cars that have origin from Europe.

List<Car> result1 = cars
    .Where(car => car.Origin == "Europe")
    .ToList();

Console.WriteLine("1.Filter all cars that have origin from Europe.");
foreach (Car car in result1)
{
    Console.WriteLine($"{car.Model} - {car.Origin}");
}


Console.WriteLine();


//2.Find all unique cylinder values for cars.
List<int> result2= cars
    .Select(car => car.Cylinders)
    .Distinct()
    .ToList();

Console.WriteLine("2.Find all unique cylinder values for cars.");
foreach (int cylinder in result2)
{
    Console.WriteLine(cylinder);
}

Console.WriteLine();


//3.Select all car names with their model names converted to uppercase.
List<string> result3= cars
    .Select(car=>car.Model.ToUpper())
    .ToList();

Console.WriteLine("3.Select all car names with their model names converted to uppercase.");
foreach (string model in result3)
{
    Console.WriteLine(model);
}

Console.WriteLine();

//4.Check if there are any cars with horsepower greater than 300.
bool result4 = cars
    .Any(car => car.HorsePower > 300);
Console.WriteLine("4.Check if there are any cars with horsepower greater than 300.");
Console.WriteLine(result4);

Console.WriteLine();

//5.Find the car with the highest horsepower.
Car result5 = cars
    .OrderByDescending(car => car.HorsePower)
    .FirstOrDefault();

Console.WriteLine("5.Find the car with the highest horsepower.");
Console.WriteLine($"{result5.Model} - {result5.HorsePower} HP");

Console.WriteLine();


//6.Filter all "Chevrolet" cars and order them by weight in descending order.
List<Car> result6 = cars
    .Where(car => car.Model.Contains("Chevrolet"))
    .OrderByDescending(car => car.Weight)
    .ToList();

Console.WriteLine("6.Filter all \"Chevrolet\" cars and order them by weight in descending order.");
//foreach (Car car in result6)
//{
//    Console.WriteLine($"{car.Model} - Weight: {car.Weight}");
//}
result6.ForEach(x => Console.WriteLine($"{x.Model} - Weight: {x.Weight}"));

Console.WriteLine();

//7.Find the car with the longest model name.
Car result7 = cars
    .OrderByDescending(car => car.Model.Length)
    .FirstOrDefault();

Console.WriteLine("7.Find the car with the longest model name.");
Console.WriteLine($"{result7.Model} - Length: {result7.Model.Length}");

Console.WriteLine();

//8.Group cars by their origin and then order the groups by the number of cars in each group, in ascending order.
var result8 = cars
    .GroupBy(car => car.Origin)
    .OrderBy(group => group.Count())
    .ToList();

Console.WriteLine("8.Group cars by their origin and then order the groups by the number of cars in each group, in ascending order.");
foreach (var group in result8)
{
    Console.WriteLine($"{group.Key} - Count: {group.Count()}");
}

Console.WriteLine();

//9.Find the first 5 cars with the highest horsepower. (hint: read about LINQ methods Skip() and Take())
List<Car> result9 = cars
    .OrderByDescending(x => x.HorsePower)
    .Take(5)
    .ToList();

Console.WriteLine("9.Find the first 5 cars with the highest horsepower. (hint: read about LINQ methods Skip() and Take())");
foreach (Car car in result9)
{
    Console.WriteLine($"{car.Model} - {car.HorsePower} HP");
}

Console.WriteLine();

//10.Find the car with the highest acceleration time.
Car result10 = cars
    .OrderByDescending(x => x.AccelerationTime)
    .FirstOrDefault();

Console.WriteLine("10.Find the car with the highest acceleration time.");
Console.WriteLine($"{result10.Model} - Acceleration time: {result10.AccelerationTime}");

Console.WriteLine();

//11.Select only the model and horsepower of cars with horsepower greater than 200.
var result11 = cars
    .Where(x => x.HorsePower > 200)
    .Select(x => new
    {
        x.Model,
        x.HorsePower
    })
    .ToList();
Console.WriteLine("11.Select only the model and horsepower of cars with horsepower greater than 200.");
foreach (var car in result11)
{
    Console.WriteLine($"{car.Model} - {car.HorsePower} HP");
}

Console.WriteLine();

//12.Select all unique origins of cars, ordered alphabetically (ascending).
List<string> result12 = cars
    .Select(car => car.Origin)
    .Distinct()
    .OrderBy(car => car)
    .ToList();

Console.WriteLine("12.Select all unique origins of cars, ordered alphabetically (ascending).");
foreach (string origin in result12)
{
    Console.WriteLine(origin);
}

Console.WriteLine();


//13.Select all cars with more than 4 cylinders, and order them by origin and then by horsepower.
List<Car> result13 = cars
    .Where(x => x.Cylinders > 4)
    .OrderBy(x => x.Origin)
    .ThenBy(x => x.HorsePower)
    .ToList();

Console.WriteLine("13.Select all cars with more than 4 cylinders, and order them by origin and then by horsepower.");
foreach (Car car in result13)
{
    Console.WriteLine($"{car.Model} - Origin: {car.Origin} - Cylinders: {car.Cylinders} - HP: {car.HorsePower}");
}

Console.WriteLine();

//14.Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders
//and have HorsePower more then 110.0. Join them in one result.

//List<Car> result14 = cars
//    .Where(x => x.Cylinders > 6 || x.Cylinders == 4 && x.HorsePower > 110)
//    .ToList();
//Console.WriteLine("14.Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result.\r\n");
//foreach (Car car in result14)
//{
//    Console.WriteLine($"{car.Model} - Cylinders: {car.Cylinders} - HP: {car.HorsePower}");
//}

//Console.WriteLine();

List<Car> moreThan6Cylinders = cars
    .Where(x => x.Cylinders > 6)
    .ToList();

List<Car> exactly4CylindersAndOver110Hp = cars
    .Where(x => x.Cylinders == 4 && x.HorsePower > 110)
    .ToList();

List<Car> joinedResult = moreThan6Cylinders
    .Concat(exactly4CylindersAndOver110Hp)
    .ToList();

Console.WriteLine("14.Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result.");
foreach (Car car in joinedResult)
{
    Console.WriteLine($"{car.Model} - Cylinders: {car.Cylinders} - HP: {car.HorsePower}");
}

Console.WriteLine();

//15.Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon for these cars.
List<Car> result15 = cars
    .Where(car => car.HorsePower > 200)
    .ToList();

var lowestMpg = result15.Min(x => x.MilesPerGalon);
var highestMpg = result15.Max(x => x.MilesPerGalon);
var averageMpg = result15.Average(x => x.MilesPerGalon);

Console.WriteLine("15.Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon for these cars.");

Console.WriteLine($"Lowest MPG: {lowestMpg}");
Console.WriteLine($"Highest MPG: {highestMpg}");
Console.WriteLine($"Average MPG: {averageMpg}");

Console.WriteLine();
