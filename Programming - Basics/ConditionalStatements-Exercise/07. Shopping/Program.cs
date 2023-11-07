double budgetPeter = double.Parse(Console.ReadLine());
int numVideoCard = int.Parse(Console.ReadLine());
int numProcessor = int.Parse(Console.ReadLine());
int numRam = int.Parse(Console.ReadLine());

int videoCard = numVideoCard * 250;
double processor = numProcessor * videoCard * 0.35;
double ram = numRam * videoCard * 0.1;

double tottalSum = videoCard + processor + ram;
if (numVideoCard > numProcessor)
{
    tottalSum = tottalSum - tottalSum * 0.15;
}

if (budgetPeter >= tottalSum)
{
    Console.WriteLine($"You have {Math.Abs(budgetPeter - tottalSum):F2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(budgetPeter - tottalSum):F2} leva more!");
}



