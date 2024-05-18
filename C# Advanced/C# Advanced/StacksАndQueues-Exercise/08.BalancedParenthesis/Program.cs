string input = Console.ReadLine();
Stack<char> stack = new Stack<char>();
bool isBalanced = true;
foreach (char c in input)
{
    if (c == '(' || c == '{' || c == '[')
    {
        stack.Push(c); 
        continue;
    }

    bool canPop = stack.TryPeek(out char currentChar);

    if (canPop && ((c == ')' && stack.Count != 0 && stack.Peek() == '(') ||
        (c == '}' && stack.Count != 0 && stack.Peek() == '{') ||
        (c == ']' && stack.Count != 0 && stack.Peek() == '[')))
    {
        stack.Pop();
    }
    else
    {
        isBalanced = false;
        break;
    }
}

Console.WriteLine(isBalanced ? "YES" : "NO");
