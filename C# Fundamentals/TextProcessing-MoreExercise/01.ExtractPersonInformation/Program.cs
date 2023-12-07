int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string strings = Console.ReadLine();

    int indexOfNameStar = strings.IndexOf('@');
    int indexOfNameEnd = strings.IndexOf('|');

    string name = strings.Substring(indexOfNameStar + 1, indexOfNameEnd - indexOfNameStar - 1);

    int indexOfAgeStart = strings.IndexOf('#');
    int indexOfAgeEnd = strings.IndexOf('*');

    string age = strings.Substring(indexOfAgeStart + 1, indexOfAgeEnd - indexOfAgeStart - 1);

    Console.WriteLine($"{name} is {age} years old.");
}