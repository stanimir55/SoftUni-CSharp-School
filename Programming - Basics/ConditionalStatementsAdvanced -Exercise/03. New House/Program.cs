string flowers = Console.ReadLine();
int numFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double price;

switch (flowers)
{
    case "Roses":
        price = numFlowers * 5;
        if (numFlowers > 80)
            price = price - price * 0.1;
        break;
    case "Dahlias":
        price = numFlowers * 3.80;
        if (numFlowers > 90)
            price = price - price * 0.15;
        break;
    case "Tulips":
        price = numFlowers * 2.80;
        if (numFlowers > 80)
        price = price - price * 0.15;
        break;
    case "Narcissus":
        price = numFlowers * 3;
        if (numFlowers < 120)
        price = price + price * 0.15;
        break;
    default:
        price = numFlowers * 2.50;
        if (numFlowers < 80)
        price = price + price * 0.2;
        break;
}

if (budget >= price)
{
    Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowers} and {budget - price:F2} leva left.");

}
else if(budget < price)
{
    Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");

}














//if (numFlowers > 80)
//rice = price - price * 0.1;
//else if (numFlowers > 90)
//price = price - price * 0.15;
//else if (numFlowers >)
