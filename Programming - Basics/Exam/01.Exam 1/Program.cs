double priceProcessorD = double.Parse(Console.ReadLine());
double priceVideoCardD = double.Parse(Console.ReadLine());
double priceRamD = double.Parse(Console.ReadLine());
int ramNum = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double bgn = 1.57;
double priceProcessorBgn = priceProcessorD * bgn;
double priceVideoCardBgn = priceVideoCardD * bgn;
priceRamD = priceRamD * bgn;
double totalRam = priceRamD * ramNum;

priceProcessorBgn -= priceProcessorBgn * percent;
priceVideoCardBgn -= priceVideoCardBgn * percent;
double totalSum = priceProcessorBgn + priceVideoCardBgn + totalRam;

Console.WriteLine($"Money needed - {totalSum:F2} leva.");
