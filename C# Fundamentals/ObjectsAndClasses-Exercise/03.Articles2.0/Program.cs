List<Article> articles = new List<Article>();

int numberOfCommands = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfCommands; i++)
{
    string[] articleStr = Console.ReadLine()
    .Split(", ")
    .ToArray();

    Article article = new Article(articleStr[0], articleStr[1], articleStr[2]);

    Console.WriteLine(article);
}

//Console.WriteLine(string.Join("\n", articles));

class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }

    public string Content { get; set; }

    public string Author { get; set; }


    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}

