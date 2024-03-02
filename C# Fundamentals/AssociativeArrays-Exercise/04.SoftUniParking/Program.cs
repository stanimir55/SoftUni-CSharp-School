Dictionary<string, User> users = new Dictionary<string, User>();
int commandsCount = int.Parse(Console.ReadLine());

for (int i = 0; i < commandsCount; i++)
{
    string[] arguments = Console.ReadLine().Split();
    string command = arguments[0];

    switch (command)
    {
        case "register":
            if (!users.ContainsKey(arguments[1]))
            {
                User newUser = new User(arguments[1], arguments[2]);
                users.Add(arguments[1], newUser);
                Console.WriteLine($"{newUser.Username} registered {newUser.LicensePlateNumber} successfully");
                continue;
            }

            User foundUser = new User(arguments[1], arguments[2]);
            Console.WriteLine($"ERROR: already registered with plate number {foundUser.LicensePlateNumber}");

            break;
        case "unregister":
            if (users.ContainsKey(arguments[1]))
            {
                users.Remove(arguments[1]);
                Console.WriteLine($"{arguments[1]} unregistered successfully");
                continue;
            }

            Console.WriteLine($"ERROR: user {arguments[1]} not found");
            break;
    }
}

foreach (var kvp in users)
{
    Console.WriteLine($"{kvp.Key} => {kvp.Value.LicensePlateNumber}");
}

class User
{
    public User(string username, string licensePlateNumber)
    {
        Username = username;
        LicensePlateNumber = licensePlateNumber;
    }

    public string Username { get; set; }

    public string LicensePlateNumber { get; set; }
}