// 60 - 100 //

using System.Xml.Linq;

string command = Console.ReadLine();
List<Person> persons = new List<Person>();
List<Product> products1 = new List<Product>();

string[] people = command
    .Split(";".TrimEnd())
    .ToArray();

for (int i = 0; i < people.Length; i++)
{
    string[] arguments = people[i]
        .Split("=")
        .ToArray();
     
    string name = arguments[0];
    if (name == string.Empty || name.Trim().Length == 0)
    {
        continue;
    }
    decimal money = decimal.Parse(arguments[1]);

    Person person = new Person();

    person.Name = name;
    person.Money = money;

    persons.Add(person);
}

string[] products = Console.ReadLine()
    .Split(";".TrimEnd())
    .ToArray();

for (int i = 0; i < products.Length; i++)
{
    string[] arguments = products[i]
        .Split("=")
        .ToArray();

    string productName = arguments[0];
    if (productName == string.Empty || productName.Trim().Length == 0)
    {
        continue;
    }
    decimal productPrice = decimal.Parse(arguments[1]);

    Product product = new Product();

    product.Name = productName;
    product.Price = productPrice;

    products1.Add(product);
}

while ((command = Console.ReadLine()) != "END")
{
    string[] arguments = command
        .Split(" ")
        .ToArray();

    string name = arguments[0];
    if (name == string.Empty || name.Trim().Length == 0)
    {
        continue;
    }
    string productName = arguments[1];
    if (productName == string.Empty || productName.Trim().Length == 0)
    {
        continue;
    }

    for (int i = 0; i < persons.Count; i++)
    {
        if (persons[i].Name.Contains(name))
        {
            if (persons[i].Money >= products1[i].Price)
            {
                persons[i].Money -= products1[i].Price;
                persons[i].BagOfProducts += $"{productName + ", "}";

                Console.WriteLine($"{persons[i].Name} bought {productName}");
            }
            else 
            {
                Console.WriteLine($"{persons[i].Name} can't afford {productName}");
            }
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