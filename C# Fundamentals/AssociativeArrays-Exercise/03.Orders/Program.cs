var products = new Dictionary<string, Product>();

string commands;
while ((commands = Console.ReadLine()) != "buy")
{
    string[] arguments = commands.Split();

    Product product = new Product(arguments[0], decimal.Parse(arguments[1]), decimal.Parse(arguments[2]));

    if (!products.ContainsKey(product.Name))
    {
        products.Add(product.Name, product);
        continue;
    }

    products[product.Name].Price = decimal.Parse(arguments[1]);
    products[product.Name].Quantity += decimal.Parse(arguments[2]);
}

foreach (var kvp in products)
{
    Console.WriteLine(kvp.Value);
}

class Product
{
    public Product(string name, decimal price, decimal quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public decimal Quantity { get; set; }

    public override string ToString()
    {
        return $"{Name} -> {Price * Quantity:F2}";
    }
}