string path = @"D:\Учеба бим";
string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
foreach (string file in files)
{
    Console.WriteLine(file);
}