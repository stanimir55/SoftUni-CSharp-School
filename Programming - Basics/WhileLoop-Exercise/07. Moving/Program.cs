int widthOfSpace = int.Parse(Console.ReadLine());
int lengthOfSpace = int.Parse(Console.ReadLine());
int heigthOfSpace = int.Parse(Console.ReadLine());

int total = widthOfSpace * lengthOfSpace * heigthOfSpace;

for (int i = 0; i < 1000000; i++)
{
    string done = Console.ReadLine();
    if (done == "Done")
    {
        Console.WriteLine("{0} Cubic meters left.", Math.Abs(total));
        break;
    }
    int parts = int.Parse(done);
    total = total - parts;

    if (total < 0)
    {
        Console.WriteLine("No more free space! You need {0} Cubic meters more.", Math.Abs(total)); break;
    }

}