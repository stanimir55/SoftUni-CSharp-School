
//"Red balls: {броят червени топки}"
//"Orange balls: {броят оранжеви топки}"
//"Yellow balls: {броят жълти топки}"
//"White balls: {броят бели топки}"
//"Other colors picked: {броят на избраните топки извън зададените цветове}"
//"Divides from black balls: {броят на пътите, в които точките са били разделяни на 2}"

using System;

int ballNum = int.Parse(Console.ReadLine());
string color = Console.ReadLine();

double points = 0;
switch (color)
{
    case "red":
        points += 5;
        break;
    case "orange":
        points += 10;
        break;
    case "yellow":
        points += 15;
        break;
    case "white":
        points += 20;
        break;
    case "black":
        Math.Floor (points / 2);
            break;
    default:
        points = points;
        break;
}

Console.WriteLine($"Total points: {points}");
Console.WriteLine($"Red balls: {color = "red"}");
Console.WriteLine($"Orange balls: {color = "orange"}");
Console.WriteLine($"Yellow balls: {color = "yellow"}");
Console.WriteLine($"White balls: {color = "while"}");
Console.WriteLine();
Console.WriteLine();
