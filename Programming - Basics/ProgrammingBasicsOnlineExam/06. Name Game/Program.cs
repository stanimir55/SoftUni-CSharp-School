string namePlayer = Console.ReadLine();

int letter = 0;
int maxScore = 0;
string winnerName = string.Empty;

while(namePlayer != "Stop")
{
    int score = 0;

    for (int i = 0; i < namePlayer.Length; i++)
    {
        letter = (int)namePlayer[i];

        int player = int.Parse(Console.ReadLine());

        if (letter == player)
        {
            score += 10;
        }
        else
        {
            score += 2;
        }
        if (score >= maxScore)
        {
            maxScore = score;
            winnerName = namePlayer;
        }
    }

    namePlayer = Console.ReadLine();
}

Console.WriteLine($"The winner is {winnerName} with {maxScore} points!");
