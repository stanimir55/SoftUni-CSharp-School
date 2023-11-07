double deposit = double.Parse(Console.ReadLine());
int term = int.Parse(Console.ReadLine());
double rate = double.Parse(Console.ReadLine());

double sum;

sum = deposit + term * (deposit * (rate / 100) / 12);

Console.WriteLine(sum);