double savings = double.Parse(Console.ReadLine());
List<int> drumSet = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> drum = new List<int>(drumSet);

int price = 0;
string command;

while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
{
    int numbers = int.Parse(command);

    for (int i = 0; i < drumSet.Count; i++)
    {
        drumSet[i] -= numbers;

        price = drum[i] * 3;

        if (drumSet[i] <= 0)
        {
            if (savings < price)
            {
                drumSet.Remove(drumSet[i]);
                drum.Remove(drum[i]);
                i--;
            }
            else
            {
                drumSet.Remove(drumSet[i]);
                savings -= price;
                drumSet.Insert(i, drum[i]);
            }
        }
    }
}

Console.WriteLine(string.Join(" ", drumSet));
Console.WriteLine($"Gabsy has {savings:F2}lv.");

