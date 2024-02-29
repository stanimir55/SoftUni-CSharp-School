string command = Console.ReadLine();
List<Person> persons = new List<Person>();
List<Product> products = new List<Product>();

string[] people = command
    .Split(";".TrimEnd())
    .ToArray();

for (int i = 0; i < people.Length; i++)
{
    string[] arguments = people[i]
        .Split("=")
        .ToArray();

    Person person = new Person();
    person.Name = arguments[0];
    person.Money = decimal.Parse(arguments[1]);

    persons.Add(person);
}

string[] productsArr = Console.ReadLine()
    .Split(";".TrimEnd())
    .ToArray();

for (int i = 0; i < productsArr.Length; i++)
{
    string[] arguments = productsArr[i]
        .Split("=")
        .ToArray();

    if (arguments[0] == string.Empty || arguments[0].Trim().Length == 0)
    {
        continue;
    }

    Product product = new Product();
    product.Name = arguments[0];
    product.Price = decimal.Parse(arguments[1]);

    products.Add(product);
}

while ((command = Console.ReadLine()) != "END")
{
    string[] arguments = command
        .Split(" ")
        .ToArray();

    Person person = persons.FirstOrDefault(x => x.Name == arguments[0]);
    Product product = products.FirstOrDefault(x => x.Name == arguments[1]);

    if (persons.Contains(person))
    {
        if (person.Money >= product.Price)
        {
            person.Money -= product.Price;
            person.BagOfProducts += $"{arguments[1] + ", "}";

            Console.WriteLine($"{person.Name} bought {arguments[1]}");
        }
        else
        {
            Console.WriteLine($"{person.Name} can't afford {arguments[1]}");
        }
    }
}

for (int i = 0; i < persons.Count; i++)
{
    if (persons[i].BagOfProducts == null)
    {
        Console.WriteLine($"{persons[i].Name} - Nothing bought");
    }
    else
    {
        Console.WriteLine($"{persons[i].Name} - {persons[i].BagOfProducts.TrimEnd(' ', ',')}");
    }
}


class Person
{
    public string Name { get; set; }

    public decimal Money { get; set; }

    public string BagOfProducts { get; set; }
}

class Product
{
    public string Name { get; set; }

    public decimal Price { get; set; }
}
