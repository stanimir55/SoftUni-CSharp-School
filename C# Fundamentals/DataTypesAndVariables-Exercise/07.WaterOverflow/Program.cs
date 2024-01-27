int numberOfLines = int.Parse(Console.ReadLine());
int tankCapacity = 0;

for (int i = 0; i < numberOfLines; i++)
{
    int quantitiesOfWater = int.Parse(Console.ReadLine());

    if (tankCapacity + quantitiesOfWater <= 255)
    {
        tankCapacity += quantitiesOfWater;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }
}

Console.WriteLine(tankCapacity);