var companies = new Dictionary<string, Companies>();

string commands;
while ((commands = Console.ReadLine()) != "End")
{
    string[] arguments = commands.Split(" -> ");

    if (!companies.ContainsKey(arguments[0]))
    {
        Companies companies1 = new Companies(arguments[0]);
        companies.Add(companies1.CompanyName, companies1);
    }

    if (!companies[arguments[0]].EmployeeID.Contains(arguments[1]))
    {
        companies[arguments[0]].EmployeeID.Add(arguments[1]);
    }
}

foreach (var kvp in companies)
{
    Console.WriteLine(kvp.Value);
}

class Companies
{
    public string CompanyName { get; set; }

    public List<string> EmployeeID  { get; set; }

    public Companies(string companyName)
    {
        CompanyName = companyName;
        EmployeeID = new List<string>();
    }

    public override string ToString()
    {
        string result = $"{CompanyName}\n";

        for (int i = 0; i < EmployeeID.Count; i++)
        {
            result += $"-- {EmployeeID[i]}\n";
        }
        return result.Trim();
    }
}