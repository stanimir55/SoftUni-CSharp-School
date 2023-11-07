int clock = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

switch (dayOfWeek)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
    case "Saturday":
        if (clock >= 10 && clock <=18)
        {
            Console.WriteLine("open");
            break;
        }
        else
        {
            Console.WriteLine("closed");
            break;
        }
    default:
        Console.WriteLine("closed");
        break;
}







































