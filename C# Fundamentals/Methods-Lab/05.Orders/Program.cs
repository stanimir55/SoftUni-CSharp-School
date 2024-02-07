string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
double price = 0;

price = CheckProduct(product, price);

PrintSum(quantity, price);

static void PrintSum(int quantity, double price)
{
    Console.WriteLine($"{quantity * price:F2}");
}

static double CheckProduct(string product, double price)
{
    switch (product)
    {
        case "coffee":
            price = 1.50;
            break;
        case "water":
            price = 1.00;
            break;
        case "coke":
            price = 1.40;
            break;
        case "snacks":
            price = 2.00;
            break;
    }

    return price;
}