int key = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    char symbol = char.Parse(Console.ReadLine());

    int result = (int)symbol + key;

    Console.Write((char)result);
}
