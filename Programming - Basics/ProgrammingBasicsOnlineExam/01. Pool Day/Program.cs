int peopleNum = int.Parse(Console.ReadLine());
double entranceFee = double.Parse(Console.ReadLine());
double sunLoungerPrice = double.Parse(Console.ReadLine());
double umbrellaPrice = double.Parse(Console.ReadLine());

double entranceFeeA = peopleNum * entranceFee;
double sunLoungerPriceA = Math.Ceiling(peopleNum * 0.75);
sunLoungerPriceA = sunLoungerPriceA * sunLoungerPrice;
double umbrellaPriceA = Math.Ceiling(peopleNum * 0.50);
umbrellaPriceA = umbrellaPriceA * umbrellaPrice;
double totalPrice = entranceFeeA + sunLoungerPriceA + umbrellaPriceA;

Console.WriteLine($"{totalPrice:F2} lv.");
