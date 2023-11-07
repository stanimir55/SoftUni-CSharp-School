int n = int.Parse(Console.ReadLine());

string[] firstArr = new string[n];
string[] secondArr = new string[n];

bool isFirstArrSelected = true;

for (int i = 0; i < n; i++)
{
    string numbers = Console.ReadLine();

    string[] numbersArr = numbers.Split().ToArray();

    if (isFirstArrSelected)
    {
        firstArr[i] = numbersArr[0];
        secondArr[i] = numbersArr[1];
    }
    else
    {
        firstArr[i] = numbersArr[1];
        secondArr[i] = numbersArr[0];
    }

    isFirstArrSelected = !isFirstArrSelected;
}

Console.WriteLine(string.Join(" ", firstArr));
Console.WriteLine(string.Join(" ", secondArr));



//int n = int.Parse(Console.ReadLine());

//string[] firstArr = new string[n];
//string[] secondArr = new string[n];

//for (int i = 0; i < n; i++)
//{
//    string numbers = Console.ReadLine();

//    string[] numbersArr = numbers.Split().ToArray();

//    if (i % 2 == 0)
//    {
//        firstArr[i] = numbersArr[0];
//        secondArr[i] = numbersArr[1];
//    }
//    else
//    {
//        firstArr[i] = numbersArr[1];
//        secondArr[i] = numbersArr[0];
//    }
//}

//Console.WriteLine(string.Join(" ", firstArr));
//Console.WriteLine(string.Join(" ", secondArr));

