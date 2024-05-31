List<Person> people = ReadPeople();

string condition = Console.ReadLine();
int ageThreshold = int.Parse(Console.ReadLine());

Func<Person, bool> filter = CreateFilter(condition, ageThreshold);

string format = Console.ReadLine();
Action<Person> printer = CreatePrinter(format);

PrintFilteredPeople(people, filter, printer);

List<Person> ReadPeople()
{
    List<Person> people = new List<Person>();

    int linesCount = int.Parse(Console.ReadLine());

    for (int i = 0; i < linesCount; i++)
    {
        string[] arguments = Console.ReadLine().Split(", ");

        Person person = new Person();

        person.Name = arguments[0];
        person.Age = int.Parse(arguments[1]);

        people.Add(person);
    }

    return people;
}

Func<Person, bool> CreateFilter(string condition, int ageThreshold)
{
    switch (condition)
    {
        case "younger": return p => p.Age < ageThreshold;
        case "older": return p => p.Age >= ageThreshold;
        default: return null;
    }
}

Action<Person> CreatePrinter(string format)
{
    switch (format)
    {
        case "name age": return p => Console.WriteLine($"{p.Name} - {p.Age}");
        case "name": return p => Console.WriteLine($"{p.Name}");
        case "age": return p => Console.WriteLine($"{p.Age}");
        default: return default;
    }
}

void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
{
    foreach (var person in people)
    {
        if (filter(person))
        {
            printer(person);
        }
    }
}

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }
}

