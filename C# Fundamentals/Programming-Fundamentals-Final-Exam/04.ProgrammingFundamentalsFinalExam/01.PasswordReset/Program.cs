using System.Text;

string password = Console.ReadLine();
string commands;

StringBuilder newPassword = new StringBuilder();

while ((commands = Console.ReadLine()) != "Done")
{
    string[] command = commands
        .Split();

    switch (command[0])
    {
        case "TakeOdd":

            for (int i = 1; i < password.Length; i += 2)
            {
                newPassword.Append(password[i]);
            }

            password = newPassword.ToString();
            Console.WriteLine(password);
            break;
        case "Cut":
            int index = int.Parse(command[1]);
            int length = int.Parse(command[2]);

            password = password.Remove(index, length);

            Console.WriteLine(password);
            break;
        case "Substitute":

            if (password.Contains(command[1]))
            {
                password = password.Replace(command[1], command[2]);

                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }

            break;
    }
}

Console.WriteLine($"Your password is: {password}");
