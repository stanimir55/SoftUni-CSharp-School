string input = Console.ReadLine();

string commands;
while ((commands = Console.ReadLine()) != "Decode")
{
    string[] arguments = commands.Split("|");

    switch (arguments[0])
    {
        case "Move":
            int numberOfLetters = int.Parse(arguments[1]);
            string result = input.Substring(0, numberOfLetters);
            input = input.Remove(0, numberOfLetters);
            input += result;
            break;
        case "Insert":
            int index = int.Parse(arguments[1]);
            string value = arguments[2];
            input = input.Insert(index, value);
            break;
        case "ChangeAll":
            string substring = arguments[1];
            string replacement = arguments[2];
            input = input.Replace(substring, replacement);
            break;
    }
}

Console.WriteLine($"The decrypted message is: {input}");