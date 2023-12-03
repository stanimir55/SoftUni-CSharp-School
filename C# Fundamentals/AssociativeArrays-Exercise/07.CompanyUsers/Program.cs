string command;
var companies = new Dictionary<string, Companies>();

while ((command = Console.ReadLine()) != "End")
{
    string[] arguments = command
        .Split(" -> ")
        .ToArray();

    string companyName = arguments[0];
    string employeeId = arguments[1];

    if (!companies.ContainsKey(companyName))
    {
        Companies companies1 = new Companies(companyName);
        companies.Add(companies1.CompanyName, companies1);
    }

    if (!companies[companyName].EmployeeID.Contains(employeeId))
    {
        companies[companyName].EmployeeID.Add(employeeId);
    }
}

foreach (KeyValuePair<string, Companies> kvp in companies)
{
    Console.WriteLine(kvp.Value);
}


class Companies
{
    public string CompanyName { get; set; }

    public List<string> EmployeeID { get; set; }

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