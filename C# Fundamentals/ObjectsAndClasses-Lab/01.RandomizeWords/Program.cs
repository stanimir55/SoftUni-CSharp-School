string[] words = Console.ReadLine()
    .Split();

Random random = new Random();

for (int i = 0; i < words.Length; i++)
{
    int randomIndex = random.Next(words.Length);

    string currentWord = words[i];
    string randomWord = words[randomIndex];

    words[i] = randomWord;
    words[randomIndex] = currentWord;
}

foreach (var word in words)
{
    Console.WriteLine(word);
}

//Console.WriteLine(string.Join(Environment.NewLine, words));