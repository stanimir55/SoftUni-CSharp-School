List<int> list = Console.ReadLine()
    .Split('@')
    .Select(int.Parse)
    .ToList();

List<int> result = new List<int>(list);

string commands;
int lastPosition = 0;
int houseCount = 0;
int index = 0;

while ((commands = Console.ReadLine()) != "Love!")
{
    string[] arguments = commands.Split().ToArray();

    if (arguments[0] == "Jump")
    {
        index += int.Parse(arguments[1]);

        if (index > list.Count - 1)
        {
            index = 0;
        }
        if (list[index] == 0)
        {
            Console.WriteLine($"Place {index} already had Valentine's day.");
        }
        else
        {
            list[index] -= 2;

            if (list[index] == 0)
            {
                Console.WriteLine($"Place {index} has Valentine's day.");
            }
        }

        lastPosition = index;
    }
}

Console.WriteLine($"Cupid's last position was {lastPosition}.");

int counter = list.Count(x => x > 0);

if (list.Sum() == 0)
{
    Console.WriteLine($"Mission was successful.");
}
else
{
    Console.WriteLine($"Cupid has failed {counter} places.");
}
