//Предпазен найлон - 1.50 лв. за кв. метър
//Боя - 14.50 лв.за литър
//Разредител за боя - 5.00 лв. за литъ
//За всеки случай, към необходимите материали, Румен иска да добави още 10% от количеството боя и 2 кв.м. найлон,
//разбира се и 0.40 лв. за торбички. Сумата, която се заплаща на майсторите за 1 час работа,
//е равна на 30% от сбора на всички разходи за материали.

int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double nylonprice = nylon * 1.50 + 3 ;
double paintprice = (paint + paint * 0.1) * 14.50;
double thimerprice = thinner * 5.00;
double bags = 0.40;
double money = nylonprice + paintprice + thimerprice + bags;
double masters = (money * 0.3) * hours;
double sum = money + masters;

Console.WriteLine(sum); 