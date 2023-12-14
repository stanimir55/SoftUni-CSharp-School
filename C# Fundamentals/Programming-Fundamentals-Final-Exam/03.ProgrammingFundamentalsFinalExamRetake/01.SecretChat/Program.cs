string secretMessage = Console.ReadLine();
string commands;

while ((commands = Console.ReadLine()) != "Reveal")
{
    string[] arguments = commands.Split(":|:");

    string command = arguments[0];

    if (command == "InsertSpace")
    {
        int index = int.Parse(arguments[1]);
        secretMessage = secretMessage.Insert(index, " ");
    }
    else if (command == "Reverse")
    {
        string substring = arguments[1];
        int substringIndex = secretMessage.IndexOf(substring);

        if (substringIndex < 0)
        {
            Console.WriteLine("error");
            continue;
        }

        secretMessage = secretMessage.Remove(substringIndex, substring.Length);
        string reversedSubstring = new string(substring.Reverse().ToArray());
        secretMessage += reversedSubstring;
    }
    else if (command == "ChangeAll")
    {
        string substring = arguments[1];
        string replacement = arguments[2];

        secretMessage = secretMessage.Replace(substring, replacement);
    }

    Console.WriteLine(secretMessage);
}

Console.WriteLine($"You have a new text message: {secretMessage}");