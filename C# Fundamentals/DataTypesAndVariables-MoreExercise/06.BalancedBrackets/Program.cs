
int linesCount = int.Parse(Console.ReadLine());
bool isOpened = false;
bool isBalanced = true;

for (int i = 0; i < linesCount; i++)
{
    string input = Console.ReadLine();

    if (input == "(")
    {
        if (!isOpened)
        {
            isOpened = true;
        }
        else
        {
            isBalanced = false;
        }
    }
    else if (input == ")")
    {
        if (isOpened)
        {
            isOpened = false;
        }
        else
        {
            isBalanced = false;
        }
    }
}

if (isBalanced && !isOpened)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}

