int videoCardPrice = int.Parse(Console.ReadLine());
int transitionPrice = int.Parse(Console.ReadLine());
double currentConsumed = double.Parse(Console.ReadLine());
double profit = double.Parse(Console.ReadLine());

int videoCardTotalPrice = videoCardPrice * 13;
int transitionTotalPrice = transitionPrice * 13;
int total = videoCardTotalPrice + transitionTotalPrice + 1000;

double profitCard = profit - currentConsumed;
double totalProfit = profitCard * 13;
double days = Math.Ceiling(total / totalProfit);

Console.WriteLine(total);
Console.WriteLine(days);