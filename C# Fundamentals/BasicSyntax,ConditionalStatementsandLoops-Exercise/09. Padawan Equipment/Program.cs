double amountOfMoney = double.Parse(Console.ReadLine());
int countOfStudents = int.Parse(Console.ReadLine());
double priceOfLightsaber = double.Parse(Console.ReadLine());
double priceOfRobe = double.Parse(Console.ReadLine());
double priceOfBelt = double.Parse(Console.ReadLine());

double priceForAllLightsabers = Math.Ceiling(countOfStudents * 1.1) * priceOfLightsaber;
double priceForAllRobes = countOfStudents * priceOfRobe;

int freeBelts = countOfStudents / 6;
double priceForAllBelts = (countOfStudents - freeBelts) * priceOfBelt;

double finalPrice = priceForAllLightsabers + priceForAllRobes + priceForAllBelts;

if (finalPrice <= amountOfMoney)
{
    Console.WriteLine($"The money is enough - it would cost {finalPrice:F2}lv.");
}
else
{
    Console.WriteLine($"John will need {Math.Abs(amountOfMoney - finalPrice):F2}lv more.");
}