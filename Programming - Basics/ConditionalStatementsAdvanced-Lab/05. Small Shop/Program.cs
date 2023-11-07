string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
double priseOfProduct = 0;

if (city == "Sofia")
{
    switch (product)
    {
        case "coffee" : priseOfProduct = 0.50; break;
        case "water": priseOfProduct = 0.80; break;
        case "beer" : priseOfProduct = 1.20; break;
        case "sweets": priseOfProduct = 1.45; break;
        case "peanuts": priseOfProduct = 1.60; break;
            
    }
}
else if (city == "Plovdiv")
{
    switch (product)
    {
        case "coffee": priseOfProduct = 0.40; break;
        case "water": priseOfProduct = 0.70; break;
        case "beer": priseOfProduct = 1.15; break;
        case "sweets": priseOfProduct = 1.30; break;
        case "peanuts": priseOfProduct = 1.50; break;

    }
}
else if (city == "Varna")
{
    switch (product)
    {
        case "coffee": priseOfProduct = 0.45; break;
        case "water": priseOfProduct = 0.70; break;
        case "beer": priseOfProduct = 1.10; break;
        case "sweets": priseOfProduct = 1.35; break;
        case "peanuts": priseOfProduct = 1.55; break;

    }
}

double finalPrice = quantity * priseOfProduct;
Console.WriteLine(finalPrice);