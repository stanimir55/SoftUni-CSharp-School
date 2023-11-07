string first = Console.ReadLine();
string second = Console.ReadLine();
string third = Console.ReadLine();

char firstLetterFromFirstWord = first[0];
char secondLetterFromFirstWord = first[2];
char firstLetterFromSecondWord = second[0];
char secondLetterFromSecondWord = second[2];
char firstLetterFromThirdWord = third[0];
char secondLetterFromThirdWord = third[2];

int won = 0;
int lost = 0;
int drawn = 0;

if (firstLetterFromFirstWord > secondLetterFromFirstWord)
{
    won++;
}
else if (firstLetterFromFirstWord < secondLetterFromFirstWord)
{
    lost++;
}
else
{
    drawn++;
}

if (firstLetterFromSecondWord > secondLetterFromSecondWord)
{
    won++;
}
else if (firstLetterFromSecondWord < secondLetterFromSecondWord)
{
    lost++;
}
else
{
    drawn++;
}

if (firstLetterFromThirdWord > secondLetterFromThirdWord)
{
    won++;
}
else if (firstLetterFromThirdWord < secondLetterFromThirdWord)
{
    lost++;
}
else
{
    drawn++;
}

Console.WriteLine($"Team won {won} games.");
Console.WriteLine($"Team lost {lost} games.");
Console.WriteLine($" Drawn games: {drawn}");




