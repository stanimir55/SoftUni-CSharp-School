int linesCount = int.Parse(Console.ReadLine());
List<string> products = new List<string>();

for (int i = 0; i < linesCount; i++)
{
    string productName = Console.ReadLine();
    products.Add(productName);
}

products.Sort();

for (int i = 0; i < linesCount; i++)
{
    Console.WriteLine($"{i+1}.{products[i]}");
}