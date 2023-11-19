List<int> listNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int sum = 0;
int removedElement = 0;

while (listNumbers.Count != 0)
{
    int index = int.Parse(Console.ReadLine());

    int lastElement = listNumbers[listNumbers.Count - 1];
    int firstElement = listNumbers[0];

    if (index < 0)
    {
        removedElement = firstElement;
        listNumbers.RemoveAt(0);
        listNumbers.Insert(0, lastElement);
    }
    else if (index > listNumbers.Count - 1)
    {
        removedElement = lastElement;
        listNumbers.RemoveAt(listNumbers.Count - 1);
        listNumbers.Add(firstElement);
    }
    else
    {
        removedElement = listNumbers[index];
        listNumbers.RemoveAt(index);
    }

    //int removedElement = listNumbers[index];
    sum += removedElement;

    for (int i = 0; i < listNumbers.Count; i++)
    {
        int currentNumber = listNumbers[i];

        if (currentNumber <= removedElement)
        {
            currentNumber += removedElement;
            listNumbers[i] = currentNumber;
        }
        else
        {
            currentNumber -= removedElement;
            listNumbers[i] = currentNumber;
        }
    }
}

Console.WriteLine(sum);


//List<int> listNumbers = Console.ReadLine()
//    .Split()
//    .Select(int.Parse)
//    .ToList();

//int sum = 0;

//while (listNumbers.Count > 0)
//{
//    int index = int.Parse(Console.ReadLine());

//    if (index < 0)
//    {
//        listNumbers.Remove(listNumbers[0]);
//        listNumbers.Insert(0, listNumbers[listNumbers.Count - 1]);
//        index = listNumbers.Count - 1;
//    }
//    else if (index > listNumbers.Count - 1)
//    {
//        listNumbers.Remove(listNumbers.Count - 1);
//        listNumbers.Add(listNumbers[0]);
//        index = listNumbers.Count - 1;
//    }

//    int indexValue = listNumbers[index];
//    sum += indexValue;

//    for (int i = 0; i < listNumbers.Count; i++)
//    {
//        if (listNumbers[i] <= indexValue)
//        {
//            listNumbers[i] += indexValue;
//        }
//        else if (listNumbers[i] > indexValue)
//        {
//            listNumbers[i] -= indexValue;
//        }
//    }

//    listNumbers.RemoveAt(index);
//}

//Console.WriteLine(sum);
