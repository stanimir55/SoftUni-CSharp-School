string text = Console.ReadLine().ToLower();
int vowelsCounter = 0;

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
    {
        vowelsCounter++;
    }
}

PrintVowelsCount(vowelsCounter);

static void PrintVowelsCount(int vowelsCounter)
{
    Console.WriteLine(vowelsCounter);
}
