int n = int.Parse(Console.ReadLine());
string[] names = new string[n];
for (int i = 0; i < n; i++)
{
    names[i] = Console.ReadLine();
}
foreach (var name in names)
{
    System.Console.WriteLine(name);
}