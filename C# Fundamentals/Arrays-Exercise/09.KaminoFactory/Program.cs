int lengthOfTheSequences = int.Parse(Console.ReadLine());
int[] bestArray = new int[lengthOfTheSequences];
string input = "";
int counter = 0;
int bestSequenceSum = 0;
int bestNumber = 0;
int startingIndex = 0;
int bestSequence = int.MinValue;

while ((input = Console.ReadLine()) != "Clone them!")
{
    counter++;

    int[] sequenceArray = input
    .Split("!", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
    int sequenceCounter = 0;
    int bestSequenceCounter = 0;
    int sequenceStart = 0;
    int bestStartingIndex = 0;
    int currentSum = 0;

    for (int i = 0; i < sequenceArray.Length; i++)
    {
        if (sequenceArray[i] == 1)
        {
            if (sequenceCounter == 0)
            {
                sequenceStart = i;
            }

            currentSum++;
            sequenceCounter++;
        }

        if (sequenceArray[i] == 0 || i == sequenceArray.Length - 1)
        {
            if (bestSequenceCounter < sequenceCounter)
            {
                bestStartingIndex = sequenceStart;
                bestSequenceCounter = sequenceCounter;
            }

            sequenceCounter = 0;
        }
    }

    if (bestSequenceCounter > bestSequence || (bestSequenceCounter == bestSequence && bestStartingIndex < startingIndex) ||
        (bestSequenceCounter == bestSequence && bestStartingIndex == startingIndex && currentSum > bestSequenceSum))
    {
        bestSequence = bestSequenceCounter;
        bestNumber = counter;
        bestSequenceSum = currentSum;
        startingIndex = bestStartingIndex;
        bestArray = sequenceArray;
    }

}

Console.WriteLine($"Best DNA sample {bestNumber} with sum: {bestSequenceSum}.");
Console.WriteLine(string.Join(" ", bestArray));
