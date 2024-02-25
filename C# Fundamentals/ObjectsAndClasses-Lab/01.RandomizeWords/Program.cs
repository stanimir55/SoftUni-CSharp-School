string[] words = Console.ReadLine().Split();

Random random = new Random();

for (int i = 0; i < words.Length; i++)
{
    int currentIndex = random.Next(words.Length);
    string currentWord = words[i];
    string randomWord = words[currentIndex];

    words[i] = randomWord;
    words[currentIndex] = currentWord;
}

for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words[i]);
}