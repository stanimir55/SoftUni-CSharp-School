int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());

List<int> result = new List<int>
{
    numberOne,
    numberTwo,
    numberThree
};

result.Sort();

for (int i = result.Count - 1; i >= 0; i--)
{
    Console.WriteLine(result[i]);
}
