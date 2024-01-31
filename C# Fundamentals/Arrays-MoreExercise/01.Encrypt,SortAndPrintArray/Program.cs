int linesCount = int.Parse(Console.ReadLine());
int[] sums = new int[linesCount];

for (int i = 0; i < linesCount; i++)
{
    string name = Console.ReadLine();
    int vowelSum = 0;
    int consonantSum = 0;
    int totalSum = 0;

    for (int k = 0; k < name.Length; k++)
    {
        char letter = name[k];

        if (letter == 'A' || letter == 'a' || letter == 'O' || letter == 'o' || letter == 'E' ||
            letter == 'e' || letter == 'U' || letter == 'u' || letter == 'I' || letter == 'i')
        {
            vowelSum += letter * name.Length;
        }
        else
        {
            consonantSum += letter / name.Length;
        }
    }

    totalSum = vowelSum + consonantSum;
    sums[i] = totalSum;
}

Array.Sort(sums);

for (int i = 0; i < sums.Length; i++)
{
    Console.WriteLine(sums[i]);
}

