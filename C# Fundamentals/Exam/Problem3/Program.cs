List<string> cardsList = Console.ReadLine()
    .Split(", ")
    .ToList();
int linesCount = int.Parse(Console.ReadLine());

for (int i = 0; i < linesCount; i++)
{
    List<string> commands = Console.ReadLine()
    .Split(", ")
    .ToList();

    switch (commands[0])
    {
        case "Add":
            if (!cardsList.Contains(commands[1]))
            {
                cardsList.Add(commands[1]);
                Console.WriteLine("Card successfully added");
            }
            else
            {
                Console.WriteLine("Card is already in the deck");
            }
            break;
        case "Remove":
            if (cardsList.Contains(commands[1]))
            {
                cardsList.Remove(commands[1]);
                Console.WriteLine("Card successfully removed");
            }
            else
            {
                Console.WriteLine("Card not found");
            }
            break;
        case "Remove At":
            if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < cardsList.Count)
            {
                cardsList.RemoveAt(int.Parse(commands[1]));
                Console.WriteLine("Card successfully removed");
            }
            else
            {
                Console.WriteLine("Index out of range");
            }
            break;
        case "Insert":
            if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < cardsList.Count && cardsList.Contains(commands[2]))
            {
                Console.WriteLine("Card is already added");
                continue;
            }
            if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < cardsList.Count)
            {
                cardsList.Insert(int.Parse(commands[1]), commands[2]);
                Console.WriteLine("Card successfully added");
            }
            else
            {
                Console.WriteLine("Index out of range");
            }
            break;
    }
}

Console.WriteLine(string.Join(", ", cardsList));