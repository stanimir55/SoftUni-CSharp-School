string country = Console.ReadLine();
string tool = Console.ReadLine();

double evaluationA = 0;
double evaluationB = 0;
double total = 0;
if (country == "Russia")
{
    if (tool == "ribbon")
    {
        evaluationA = 9.100;
        evaluationB = 9.400;
        total = evaluationA + evaluationB;
    }
    else if (tool == "hoop")
    {
        evaluationA = 9.300;
        evaluationB = 9.800;
        total = evaluationA + evaluationB;
    }
    else if (tool == "rope")
    {
        evaluationA = 9.600;
        evaluationB = 9.000;
        total = evaluationA + evaluationB;
    }
}
else if (country == "Bulgaria")
{
    if (tool == "ribbon")
    {
        evaluationA = 9.600;
        evaluationB = 9.400;
        total = evaluationA + evaluationB;
    }
    else if (tool == "hoop")
    {
        evaluationA = 9.550;
        evaluationB = 9.750;
        total = evaluationA + evaluationB;
    }
    else if (tool == "rope")
    {
        evaluationA = 9.500;
        evaluationB = 9.400;
        total = evaluationA + evaluationB;
    }
}
else if (country == "Italy")
{
    if (tool == "ribbon")
    {
        evaluationA = 9.200;
        evaluationB = 9.500;
        total = evaluationA + evaluationB;
    }
    else if (tool == "hoop")
    {
        evaluationA = 9.450;
        evaluationB = 9.350;
        total = evaluationA + evaluationB;
    }
    else if (tool == "rope")
    {
        evaluationA = 9.700;
        evaluationB = 9.150;
        total = evaluationA + evaluationB;
    }
}

double evaluationJury = 20 - total;
double percent = evaluationJury * 100 / 20;
Console.WriteLine($"The team of {country} get {total:F3} on {tool}.");
Console.WriteLine($"{percent:F2}%");
