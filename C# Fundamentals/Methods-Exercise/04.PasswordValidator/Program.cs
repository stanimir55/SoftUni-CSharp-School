string password = Console.ReadLine();

int counterDigits = 0;
bool lenght = false;
bool twoDigits = false;
bool letterDigits = true;

lenght = PasswordMustBeBetween(password, lenght);

for (int i = 0; i < password.Length; i++)
{
    char current = password[i];

    if ((int)current >= 48 && (int)current <= 57)
    {
        counterDigits++;
    }

    letterDigits = PasswordMustlettersAndDigits(letterDigits, current);
}

if (letterDigits == false)
{
    Console.WriteLine("Password must consist only of letters and digits");
}

twoDigits = PasswordMustTwoDigits(counterDigits, twoDigits);

if (lenght && twoDigits && letterDigits)
{
    Console.WriteLine("Password is valid");
}

static bool PasswordMustBeBetween(string password, bool lenght)
{
    if (password.Length >= 6 && password.Length <= 10)
    {
        lenght = true;
    }
    else
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }

    return lenght;
}
static bool PasswordMustlettersAndDigits(bool letterDigits, char current)
{
    if ((int)current < 48 || (int)current > 122 || ((int)current > 90 && (int)current < 97) ||
        ((int)current > 57 && (int)current < 65))
    {
        letterDigits = false;
    }

    return letterDigits;
}

static bool PasswordMustTwoDigits(int counterDigits, bool twoDigits)
{
    if (counterDigits < 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
    else if (counterDigits >= 2)
    {
        twoDigits = true;
    }

    return twoDigits;
}