int[] keys = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

string command;

while ((command = Console.ReadLine()) != "find")
{
    string decrypted = "";
    int counter = 0;

    for (int i = 0; i < command.Length; i++)
    {
        int currentChar = command[i] - keys[counter];
        counter++;

        if (counter == keys.Length)
        {
            counter = 0;
        }

        decrypted += (char)currentChar;
    }

    int startIndexType = decrypted.IndexOf('&') + 1;
    int endIndexType = decrypted.LastIndexOf('&');
    string type = decrypted.Substring(startIndexType, endIndexType - startIndexType);

    int startIndexCoordinates = decrypted.IndexOf('<') + 1;
    int endIndexCoordinates = decrypted.LastIndexOf('>');
    string coordinates = decrypted.Substring(startIndexCoordinates, endIndexCoordinates - startIndexCoordinates);

    Console.WriteLine($"Found {type} at {coordinates}");
}