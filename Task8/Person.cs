public class Person
{
    public string Name;
    public string Surname;
    public int Age;
    public string GetHello()
    {
        return $"Hello! My name is {Name} {Surname}";
    }
}