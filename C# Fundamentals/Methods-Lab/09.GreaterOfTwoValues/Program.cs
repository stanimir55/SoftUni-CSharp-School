string type = Console.ReadLine();

GetMaxAndPrintResult(type);

static void GetMaxAndPrintResult(string input)
{
    switch (input)
    {
        case "int":
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
            break;
        case "char":
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            if (firstSymbol > secondSymbol)
            {
                Console.WriteLine(firstSymbol);
            }
            else if (firstSymbol < secondSymbol)
            {
                Console.WriteLine(secondSymbol);
            }
            break;
        case "string":
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if (firstValue.CompareTo(secondValue) > secondValue.CompareTo(firstValue))
            {
                Console.WriteLine(firstValue);
            }
            else
            {
                Console.WriteLine(secondValue);
            }
            break;
    }
}