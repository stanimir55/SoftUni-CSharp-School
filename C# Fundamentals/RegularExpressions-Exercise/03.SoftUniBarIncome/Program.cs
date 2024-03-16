using System.Text.RegularExpressions;

string input;
string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^\|\$\%\.]*<(?<product>\w+)>[^\|\$\%\.]*\|(?<count>\d+)\|[^\|\$\%\.|]*?(?<price>|\d+\.\d+|\d+)\$";
decimal totalIncome = 0;

while ((input = Console.ReadLine()) != "end of shift")
{
    if (Regex.IsMatch(input, pattern))
    {
        Match match = Regex.Match(input, pattern);

        string customerName = match.Groups["customer"].Value;
        string productName = match.Groups["product"].Value;
        int productCount = int.Parse(match.Groups["count"].Value);
        decimal productPrice = decimal.Parse(match.Groups["price"].Value);

        decimal totalPrice = productCount * productPrice;
        totalIncome += totalPrice;

        Console.WriteLine($"{customerName}: {productName} - {totalPrice:F2}");
    }
}

Console.WriteLine($"Total income: {totalIncome:F2}");


//string input;
//List<string> customerNames = new List<string>();
//List<string> productNames = new List<string>();
//List<int> productCount = new List<int>();
//List<decimal> productPrice = new List<decimal>();


//while ((input = Console.ReadLine()) != "end of shift")
//{
//    string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^\|\$\%\.]*<(?<product>\w+)>[^\|\$\%\.]*\|(?<count>\d+)\|[^\|\$\%\.|]*?(?<price>|\d+\.\d+|\d+)\$";

//    foreach (Match match in Regex.Matches(input, pattern))
//    {
//        customerNames.Add(match.Groups["customer"].Value);
//        productNames.Add(match.Groups["product"].Value);
//        productCount.Add(int.Parse(match.Groups["count"].Value));
//        productPrice.Add(decimal.Parse(match.Groups["price"].Value));
//    }
//}

//decimal total = 0;

//for (int i = 0; i < customerNames.Count; i++)
//{
//    Console.WriteLine($"{customerNames[i]}: {productNames[i]} - {productCount[i] * productPrice[i]:F2}");
//    total += productCount[i] * productPrice[i];
//}

//Console.WriteLine($"Total income: {total:F2}");

