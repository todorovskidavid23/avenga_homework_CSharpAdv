using Task1;

PrintInConsole printer = new PrintInConsole();
printer.Print("Hello David");
printer.Print(12345678910);
printer.Print(14.56);
Console.WriteLine("==========");

List<string> names = new List<string>()
{
    "David","John","Alice","Bob"
};

printer.PrintCollection(names);


List<int> numbers = new List<int>()
{
    1,2,3,4,5
};

printer.PrintCollection(numbers);

