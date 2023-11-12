int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

double firstFacturial = 1;
double secondFacturial = 1;

firstFacturial = CalculateFirstFactorial(firstNumber, firstFacturial);

secondFacturial = CalculateSecondFactorial(secondNumber, secondFacturial);

ResulOofTheDivision(firstFacturial, secondFacturial);

static double CalculateFirstFactorial(int firstNumber, double firstFacturial)
{
    for (int i = 1; i <= firstNumber; i++)
    {
        firstFacturial *= i;
    }

    return firstFacturial;
}

static double CalculateSecondFactorial(int secondNumber, double secondFacturial)
{
    for (int i = 1; i <= secondNumber; i++)
    {
        secondFacturial *= i;
    }

    return secondFacturial;
}

static void ResulOofTheDivision(double firstFacturial, double secondFacturial)
{
    Console.WriteLine($"{firstFacturial / secondFacturial:F2}");
}


//int firstNumber = int.Parse(Console.ReadLine());
//int secondNumber = int.Parse(Console.ReadLine());

//double firstFacturial = 1;
//double secondFacturial = 1;

//for (int i = 1; i <= firstNumber; i++)
//{
//    firstFacturial *= i;
//}

//for (int i = 1; i <= secondNumber; i++)
//{
//    secondFacturial *= i;
//}

//Console.WriteLine($"{firstFacturial / secondFacturial:F2}");


