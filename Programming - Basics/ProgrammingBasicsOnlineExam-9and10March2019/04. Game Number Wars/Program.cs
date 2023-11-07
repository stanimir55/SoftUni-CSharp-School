string playerOne = Console.ReadLine();
string playerTwo = Console.ReadLine();

int pointsOne = 0;
int pointsTwo = 0;
int cardOne = 0;
int cardTwo = 0;

bool isNumberWarsWinnerOne = false;
bool isNumberWarsWinnerTwo = false;
bool isEndOfGame = false;

while (true)
{
    string inputOne = Console.ReadLine();
    if (inputOne == "End of game")
    {
        isEndOfGame = true;
        break;
    }
    string inputTwo = Console.ReadLine();

    cardOne = int.Parse(inputOne);
    cardTwo = int.Parse(inputTwo);
    int diff = Math.Abs(cardOne - cardTwo);

    if (cardOne > cardTwo)
    {
        pointsOne += diff;
    }
    else if (cardTwo > cardOne)
    {
        pointsTwo += diff;
    }
    else
    {
        cardOne = int.Parse(Console.ReadLine());
        cardTwo = int.Parse(Console.ReadLine());
        if (cardOne > cardTwo)
        {
            isNumberWarsWinnerOne = true;
            break;
        }
        else if (cardOne < cardTwo)
        {
            isNumberWarsWinnerTwo = true;
            break;
        }
    }
}


if (isNumberWarsWinnerOne)
{
    Console.WriteLine("Number wars!");
    Console.WriteLine($"{playerOne} is winner with {pointsOne} points");
}
else if (isNumberWarsWinnerTwo)
{
    Console.WriteLine("Number wars!");
    Console.WriteLine($"{playerTwo} is winner with {pointsTwo} points");
}
else if (isEndOfGame == true)
{
    Console.WriteLine($"{playerOne} has {pointsOne} points");
    Console.WriteLine($"{playerTwo} has {pointsTwo} points");
}
