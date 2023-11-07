int n = int.Parse(Console.ReadLine());

int watertank = 255;
int counter = 0;

for (int i = 1; i <= n ; i++)
{
    int waterLiters = int.Parse(Console.ReadLine());
   
    if (counter + waterLiters > watertank)
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        counter += waterLiters;
    }
}

Console.WriteLine(counter);