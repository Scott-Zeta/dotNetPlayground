using System.IO;
using System.Collections.Generic;

//get current running directory of the program
Console.WriteLine(Directory.GetCurrentDirectory());

//get the path of the user's documents folder, whatever the OS is
string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
Console.WriteLine(docPath);

// Path class can bu usefule to handle different slash in different OS
// Always avoid hardcoding the path
Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
Console.WriteLine(Path.Combine("stores", "201"));
// Get extension
Console.WriteLine(Path.GetExtension("sales.json"));

// Get File info
string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

FileInfo info = new FileInfo(fileName);

Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // And many more

Console.WriteLine("===============End of notes================");

var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");
var salesFiles = FindFiles(storesDirectory);

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);
File.WriteAllText(Path.Combine(salesTotalDir, "total.txt"), String.Empty);

IEnumerable<string> FindFiles(string folderName)
{
  List<string> salesFiles = new List<string>();

  var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

  foreach (var file in foundFiles)
  {
    // The file name will contain the full path, so only check the end of it
    var extension = Path.GetExtension(file);
    if (extension == ".json")
    {
      salesFiles.Add(file);
    }
  }

  return salesFiles;
}