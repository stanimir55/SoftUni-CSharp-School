int n = int.Parse(Console.ReadLine());

int sumVowels = 0;
int sumConsonant = 0;
int sum = 0;

string vowels = "AaOoEeUuIi";

int[] arrayOfSums = new int[n];

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();

    for (int k = 0; k < name.Length; k++)
    {
        char letter = name[k];

        if (letter == 'A' || letter == 'a' || letter == 'O' || letter == 'o' || letter == 'E' ||
            letter == 'e' || letter == 'U' || letter == 'u' || letter == 'I' || letter == 'i')
        {
            sumVowels += letter * name.Length;
        }
        else
        {
            sumConsonant += letter / name.Length;
        }
    }
    sum = sumVowels + sumConsonant;
    arrayOfSums[i] = sum;

    sumVowels = 0;
    sumConsonant = 0;
    sum = 0;

}

Array.Sort(arrayOfSums);
for (int k = 0; k < arrayOfSums.Length; k++)
{
    Console.WriteLine(arrayOfSums[k]);
}
