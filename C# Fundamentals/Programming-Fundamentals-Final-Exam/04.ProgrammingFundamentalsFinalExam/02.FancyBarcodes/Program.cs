using System.Text.RegularExpressions;

int countOfBarcodes = int.Parse(Console.ReadLine());
string pattern = @"^@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";

for (int i = 0; i < countOfBarcodes; i++)
{
    string input = Console.ReadLine();

    MatchCollection matches = Regex.Matches(input, pattern);
    
    if (matches.Count == 0)
    {
        Console.WriteLine("Invalid barcode");
    }
    else
    {
        string productGroup = "";
        string result = matches[0].Value;

        for (int k = 0; k < result.Length; k++)
        {
            if (char.IsDigit(result[k]))
            {
                productGroup += result[k];
            }
        }

        if (productGroup == "")
        {
            productGroup = "00";
        }
        Console.WriteLine($"Product group: {productGroup}");
    }
}
