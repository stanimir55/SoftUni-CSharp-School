string command;
List<OrderByAge> orderByAges = new List<OrderByAge>();

while ((command = Console.ReadLine()) != "End")
{
    string[] arguments = command.Split();

    string name = arguments[0];
    string id = arguments[1];
    int age = int.Parse(arguments[2]);

    OrderByAge orderByAge = new OrderByAge();

    orderByAge.Name = name;
    orderByAge.Id = id;
    orderByAge.Age = age;

    for (int i = 0; i < orderByAges.Count; i++)
    {
        if (orderByAges[i].Id == orderByAge.Id)
        {
            orderByAges[i].Name = orderByAge.Name;
            orderByAges[i].Age = orderByAge.Age;
        }
    }

    orderByAges.Add(orderByAge);
}

List<OrderByAge> sortedAge = orderByAges.OrderBy(orderByAges => orderByAges.Age).ToList();

for (int i = 0; i < sortedAge.Count; i++)
{
    Console.WriteLine(sortedAge[i]);
}


class OrderByAge
{
    public string Name { get; set; }

    public string Id { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} with ID: {Id} is {Age} years old.";
    }
}