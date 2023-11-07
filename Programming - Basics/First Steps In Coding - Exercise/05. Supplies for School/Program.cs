int pen =  int.Parse(Console.ReadLine());
int marc = int.Parse(Console.ReadLine());
int liters = int.Parse(Console.ReadLine());
int percent = int.Parse(Console.ReadLine());

double pricepen = pen * 5.80;
double pricemarc = marc * 7.20;
double priceliter = liters * 1.20;

double sum = pricepen + pricemarc + priceliter;

//double totalSum = sum - sum * percent;

double totalSum = sum - (sum * percent / 100);

Console.WriteLine(totalSum);


