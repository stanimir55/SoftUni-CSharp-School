double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = "";
string vacantion = "";
double price = 0;

switch (season)
{ 
    case "summer":
    if (budget <= 100)
    {
        price = budget * 0.30;
        destination = "Bulgaria";
        vacantion = "Camp";
    }
    else if (budget <= 1000)
    {
        price = budget * 0.40;
        destination = "Balkans";
        vacantion = "Camp";
    }
    else
    {
        price = budget * 0.90;
        destination = "Europe";
        vacantion = "Hotel";
    }
    break;

case "winter":
    if (budget <= 100)
    {
        price = budget * 0.70;
        destination = "Bulgaria";
        vacantion = "Hotel";
    }
    else if (budget <= 1000)
    {
        price = budget * 0.80;
        destination = "Balkans";
        vacantion = "Hotel";
    }
    else
    {
        price = budget * 0.90;
        destination = "Europe";
        vacantion = "Hotel";
    }
        break;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{vacantion} - {price:F2}");

