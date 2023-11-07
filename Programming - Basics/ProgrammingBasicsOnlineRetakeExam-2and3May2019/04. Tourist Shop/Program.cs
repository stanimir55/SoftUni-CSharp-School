double budget = double.Parse(Console.ReadLine());

int productNum = 0;
double totalProductPrice = 0;

while (true)
{
    string productName = Console.ReadLine();

    if (productName == "Stop")
    {
        Console.WriteLine($"You bought {productNum} products for {totalProductPrice:F2} leva.");
        break;
    }
    else
    {
        double productPrice = double.Parse(Console.ReadLine());
        productNum++;

        if (productNum % 3 == 0)
        {
            productPrice /= 2;
        }

        if (budget < productPrice)
        {
            Console.WriteLine("You don't have enough money!");
            Console.WriteLine($"You need {Math.Abs(budget - productPrice):F2} leva!");
            break;
        }

        totalProductPrice += productPrice;
        budget -= productPrice;
    }
}
