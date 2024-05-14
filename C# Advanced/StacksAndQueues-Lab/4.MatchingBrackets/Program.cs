string expression = Console.ReadLine();

Stack<int> openingBrackets = new Stack<int>();

for (int i = 0; i < expression.Length; i++)
{
    if (expression[i] == '(')
    {
        openingBrackets.Push(i);
    }
    else if (expression[i] == ')')
    {
        int openingBracketsIndex = openingBrackets.Pop();

        Console.WriteLine(expression.Substring(openingBracketsIndex, i - openingBracketsIndex + 1));
    }
}
