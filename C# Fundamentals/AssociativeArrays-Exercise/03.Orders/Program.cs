﻿string command;
var products = new Dictionary<string, Product>();

while ((command = Console.ReadLine()) != "buy")
{
    List<string> arguments = command
        .Split()
        .ToList();

    string name = arguments[0];
    decimal price = decimal.Parse(arguments[1]);
    decimal quantity = decimal.Parse(arguments[2]);

    Product product = new Product(name,price,quantity);

    if (!products.ContainsKey(name))
    {
        products.Add(product.Name, product);
    }
    else
    {
        products[product.Name].Update(product.Price, product.Quantity);
    } 
}

foreach (KeyValuePair<string,Product> kvp in products)
{
    Console.WriteLine(kvp.Value);
}


class Product
{
    public string Name { get; set; }

    public decimal Price { get; set; }

    public decimal Quantity { get; set; }



    public Product( string name, decimal price, decimal quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public void Update(decimal price, decimal quantity)
    {
        Price = price;
        Quantity += quantity;
    }

    public decimal GetTotal()
    {
        return Price * Quantity;
    }

    public override string ToString()
    {
        return $"{Name} -> {GetTotal():F2}";
    }
}