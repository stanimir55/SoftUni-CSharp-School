

string product = Console.ReadLine();
int quantityOfTheProduct = int.Parse(Console.ReadLine());

double[] price = new double[4];
price[0] = 1.50;
price[1] = 1.00;
price[2] = 1.40;
price[3] = 2.00;

static void CoffeePrice(double price, int quantityOfTheProduct)
{
    Console.WriteLine($"{price * quantityOfTheProduct:F2}");
}

if (product == "coffee")
{
   CoffeePrice(price[0],quantityOfTheProduct);
}
else if (product == "water")
{
    CoffeePrice(price[1], quantityOfTheProduct);
}
else if (product == "coke")
{
    CoffeePrice(price[2], quantityOfTheProduct);
}
else if (product == "snacks")
{
    CoffeePrice(price[3], quantityOfTheProduct);
}


//string product = Console.ReadLine();
//int quantityOfTheProduct = int.Parse(Console.ReadLine());

//double price = 0;

//if (product == "coffee")
//{
//    price = 1.50;
//}
//else if (product == "water")
//{
//    price = 1.00;
//}
//else if (product == "coke")
//{
//    price = 1.40;
//}
//else if (product == "snacks")
//{
//    price = 2.00;
//}

//double totalPrice = quantityOfTheProduct * price;

//Console.WriteLine($"{totalPrice:F2}");