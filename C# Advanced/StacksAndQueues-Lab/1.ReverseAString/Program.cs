string input = Console.ReadLine();

Stack<char> chars = new Stack<char>();

foreach (var ch in input)
{
    chars.Push(ch);
}

while (chars.Count > 0)
{
    Console.Write(chars.Pop());
}