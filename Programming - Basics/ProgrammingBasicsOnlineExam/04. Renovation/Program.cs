int wallHeight = int.Parse(Console.ReadLine());
int wallWidth = int.Parse(Console.ReadLine());
int wallPercentNoPaint = int.Parse(Console.ReadLine());

double total = 0;
double wallsPaint = 0;

total = wallHeight * wallWidth * 4;
total -= total * wallPercentNoPaint * 0.01;

while(true)
{
    string stop = Console.ReadLine();

    if (stop == "Tired!")
    {
        Console.WriteLine($"{total} quadratic m left.");
        return;
    }

    wallsPaint = int.Parse(stop);
    total -= wallsPaint;

    if (total == 0)
    {
        Console.WriteLine($"All walls are painted! Great job, Pesho!");
        return;
    }
    else if (total < 0)
    {
        Console.WriteLine($"All walls are painted and you have {Math.Abs(total)} l paint left!" );
        return;
    }
    
}
