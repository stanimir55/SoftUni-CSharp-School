int peopleOnJury = int.Parse(Console.ReadLine());
string presentation = Console.ReadLine();

int presentationNum = 0;
double gradesNum = 0;
string presentationName;

while (presentation != "Finish")
{
    double presentationEv = 0;
    presentationName = presentation;
    for (int i = 1; i <= peopleOnJury; i++)
    {
        presentationEv += double.Parse(Console.ReadLine());
    }

    presentationEv = presentationEv / peopleOnJury;
    gradesNum += presentationEv;

    Console.WriteLine($"{presentationName} - {presentationEv:F2}.");
    presentationNum++;
    presentation = Console.ReadLine();
}

Console.WriteLine($"Student's final assessment is {gradesNum / presentationNum:F2}.");