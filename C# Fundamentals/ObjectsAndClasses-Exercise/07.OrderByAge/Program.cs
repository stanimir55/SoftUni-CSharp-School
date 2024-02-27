List<Person> people = new List<Person>();

string commands;
while ((commands = Console.ReadLine()) != "End")
{
    string[] arguments = commands.Split();

    Person person = new Person(arguments[0], arguments[1], int.Parse(arguments[2]));
    var foundPerson = people.FirstOrDefault(x => x.Id == arguments[1]);

    if (foundPerson != null)
    {
        foundPerson.Age = person.Age;
        foundPerson.Name = person.Name;
    }

    people.Add(person);
}

var orderedPeople = people.OrderBy(x => x.Age);

foreach (Person person in orderedPeople)
{
    Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
}

class Person
{
    public Person(string name, string id, int age)
    {
        Name = name;
        Id = id;
        Age = age;
    }

    public string Name { get; set; }

    public string Id { get; set; }

    public int Age { get; set; }

}