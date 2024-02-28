int n = int.Parse(Console.ReadLine());
var family = new Family();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split()
        .ToArray();

    var member = new Person(input[0], int.Parse(input[1]));

    family.AddMember(member);
}

if (family.membersList.Count > 0)
{
    family.GetOldestMember();
}


class Person
{
    public Person()
    {

    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }
}

class Family
{
    public Family()
    {
        this.membersList = new List<Person>();
    }

    public List<Person> membersList { get; set; }


    public void AddMember(Person member)
    {
        membersList.Add(member);
    }

    public void GetOldestMember()
    {
        var currentPerson = new Person { Name = "one", Age = -1 };
        foreach (var person in membersList)
        {
            if (currentPerson.Age < person.Age)
            {
                currentPerson = person;
            }
        } 

        Console.WriteLine("{0} {1}", currentPerson.Name, currentPerson.Age);
    }
}

