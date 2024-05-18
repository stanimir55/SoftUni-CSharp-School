int linesCount = int.Parse(Console.ReadLine());
string text = "";
Stack<string> state = new Stack<string>();

for (int i = 0; i < linesCount; i++)
{
    string[] arguments = Console.ReadLine().Split();
    string commandName = arguments[0];

    switch (commandName)
    {
        case "1":
            state.Push(text);
            text += arguments[1];
            break;
        case "2":
            state.Push(text);
            int count = int.Parse(arguments[1]);
            text = text.Substring(0, text.Length - count);
            break;
        case "3":
            int index = int.Parse(arguments[1]);
            Console.WriteLine(text[index - 1]);
            break;
        case "4":
            text = state.Pop();
            break;
    }
}