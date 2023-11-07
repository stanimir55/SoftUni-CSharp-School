int tabs = int.Parse(Console.ReadLine());
int solary = int.Parse(Console.ReadLine());
string site;

for (int i = 1; i <= tabs; i++)
{
    site = Console.ReadLine();

    if (site == "Facebook")
    {
        solary -= 150;
    }
    else if (site == "Instagram")
    {
        solary -= 100;
    }
    else if (site == "Reddit")
    {
        solary -= 50;
    }
    else
        continue;

    if (solary <= 0)
    {
        Console.WriteLine($"You have lost your salary.");
        break;
    }
}

if (solary > 0)
{
    Console.WriteLine(solary);
}

