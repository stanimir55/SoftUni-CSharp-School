namespace _05.DateModifier;
public class StartUp
{
    static void Main()
    {
        string firstDateInput = Console.ReadLine();
        string secondDateInput = Console.ReadLine();

        DateTime firstDate = DateTime.Parse(firstDateInput);
        DateTime secondDate = DateTime.Parse(secondDateInput);

        int daysDiff = DateModifier.CalculateDateDiffInDays(firstDate, secondDate);

        Console.WriteLine(daysDiff);
    }
}