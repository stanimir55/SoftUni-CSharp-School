string stage = Console.ReadLine();
string typeOfTicket = Console.ReadLine();
int countTicket = int.Parse(Console.ReadLine());
string yOrN = Console.ReadLine();

double ticketPrice = 0;
double photoPrice = 40;
if (stage == "Quarter final")
{
    if (typeOfTicket == "Standard")
    {
        ticketPrice = 55.50;
        
    }
    else if (typeOfTicket == "Premium") 
    {
        ticketPrice = 105.20;
    }
    else if (typeOfTicket == "VIP")
    {
        ticketPrice = 118.90;
    }
}
else if (stage == "Semi final")
{
    if (typeOfTicket == "Standard")
    {
        ticketPrice = 75.88;
    }
    else if (typeOfTicket == "Premium")
    {
        ticketPrice = 125.22;
    }
    else if (typeOfTicket == "VIP")
    {
        ticketPrice = 300.40;
    }
}
else if (stage == "Final")
{
    if (typeOfTicket == "Standard")
    {
        ticketPrice = 110.10;
    }
    else if (typeOfTicket == "Premium")
    {
        ticketPrice = 160.66;
    }
    else if (typeOfTicket == "VIP")
    {
        ticketPrice = 400.00;
    }
}

double totalPrice = ticketPrice * countTicket;

if (totalPrice > 4000)
{
    totalPrice -= totalPrice * 0.25;
    yOrN = "N";
}
else if (totalPrice > 2500)
{
    totalPrice -= totalPrice * 0.10;
}
if (yOrN == "Y")
{
    totalPrice += countTicket * photoPrice;
}

Console.WriteLine($"{totalPrice:F2}");
