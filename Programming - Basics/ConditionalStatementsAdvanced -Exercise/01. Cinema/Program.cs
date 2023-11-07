string ticketsType = Console.ReadLine();
int row = int.Parse(Console.ReadLine());
int col = int.Parse(Console.ReadLine());
double income = row * col;

switch (ticketsType)
{
    case "Premiere":
        income = income * 12.00;
        break;
    case "Normal":
        income = income * 7.50;
        break;
    default:
        income = income * 5.00;
        break;
}

Console.WriteLine("{0:f2} leva", income);
