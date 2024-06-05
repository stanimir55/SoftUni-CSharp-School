using System;
namespace DefiningClasses;

public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] arguments = Console.ReadLine().Split();

            string name = arguments[0];
            int age = int.Parse(arguments[1]);

            Person person = new Person(name, age);
            people.Add(person);
        }

        var filteredPeople = people
            .Where(x => x.Age > 30)
            .OrderBy(x => x.Name)
            .ToList();

        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }

    }
}