int commandsCount = int.Parse(Console.ReadLine());
List<string> persons = new List<string>();

for (int i = 0; i < commandsCount; i++)
{
    string[] command = Console.ReadLine().Split();
    string name = command[0];
    if (command[2] == "going!")
    {
        if (persons.Exists(x => x == name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            persons.Add(name);
        }
    }
    else if (command[2] == "not")
    {
        if (persons.Exists(x => x == name))
        {
            persons.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}

for (int i = 0; i < persons.Count; i++)
{
    Console.WriteLine(persons[i]);
}

