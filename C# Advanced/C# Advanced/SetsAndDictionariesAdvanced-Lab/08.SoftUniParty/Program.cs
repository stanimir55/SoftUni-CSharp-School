HashSet<string> vipGuests = new HashSet<string>();
HashSet<string> reservations = new HashSet<string>();

string commands;
while ((commands = Console.ReadLine()) != "PARTY")
{
    reservations.Add(commands);
}

while ((commands = Console.ReadLine()) != "END")
{
    _ = reservations.Contains(commands) ? reservations.Remove(commands) : default;
}

Console.WriteLine(reservations.Count);

foreach (var reservation in reservations)
{
    if (reservation[0] >= 48 && reservation[0] <= 57)
    {
        vipGuests.Add(reservation);
        reservations.Remove(reservation);
    }
}

if (vipGuests.Count > 0)
{
    Console.WriteLine(string.Join(Environment.NewLine, vipGuests));
}

Console.WriteLine(string.Join(Environment.NewLine, reservations));
