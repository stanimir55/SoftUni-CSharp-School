int sizeOfTheField = int.Parse(Console.ReadLine());
int[] indexesAllLadybugs = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] field = new int[sizeOfTheField];

for (int i = 0; i < indexesAllLadybugs.Length; i++)
{
    int bugIndex = indexesAllLadybugs[i];

    if (bugIndex >= 0 && bugIndex < field.Length)
    {
        field[bugIndex] = 1;
    }
}

string command = "";

while ((command = Console.ReadLine()) != "end")
{
    string[] elements = command.Split();

    int bugIndex = int.Parse(elements[0]);
    string direction = elements[1];
    int flyLenght = int.Parse(elements[2]);

    if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0)
    {
        continue;
    }

    field[bugIndex] = 0;
    int landIndex = 0;
    if (direction == "right")
    {
        landIndex = bugIndex + flyLenght;

        if (landIndex > field.Length - 1)
        {
            continue;
        }

        while (field[landIndex] == 1)
        {
            landIndex += flyLenght;

            if (landIndex > field.Length - 1)
            {
                break;
            }
        }
        
        if (landIndex <= field.Length - 1)
        {
            field[landIndex] = 1;
        }
    }
    else if (direction == "left")
    {
        landIndex = bugIndex - flyLenght;

        if (landIndex < 0)
        {
            continue;
        }

        while (field[landIndex] == 1)
        {
            landIndex -= flyLenght;

            if (landIndex < 0)
            {
                break;
            }
        }
        

        if (landIndex >= 0)
        {
            field[landIndex] = 1;
        }
    }
}

Console.WriteLine(string.Join(" ", field));
