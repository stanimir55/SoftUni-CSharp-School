int key = int.Parse(Console.ReadLine());
int linesCount = int.Parse(Console.ReadLine());
string decryptedMessage = "";

for (int i = 0; i < linesCount; i++)
{
    char latinAlphabet = char.Parse(Console.ReadLine());
    decryptedMessage += (char)(latinAlphabet + key);
}

Console.WriteLine(decryptedMessage);