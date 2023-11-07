int dayToStay = int.Parse(Console.ReadLine());
string typeOfRoom = Console.ReadLine();
string evaluation = Console.ReadLine();

double price;
double price1;
double price2;

switch (typeOfRoom)
{
    case "room for one person":
        dayToStay -= 1;
        price = dayToStay * 18.00;

        if (evaluation == "positive")
        {
            price = price + price * 0.25;

        }
        else if (evaluation == "negative")
        {
            price = price - price * 0.10;
        }
        Console.WriteLine($"{ price:F2}");
        break;
    case "apartment":
        dayToStay -= 1;
        price1 = dayToStay * 25.00;
        if (dayToStay < 10)
        {
            price1 = price1 - price1 * 0.30;
        }
        else if (dayToStay < 15)
        {
            price1 = price1 - price1 * 0.35;
        }
        else if (dayToStay > 15)
        {
            price1 = price1 - price1 * 0.50;
        }
        if (evaluation == "positive")
        {
            price1 = price1 + price1 * 0.25;
        }
        else if (evaluation == "negative")
        {
            price1 = price1 - price1 * 0.10;
        }
            Console.WriteLine(($"{price1:F2}"));
        break;
    case "president apartment":
        dayToStay -= 1;
        price2 = dayToStay * 35.00;
        if (dayToStay < 10)
        {
            price2 = price2 - price2 * 0.10;
        }
        else if (dayToStay < 15)
        {
            price2 = price2 - price2 * 0.15;
        }
        else if (dayToStay > 15)
        {
            price2 = price2 - price2 * 0.20;
        }
        if (evaluation == "positive")
        {
            price2 = price2 + price2 * 0.25;
        }
        else if (evaluation == "negative")
        {
            price2 = price2 - price2 * 0.10;
        }
         Console.WriteLine(($"{price2:F2}"));
        break;
}



