int dogfood =  int.Parse(Console.ReadLine());
int catfood = int.Parse(Console.ReadLine());
double pricedog = dogfood * 2.50;
double pricecat = catfood * 4;
double finalprice = pricedog + pricecat;

Console.WriteLine($"{finalprice} lv.");

