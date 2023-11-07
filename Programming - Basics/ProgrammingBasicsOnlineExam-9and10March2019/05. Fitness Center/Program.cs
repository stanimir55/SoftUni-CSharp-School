int peopleNum = int.Parse(Console.ReadLine());

int counterBack = 0;
int counterChest = 0;
int counterLegs = 0;
int counterAbs = 0;
int counterProteinShake = 0;
int counterProteinBar = 0;

for (int i = 1; i <= peopleNum; i++)
{
    string activity = Console.ReadLine();

    if (activity == "Back")
    {
        counterBack++;
    }
    else if (activity == "Chest")
    {
        counterChest++;
    }
    else if (activity == "Legs")
    {
        counterLegs++;
    }
    else if (activity == "Abs")
    {
        counterAbs++;
    }
    else if (activity == "Protein shake")
    {
        counterProteinShake++;
    }
    else if (activity == "Protein bar")
    {
        counterProteinBar++;
    }
}

double totalTraining = counterBack + counterAbs + counterChest + counterLegs;
double totalProtein = counterProteinBar + counterProteinShake;
double percentTraining = totalTraining  / peopleNum * 100;
double percentProtein = totalProtein / peopleNum * 100;

Console.WriteLine($"{counterBack} - back");
Console.WriteLine($"{counterChest} - chest");
Console.WriteLine($"{counterLegs} - legs");
Console.WriteLine($"{counterAbs} - abs");
Console.WriteLine($"{counterProteinShake} - protein shake");
Console.WriteLine($"{counterProteinBar} - protein bar");
Console.WriteLine($"{percentTraining:F2}% - work out");
Console.WriteLine($"{percentProtein:F2}% - protein");
