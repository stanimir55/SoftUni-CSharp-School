string[] elementOne = Console.ReadLine()
    .Split()
    .ToArray();

string[] elementTwo = Console.ReadLine()
    .Split()
    .ToArray();

string commonElements = "";

for (int i = 0; i < elementTwo.Length; i++)
{
    for (int k = 0; k < elementOne.Length; k++)
    {
        if (elementTwo[i] == elementOne[k])
        {
            commonElements += elementTwo[i] + " ";
        }
    }
}
Console.WriteLine(commonElements);
