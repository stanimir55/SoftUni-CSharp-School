string[] input = Console.ReadLine().Split();
Stack<string> stack = new Stack<string>();
int sum = 0;
string element = "";

foreach (var item in input)
{
    stack.Push(item);
}

string[] strings = stack.ToArray();

for (int i = strings.Length - 1; i >= 0; i--)
{
    element = strings[i];

    if (element == "+")
    {
        sum += int.Parse(strings[i - 1]);
        i--;
    }
    else if (element == "-")
    {
        sum -= int.Parse(strings[i - 1]);
        i--;
    }
    else
    {
        sum += int.Parse(element);
    }
}

Console.WriteLine(sum);
