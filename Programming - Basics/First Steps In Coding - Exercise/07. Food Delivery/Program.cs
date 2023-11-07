//Пилешко меню –  10.35 лв. 
//Меню с риба – 12.40 лв. 
//Вегетарианско меню  – 8.15 лв. 




int chiken = int.Parse(Console.ReadLine());
int fish = int.Parse(Console.ReadLine());
int vegan = int.Parse(Console.ReadLine());

double chikenPrice = chiken * 10.35;
double fishPrice = fish * 12.40;
double veganPrise = vegan * 8.15;

double sum = chikenPrice + fishPrice + veganPrise;
double dessert = sum * 0.2;
double totalSum = sum + dessert + 2.50;

Console.WriteLine(totalSum);

