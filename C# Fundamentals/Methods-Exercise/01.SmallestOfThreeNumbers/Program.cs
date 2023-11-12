int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

SmallestОfThreeNumbers(firstNumber, secondNumber, thirdNumber);

static void SmallestОfThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
{
    if (firstNumber < secondNumber && firstNumber < thirdNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else if (secondNumber < firstNumber && secondNumber < thirdNumber)
    {
        Console.WriteLine(secondNumber);
    }
    else
    {
        Console.WriteLine(thirdNumber);
    }
}


//int firstNumber = int.Parse(Console.ReadLine());
//int secondNumber =int.Parse(Console.ReadLine());
//int thirdNumber = int.Parse(Console.ReadLine());

//if (firstNumber < secondNumber && firstNumber < thirdNumber)
//{
//    Console.WriteLine(firstNumber);
//}
//else if (secondNumber < firstNumber && secondNumber < thirdNumber)
//{
//    Console.WriteLine(secondNumber);
//}
//else
//{
//    Console.WriteLine(thirdNumber);
//}
