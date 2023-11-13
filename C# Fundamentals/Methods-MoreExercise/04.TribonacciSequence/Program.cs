int number = int.Parse(Console.ReadLine());

int[] numberSequence = new int[3];

numberSequence[0] = 0;
numberSequence[1] = 0;
numberSequence[2] = 1;

if (number > 0)
{
    Console.Write(1 + " ");
}

for (int i = number; i > 1; --i)
{
    int num = numberSequence[0] + numberSequence[1] + numberSequence[2];

    Console.Write(num + " ");

    numberSequence[0] = numberSequence[1];
    numberSequence[1] = numberSequence[2];
    numberSequence[2] = num;
}