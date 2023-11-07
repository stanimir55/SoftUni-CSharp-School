﻿int degrees = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();

string outfit;
string shoes;

if (dayTime == "Morning")
{
    if (degrees <= 18)
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (degrees <= 24)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }

}
else if (dayTime == "Afternoon")
{
        if (degrees <= 18)
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else if (degrees <= 24)
        {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
        else
        {
            outfit = "Swim Suit";
            shoes = "Barefoot";
        }
}
else
{
    outfit = "Shirt";
    shoes = "Moccasins";
}
Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
