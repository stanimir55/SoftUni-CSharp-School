int filedTimes = int.Parse(Console.ReadLine());

string lastExercise = string.Empty;
int evoluation;

int evoluationCount = 0;
int evoluationSum = 0;

int filedCount = 0;

string input = Console.ReadLine();

while (input != "Enough")
{
    lastExercise = input;
    evoluation = int.Parse(Console.ReadLine());

    evoluationCount++;
    evoluationSum += evoluation;

    if (evoluation <= 4)
    {
        filedCount++;
        if (filedTimes == filedCount)
        {
            Console.WriteLine($"You need a break, {filedTimes} poor grades.");
            break;
        }
    }

    input = Console.ReadLine();
}

if (input == "Enough")
{
    Console.WriteLine($"Average score: {(double)evoluationSum / evoluationCount:F2}");
    Console.WriteLine($"Number of problems: {evoluationCount}");
    Console.WriteLine($"Last problem: {lastExercise}");
}
