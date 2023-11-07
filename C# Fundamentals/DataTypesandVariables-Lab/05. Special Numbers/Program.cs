int num = int.Parse(Console.ReadLine());
bool isSpecial = false;

for (int i = 1; i <= num; i++)
{
    int number = i;
    int sum = 0;

    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    if (sum == 5 || sum == 7 || sum == 11)
    {
        isSpecial = true;
    }
    else
    {
        isSpecial = false;
    }

    Console.WriteLine($"{i} -> {isSpecial}");
}


//int num = int.Parse(Console.ReadLine());

//for (int i = 1; i <= num; i++)
//{
//    int lastDigit = i % 10;
//    int middleDigit = (i / 10) % 10;
//    int firstDigit = middleDigit / 10;

//    int sum = lastDigit + middleDigit + firstDigit;

//    if (sum == 5 || sum == 7 || sum == 11)
//    {
//        Console.WriteLine($"{i} -> True");
//    }
//    else
//    {
//        Console.WriteLine($"{i} -> False");
//    }
//}

