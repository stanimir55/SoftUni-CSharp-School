string input;
double money = 0;
double price = 0;

while ((input = Console.ReadLine()) != "Start")
{
    double coins = double.Parse(input);

    if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
    {
        Console.WriteLine($"Cannot accept {coins}");
    }

    money += coins;
}

while ((input = Console.ReadLine()) != "End")
{
    switch (input)
    {
        case "Nuts":
            price = 2; break;
        case "Water":
            price = 0.7; break;
        case "Crisps":
            price = 1.5; break;
        case "Soda":
            price = 0.8; break;
        case "Coke":
            price = 1; break;
        default:
            Console.WriteLine("Invalid product"); continue;
    }

    if (money >= price)
    {
        money -= price;
        Console.WriteLine($"Purchased {input.ToLower()}"); continue;
    }

    Console.WriteLine("Sorry, not enough money");
}

Console.WriteLine($"Change: {money:F2}");


//string coins = Console.ReadLine();
//double money = 0;

//while (coins != "Start")
//{
//    double input = double.Parse(coins);

//    if (input == 0.1)
//    {
//        money += 0.1;
//    }
//    else if (input == 0.2)
//    {
//        money += 0.2;
//    }
//    else if (input == 0.5)
//    {
//        money += 0.5;
//    }
//    else if (input == 1)
//    {
//        money += 1;
//    }
//    else if (input == 2)
//    {
//        money += 2;
//    }
//    else
//    {
//        Console.WriteLine($"Cannot accept {input}");
//    }

//    coins = Console.ReadLine();
//}

//string product = Console.ReadLine();

//while (product != "End")
//{   
//    if (product == "Nuts")
//    {
//        if (money >= 2)
//        {
//            money -= 2;
//            Console.WriteLine($"Purchased {product.ToLower()}");
//        }
//        else
//        {
//            Console.WriteLine("Sorry, not enough money");
//        }
//    }
//    else if (product == "Water")
//    {
//        if (money >= 0.7)
//        {
//            money -= 0.7;
//            Console.WriteLine($"Purchased {product.ToLower()}");
//        }
//        else
//        {
//            Console.WriteLine("Sorry, not enough money");
//        }
//    }
//    else if (product == "Crisps")
//    {
//        if (money >= 1.5)
//        {
//            money -= 1.5;
//            Console.WriteLine($"Purchased {product.ToLower()}");
//        }
//        else
//        {
//            Console.WriteLine("Sorry, not enough money");
//        }
//    }
//    else if (product == "Soda")
//    {
//        if (money >= 0.8)
//        {
//            money -= 0.8;
//            Console.WriteLine($"Purchased {product.ToLower()}");
//        }
//        else
//        {
//            Console.WriteLine("Sorry, not enough money");
//        }
//    }
//    else if (product == "Coke")
//    {
//        if (money >= 1)
//        {
//            money -= 1;
//            Console.WriteLine($"Purchased {product.ToLower()}");
//        }
//        else
//        {
//            Console.WriteLine("Sorry, not enough money");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid product");
//    }
  
//    product = Console.ReadLine();
//}

//Console.WriteLine($"Change: {money:F2}");
