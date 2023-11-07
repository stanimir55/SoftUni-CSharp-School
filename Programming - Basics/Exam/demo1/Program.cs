int peopleNum = int.Parse(Console.ReadLine());
int nightNum = int.Parse(Console.ReadLine());
int cardForTransport = int.Parse(Console.ReadLine());
int ticketsNum = int.Parse(Console.ReadLine());

int nightPrice = nightNum * 20;
double cardForTrnsportPtice = cardForTransport * 1.60;
int ticketPrice = ticketsNum * 6;

double totalPriceFotPeople = nightPrice + cardForTrnsportPtice + ticketPrice;

double totalPriceForGroup = totalPriceFotPeople * peopleNum;

double diff = totalPriceForGroup + totalPriceForGroup * 0.25;

Console.WriteLine($"{diff:F2}");

























