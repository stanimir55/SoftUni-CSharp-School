List<int> inputOne = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> inputTwo = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> result = new List<int>();
List<int> output = new List<int>();

if (inputOne.Count > inputTwo.Count)
{
    result.Add(inputOne[inputOne.Count - 1]);
    result.Add(inputOne[inputOne.Count - 2]);
    inputOne.RemoveAt(inputOne.Count - 1);
    inputOne.RemoveAt(inputOne.Count- 1);
}
else if (inputTwo.Count > inputOne.Count)
{
    result.Add(inputTwo[0]);
    result.Add(inputTwo[1]);
    inputTwo.RemoveAt(0);
    inputTwo.RemoveAt(0);
}

inputTwo.Reverse();

for (int i = 0; i < inputOne.Count; i++)
{
    output.Add(inputOne[i]);
    output.Add(inputTwo[i]);
}

result.Sort();
output.Sort();

output.RemoveAll(x => x <= result[0]);
output.RemoveAll(x => x >= result[1]);

Console.WriteLine(string.Join(" ",output));
