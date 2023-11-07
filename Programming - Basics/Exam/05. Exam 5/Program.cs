int startHeight = 5364;
int target = 8848;
int currentHeight = 0;
int count = 1;

string end = "";
while (end != "END")
{
    string yesOrNo = Console.ReadLine();

    if (yesOrNo == "END")
    {
        break;
    }
    if (yesOrNo == "Yes")
    {
        count++;
    }
    else
    {
        currentHeight ++;
    }

    int height = int.Parse(Console.ReadLine());
    currentHeight += height;

    if (currentHeight + startHeight >= target)
    {
        break;
    }
    if (count == 5)
    {
        break;
    }
}

int total = startHeight + currentHeight;
if (total < target) 
{
    Console.WriteLine("Failed!");
    Console.WriteLine($"{startHeight + currentHeight}");
}
if (total >= target)
{
    Console.WriteLine($"Goal reached for {count} days!");
}
