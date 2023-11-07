int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    char firstChar = (char)('a' + i);

    for (int k = 0; k < n; k++)
    {
        char secondChar = (char)('a' + k);

        for (int m = 0; m < n; m++)
        {
         char threeChar = (char)('a' + m);
         Console.WriteLine($"{firstChar}{secondChar}{threeChar}");
        }
    }

}