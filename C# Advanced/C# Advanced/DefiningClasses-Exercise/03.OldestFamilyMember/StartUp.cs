using System;
namespace DefiningClasses;

public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Family family = new Family();

        for (int i = 0; i < n; i++)
        {
            string[] arguments = Console.ReadLine().Split();

            string name = arguments[0];
            int age = int.Parse(arguments[1]);

            Person person = new Person(name, age);
            family.AddMember(person);
        }

        Person oldestPerson = family.GetOldestMember();
        Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
    }
}