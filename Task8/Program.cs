List<Person> personList = new List<Person>();
for (int i = 1; i <= 3; i++)
{
    System.Console.WriteLine($"Person {i}");
    Person person = new Person()
    {
        Name = Console.ReadLine(),
        Surname = Console.ReadLine(),
        Age = int.Parse(Console.ReadLine())
    };
    personList.Add(person);
}
foreach (var person in personList)
{
    System.Console.WriteLine(person.GetHello());
}
