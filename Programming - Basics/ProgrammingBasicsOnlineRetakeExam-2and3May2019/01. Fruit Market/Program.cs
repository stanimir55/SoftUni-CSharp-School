double strawberriesPrice = double.Parse(Console.ReadLine());
double quantityBananasKg = double.Parse(Console.ReadLine());
double quantityOrangesKg = double.Parse(Console.ReadLine());
double quantityRaspberriesKg = double.Parse(Console.ReadLine());
double quantityStrawberriesKg = double.Parse(Console.ReadLine());

double raspberriesPrice = strawberriesPrice / 2 ;
double orangesPrice = raspberriesPrice - raspberriesPrice * 0.40;
double bananasPrice = raspberriesPrice - raspberriesPrice * 0.80;

double strawberriesSum = strawberriesPrice * quantityStrawberriesKg;
double raspberriesSum = raspberriesPrice * quantityRaspberriesKg;
double orangesSum = orangesPrice * quantityOrangesKg;
double bananasSum = bananasPrice * quantityBananasKg;

double totalPrice = strawberriesSum + raspberriesSum + orangesSum + bananasSum;

Console.WriteLine(totalPrice);