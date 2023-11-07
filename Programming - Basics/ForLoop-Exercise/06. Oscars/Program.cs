string actorName = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

string nameEvaluative;
double evaluativePoints;

for (int i = 1; i <= n; i++)
{
    nameEvaluative = Console.ReadLine();
    evaluativePoints = double.Parse(Console.ReadLine());

    academyPoints += nameEvaluative.Length * evaluativePoints / 2;

    if (academyPoints >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:F1}!");
        break;
    }

}

if (academyPoints < 1250.5)
{
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - academyPoints:F1} more!");
}


