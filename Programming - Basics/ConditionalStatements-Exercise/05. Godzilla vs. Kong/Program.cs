double budgetFilm = double.Parse(Console.ReadLine());
int numStat = int.Parse(Console.ReadLine());
double clothingPrice = double.Parse(Console.ReadLine());

double priceDecor = budgetFilm * 0.1;
double priceCloth = numStat * clothingPrice;
if (numStat > 150)
{
    priceCloth = priceCloth - priceCloth * 0.1;
    
}
//double priceCloth = numStat * clothingPrice;
double totalSumFilm = priceDecor + priceCloth;
//if (numStat > 150)
//{
//    clothingPrice = numStat * 0.1;
//}

if (priceDecor + priceCloth > budgetFilm)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {totalSumFilm - budgetFilm:F2} leva more.") ;
}
else if (priceDecor + clothingPrice <= budgetFilm)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budgetFilm - totalSumFilm:F2} leva left.");
}
