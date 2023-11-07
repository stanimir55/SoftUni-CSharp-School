string filmName = Console.ReadLine();
int daysNum = int.Parse(Console.ReadLine());
int ticketsNum = int.Parse(Console.ReadLine());
double ticketsPrice = double.Parse(Console.ReadLine());
double cinemaProcent = double.Parse(Console.ReadLine());

double ticketsSum = ticketsNum * ticketsPrice;
double incomePeriod = daysNum * ticketsSum;
double procentForCinema = cinemaProcent / 100 *  incomePeriod;
double incomeFilm = incomePeriod - procentForCinema;

Console.WriteLine($"The profit from the movie {filmName} is {incomeFilm:F2} lv.");
