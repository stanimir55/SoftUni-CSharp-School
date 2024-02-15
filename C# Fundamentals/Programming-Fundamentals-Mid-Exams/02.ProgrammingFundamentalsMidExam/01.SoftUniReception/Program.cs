int studentsNumberFirstEmployee = int.Parse(Console.ReadLine());
int studentsNumberSecondEmployee = int.Parse(Console.ReadLine());
int studentsNumberThirdEmployee = int.Parse(Console.ReadLine());
int studentsNumber = int.Parse(Console.ReadLine());

int answerPerHour = studentsNumberFirstEmployee + studentsNumberSecondEmployee + studentsNumberThirdEmployee;
int nededHours = 0;

while (studentsNumber > 0)
{
    studentsNumber -= answerPerHour;
    nededHours++;

    if (nededHours % 4 == 0)
    {
        nededHours++;
    }
}

Console.WriteLine($"Time needed: {nededHours}h.");
