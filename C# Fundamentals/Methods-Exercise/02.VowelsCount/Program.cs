string str = Console.ReadLine();

PrintsNumberOfVowels(str);

static void PrintsNumberOfVowels(string str)
{
    int vowels = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == 'A' || str[i] == 'a' || str[i] == 'E' || str[i] == 'e' || str[i] == 'I' ||
            str[i] == 'i' || str[i] == 'O' || str[i] == 'o' || str[i] == 'U' || str[i] == 'u')
        {
            vowels++;
        }
    }

    Console.WriteLine(vowels);
}


//string str = Console.ReadLine();

//int vowels = 0;

//for (int i = 0; i < str.Length; i++)
//{
//    if (str[i] == 'A' || str[i] == 'a' || str[i] == 'E' || str[i] == 'e' || str[i] == 'I' ||
//        str[i] == 'i' || str[i] == 'O' || str[i] == 'o' || str[i] == 'U' || str[i] == 'u')
//    {
//        vowels++;
//    }
//}

//Console.WriteLine(vowels);