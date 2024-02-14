string encryptedMessage = Console.ReadLine();

List<string> text = new List<string>();
List<int> numbers = new List<int>();
List<int> takeList = new List<int>();
List<int> skipList = new List<int>();

string decryptedMessage = "";

for (int i = 0; i < encryptedMessage.Length; i++)
{
    if (char.IsDigit(encryptedMessage[i]))
    {
        numbers.Add(int.Parse(encryptedMessage[i].ToString()));
    }
    else
    {
        text.Add(encryptedMessage[i].ToString());
    }
}

for (int i = 0; i < numbers.Count; i++)
{
    if (i % 2 == 0)
    {
        takeList.Add(numbers[i]);
    }
    else
    {
        skipList.Add(numbers[i]);
    }
}

int index = 0;

for (int i = 0; i < takeList.Count; i++)
{
    int take = takeList[i];
    int skipe = skipList[i];

    if (index + take > text.Count)
    {
        take = text.Count - index;
    }

    for (int k = 0; k < take; k++)
    {
        decryptedMessage += text[index + k];
    }

    index += take + skipe;
}

Console.WriteLine(decryptedMessage);
