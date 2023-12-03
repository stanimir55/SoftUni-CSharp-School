int number = int.Parse(Console.ReadLine());
var users = new Dictionary<string, User>();

for (int i = 0; i < number; i++)
{
    string[] arguments = Console.ReadLine()
        .Split()
        .ToArray();

    string command = arguments[0];
    string userName = arguments[1];

    switch (command)
    {
        case "register":
            string licensePlateNumber = arguments[2];
            User newUser = new User(userName,licensePlateNumber);

            if (users.ContainsKey(userName))
            {
                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
            }
            else
            {
                users.Add(userName, newUser);

                Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
            }
            break;
        case "unregister":
            if (users.ContainsKey(userName))
            {
                users.Remove(userName);
                Console.WriteLine($"{userName} unregistered successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: user {userName} not found");
            }
            break;
    }
}

foreach (KeyValuePair<string, User> kvp  in users)
{
    Console.WriteLine(kvp.Value);
}

class User
{
    public User(string userName, string licensePlateNumber)
    {
        UserName = userName;
        LicensePlateNumber = licensePlateNumber;
    }
    public string UserName { get; set; }

    public string LicensePlateNumber { get; set; }

    public override string ToString()
    {
        return $"{UserName} => {LicensePlateNumber}";
    }
}