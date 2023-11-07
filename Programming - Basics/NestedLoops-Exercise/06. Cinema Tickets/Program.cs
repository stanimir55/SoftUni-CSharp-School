int studentTickets = 0;
int standartTickets = 0;
int kidTickets = 0;

string filmName = Console.ReadLine();
while (filmName != "Finish")
{
    int free = int.Parse(Console.ReadLine());
    int tickets = 0;
    string ticketType = Console.ReadLine();

    while (ticketType != "End")
    {
        if (ticketType == "student")
        {
            studentTickets++;
        }
        else if (ticketType == "standard")
        {
            standartTickets++;
        }
        else
        {
            kidTickets++;
        }

        tickets++;

        if (tickets == free)
        {
            break;
        }
        ticketType = Console.ReadLine();
    }

    Console.WriteLine($"{filmName} - {tickets * 100.0 / free:F2}% full.");

    filmName = Console.ReadLine();
}

double totalTickets = studentTickets + standartTickets + kidTickets;

Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{studentTickets * 100 / totalTickets:F2}% student tickets.");
Console.WriteLine($"{standartTickets * 100 / totalTickets:F2}% standard tickets.");
Console.WriteLine($"{kidTickets * 100 / totalTickets:F2}% kids tickets.");

