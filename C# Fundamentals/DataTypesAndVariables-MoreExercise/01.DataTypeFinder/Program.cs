﻿string input;
int valueInteger;
float valueFloat;
char valueCharacter;
bool valueBoolean;

while ((input = Console.ReadLine()) != "END")
{
    if (int.TryParse(input, out valueInteger))
    {
        Console.WriteLine($"{input} is integer type");
    }
    else if (float.TryParse(input, out valueFloat))
    {
        Console.WriteLine($"{input} is floating point type");
    }
    else if (char.TryParse(input, out valueCharacter))
    {
        Console.WriteLine($"{input} is character type");
    }
    else if (bool.TryParse(input, out valueBoolean))
    {
        Console.WriteLine($"{input} is boolean type");
    }
    else
    {
        Console.WriteLine($"{input} is string type");
    }
}
