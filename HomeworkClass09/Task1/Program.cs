//// TASK 1
string folderPath = @"..\..\..\Files";
string filePath = Path.Combine(folderPath, "names.txt");

string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory + " is current Directory");

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("Successfully created folder Files");
}
else
{
    Console.WriteLine("Folder Files already exists");
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
    Console.WriteLine("Successfully created file names.txt");
}
else
{
    Console.WriteLine("File already exists!");
}


// TASK 2

Console.WriteLine("Enter names. Type 'x' to stop.");

using (StreamWriter sw = new StreamWriter(filePath, true))
{
    while (true)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        if (name.ToLower() == "x")
        {
            break;
        }

        if (!string.IsNullOrWhiteSpace(name))
        {
            sw.WriteLine(name);
        }
    }
}

Console.WriteLine();
Console.WriteLine("Names were saved in names.txt");


// TASK 3 + TASK 4


if (File.Exists(filePath))
{
    string[] allNames = File.ReadAllLines(filePath);

    for (char letter = 'A'; letter <= 'Z'; letter++)
    {
        string filteredFilePath = folderPath + $"namesStartingWith_{letter}.txt";

        bool hasNamesForThisLetter = false;
        
        List<string> existingNames = new List<string>();

        if (File.Exists(filteredFilePath))
        {
            existingNames = File.ReadAllLines(filteredFilePath).ToList();
        }

        using (StreamWriter sw = new StreamWriter(filteredFilePath, true))
        {
            foreach (string name in allNames)
            {
                if (!string.IsNullOrWhiteSpace(name) &&
                    name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase) &&
                    !existingNames.Contains(name))
                {
                    sw.WriteLine(name);
                    existingNames.Add(name);
                    hasNamesForThisLetter = true;
                }
            }
        }

        FileInfo fileInfo = new FileInfo(filteredFilePath);

        if (!hasNamesForThisLetter && fileInfo.Length == 0)
        {
            File.Delete(filteredFilePath);
        }
    }
}

Console.WriteLine("Filtering is finished!");
Console.ReadLine();