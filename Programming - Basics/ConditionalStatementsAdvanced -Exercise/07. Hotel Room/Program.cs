string month = Console.ReadLine();
int numbreOfNights = int.Parse(Console.ReadLine());

string room = "";
string room1 = "";
double price = 0;
double price1 = 0;

switch (month)
{
    case "May":
        room = "Apartment";
        price = numbreOfNights * 65;
        if (numbreOfNights > 14)
        {
            price = price - price * 0.1;
        }
        room1 = "Studio";
        price1 = numbreOfNights * 50;
        if (numbreOfNights > 14)
        {
            price1 = price1 - price1 * 0.3;
        }
        else if (numbreOfNights > 7)
        {
            price1 = price1 - price1 * 0.05;
        }
        break;
    case "June":
        room = "Apartment";
        price = numbreOfNights * 68.70;
        if (numbreOfNights > 14)
        {
            price = price - price * 0.1;
        }
        room1 = "Studio";
        price1 = numbreOfNights * 75.20;
        if (numbreOfNights > 14)
        {
            price1 = price1 - price1 * 0.2;
        }
        break;
    case "July":
        room = "Apartment";
        price = numbreOfNights * 77;
        if (numbreOfNights > 14)
        {
            price = price - price * 0.1;
        }
        room1 = "Studio";
        price1 = numbreOfNights * 76;
        break;
    case "August":
        room = "Apartment";
        price = numbreOfNights * 77;
        if (numbreOfNights > 14)
        {
            price = price - price * 0.1;
        }
        room1 = "Studio";
        price1 = numbreOfNights * 76;
        break;
    case "September":
        room = "Apartment";
        price = numbreOfNights * 68.70;
        if (numbreOfNights > 14)
        {
            price = price - price * 0.1;
        }
        room1 = "Studio";
        price1 = numbreOfNights * 75.20;
        if (numbreOfNights > 14)
        {
            price1 = price1 - price1 * 0.2;
        }
        break;
    case "October":
        room = "Apartment";
        price = numbreOfNights * 65;
        if (numbreOfNights > 14)
        {
            price = price - price * 0.1;
        }
        room1 = "Studio";
        price1 = numbreOfNights * 50;
        if (numbreOfNights > 14)
        {
            price1 = price1 - price1 * 0.3;
        }
        else if (numbreOfNights > 7)
        {
            price1 = price1 - price1 * 0.05;
        }
        break;
}

Console.WriteLine($"Apartment: {price:F2} lv.");
Console.WriteLine($"Studio: {price1:F2} lv.");



