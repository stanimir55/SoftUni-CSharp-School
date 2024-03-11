using System.Text;

string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

StringBuilder sb = new StringBuilder();

var morseCodeDictionary = new Dictionary<char, string>()
{
    {'A', ".-"},
    {'B', "-..."},
    {'C', "-.-."},
    {'D', "-.."},
    {'E', "."},
    {'F', "..-."},
    {'G', "--."},
    {'H', "...."},
    {'I', ".."},
    {'J', ".---"},
    {'K', "-.-"},
    {'L', ".-.."},
    {'M', "--"},
    {'N', "-."},
    {'O', "---"},
    {'P', ".--."},
    {'Q', "--.-"},
    {'R', ".-."},
    {'S', "..."},
    {'T', "-"},
    {'U', "..-"},
    {'V', "...-"},
    {'W', ".--"},
    {'X', "-..-"},
    {'Y', "-.--"},
    {'Z', "--.."},
};

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == "|")
    {
        sb.Append(" ");
    }

    foreach (var kvp in morseCodeDictionary)
    {
        if (input[i] == kvp.Value)
        {
            sb.Append(kvp.Key);
        }
    }
}

Console.WriteLine(sb);


//string[] input = Console.ReadLine()
//    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
//    .ToArray();

//for (int i = 0; i < input.Length; i++)
//{
//    if (input[i] == "|")
//    {
//        input[i] = " ";
//    }
//    if (input[i] == ".-")
//    {
//        input[i] = "A";
//    }
//    else if (input[i] == "-...")
//    {
//        input[i] = "B";
//    }
//    else if (input[i] == "-.-.")
//    {
//        input[i] = "C";
//    }
//    else if (input[i] == "-..")
//    {
//        input[i] = "D";
//    }
//    else if (input[i] == ".")
//    {
//        input[i] = "E";
//    }
//    else if (input[i] == "..-.")
//    {
//        input[i] = "F";
//    }
//    else if (input[i] == "--.")
//    {
//        input[i] = "G";
//    }
//    else if (input[i] == "....")
//    {
//        input[i] = "H";
//    }
//    else if (input[i] == "..")
//    {
//        input[i] = "I";
//    }
//    else if (input[i] == ".---")
//    {
//        input[i] = "J";
//    }
//    else if (input[i] == "-.-")
//    {
//        input[i] = "K";
//    }
//    else if (input[i] == ".-..")
//    {
//        input[i] = "L";
//    }
//    else if (input[i] == "--")
//    {
//        input[i] = "M";
//    }
//    else if (input[i] == "-.")
//    {
//        input[i] = "N";
//    }
//    else if (input[i] == "---")
//    {
//        input[i] = "O";
//    }
//    else if (input[i] == ".--.")
//    {
//        input[i] = "P";
//    }
//    else if (input[i] == "--.-")
//    {
//        input[i] = "Q";
//    }
//    else if (input[i] == ".-.")
//    {
//        input[i] = "R";
//    }
//    else if (input[i] == "...")
//    {
//        input[i] = "S";
//    }
//    else if (input[i] == "-")
//    {
//        input[i] = "T";
//    }
//    else if (input[i] == "..-")
//    {
//        input[i] = "U";
//    }
//    else if (input[i] == "...-")
//    {
//        input[i] = "V";
//    }
//    else if (input[i] == ".--")
//    {
//        input[i] = "W";
//    }
//    else if (input[i] == "-..-")
//    {
//        input[i] = "X";
//    }
//    else if (input[i] == "-.--")
//    {
//        input[i] = "Y";
//    }
//    else if (input[i] == "--..")
//    {
//        input[i] = "Z";
//    }
//}

//Console.WriteLine(string.Join("", input));
