using Task1.Models;

List<User> usersById = UserDatabase.SearchById(1);

Console.WriteLine("Search by Id:");
foreach (User user in usersById)
{
    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
}

Console.WriteLine();

List<User> usersByName = UserDatabase.SearchByName("Alice");

Console.WriteLine("Search by Name:");
foreach (User user in usersByName)
{
    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
}

Console.WriteLine();

List<User> usersByAge = UserDatabase.SearchByAge(22);

Console.WriteLine("Search by Age:");
foreach (User user in usersByAge)
{
    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
}