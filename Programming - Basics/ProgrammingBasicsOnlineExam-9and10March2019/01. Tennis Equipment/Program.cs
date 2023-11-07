double tennisRackedPrice = double.Parse(Console.ReadLine());
int countTennisRacked = int.Parse(Console.ReadLine());
int countSneakers = int.Parse(Console.ReadLine());

double totalTennisRackedPrice = tennisRackedPrice * countTennisRacked;
double sneakers = tennisRackedPrice / 6;
double totalSneakersPrice = sneakers * countSneakers;

double total = (totalTennisRackedPrice + totalSneakersPrice) * 0.2;
double totalPrice = totalTennisRackedPrice + totalSneakersPrice + total;

double priceD = totalPrice / 8;
double priceS = totalPrice * 7 / 8;

Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceD)}");
Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceS)}");
