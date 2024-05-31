List<double> prices = Console.ReadLine()
    .Split(", ")
    .Select(double.Parse)
    .Select(x => x += x * 0.20 )
    .ToList();

Console.WriteLine(string.Join(Environment.NewLine, prices.Select(x => x.ToString("F2"))));

