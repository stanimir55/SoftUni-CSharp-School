string playerName = Console.ReadLine();

int playerPoints = 301;
int counterY = 0;
int counterN = 0;
while (playerPoints != 0)
{
    string field = Console.ReadLine();
    if (field == "Retire")
    {
        Console.WriteLine($"{playerName} retired after {counterN} unsuccessful shots.");
        break;
    }

    int points = int.Parse(Console.ReadLine());

    if (field == "Single")
    {
        if (points <= playerPoints && playerPoints > 0)
        {
            playerPoints -= points;
            counterY++;
        }
        else
        {
            counterN++;
        }
    }
    else if (field == "Double")
    {
        points *= 2;
        if (points <= playerPoints && playerPoints > 0)
        {
            playerPoints -= points;
            counterY++;
        }
        else
        {
            counterN++;
        }
    }
    else if (field == "Triple")
    {
        points *= 3;
        if (points <= playerPoints && playerPoints > 0)
        {
            playerPoints -= points;
            counterY++;
        }
        else
        {
            counterN++;
        }
    }
    if (playerPoints == 0)
    {
        Console.WriteLine($"{playerName} won the leg with {counterY} shots.");
        break;

    }

}
