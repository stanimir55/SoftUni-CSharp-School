List<string> elements = Console.ReadLine()
    .Split()
    .ToList();

string command;
int counter = 0;

while ((command = Console.ReadLine()) != "end")
{
    counter++;
    List<string> indexes = command.Split().ToList();

    int indexOne = int.Parse(indexes[0]);
    int indexTwo = int.Parse(indexes[1]);

    if (indexOne >= 0 && indexTwo >= 0 && indexOne < elements.Count && indexTwo < elements.Count && indexOne != indexTwo)
    {
        if (elements[indexOne] == elements[indexTwo])
        {
            Console.WriteLine($"Congrats! You have found matching elements - {elements[indexOne]}!");

            if (indexOne > indexTwo)
            {
                elements.RemoveAt(indexOne);
                elements.RemoveAt(indexTwo);
            }
            else
            {
                elements.RemoveAt(indexTwo);
                elements.RemoveAt(indexOne);
            }

            if (elements.Count == 0)
            {
                Console.WriteLine($"You have won in {counter} turns!");
                return;
            }
        }
        else if (elements[indexOne] != elements[indexTwo])
        {
            Console.WriteLine("Try again!");
        }
    }
    else
    {
        elements.Insert(elements.Count / 2, $"-{counter}a");
        elements.Insert(elements.Count / 2, $"-{counter}a");

        Console.WriteLine("Invalid input! Adding additional elements to the board");
    }
}

Console.WriteLine("Sorry you lose :(");
Console.WriteLine(string.Join(" ", elements));