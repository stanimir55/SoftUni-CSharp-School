string command = "";

while ((command = Console.ReadLine()) != "END")
{
    bool isNumberPalindrome = IsPalindrome(command);

    Console.WriteLine(isNumberPalindrome);
}

static bool IsPalindrome(string symbols)
{
    int left = 0;
    int right = symbols.Length - 1;

    while (left < right)
    {
        if (symbols[left] != symbols[right])
        {
            return false;
        }

        left++;
        right--;
    }

    return true;
}