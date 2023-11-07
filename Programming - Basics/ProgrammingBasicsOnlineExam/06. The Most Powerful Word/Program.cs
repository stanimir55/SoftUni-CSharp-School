string word = Console.ReadLine();
string end = "End of words";
double sum = 0;
double result = 0;
double maxResult = double.MinValue;
double letter = 0;
string powerWord = "";
while (word != end)
{
    for (int i = 0; i < word.Length; i++)
    {
        letter = word[i];
        sum = sum + letter;
    }

    if (word[0] == 'a' || word[0] == 'A' || word[0] == 'e' || word[0] == 'E' || word[0] == 'i' || word[0] == 'I' || word[0] == 'o' || word[0] == 'O' || word[0] == 'u' || word[0] == 'U' || word[0] == 'y' || word[0] == 'Y')
    {
        result = sum * word.Length;
    }
    else
    {
        result = Math.Floor(sum / word.Length);
    }

    if (result > maxResult)
    {
        maxResult = result;
        powerWord = word;
    }
    sum = 0;
    result = 0;
    word = Console.ReadLine();

}

if (word == end)
{
    Console.WriteLine($"The most powerful word is {powerWord} - {maxResult}");

}
