HashSet<string> carsNumbers = new HashSet<string>();
string commands;
while ((commands = Console.ReadLine()) != "END")
{
    string[] arguments = commands.Split(", ");
    string direction = arguments[0];
    string carNumber = arguments[1];

    _ = direction == "IN" ? carsNumbers.Add(carNumber) : default;
    _ = direction == "OUT" ? carsNumbers.Remove(carNumber) : default;
}

Console.WriteLine(carsNumbers.Count == 0 ? "Parking Lot is Empty" :
    string.Join(Environment.NewLine, carsNumbers));