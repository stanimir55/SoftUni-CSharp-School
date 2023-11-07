int taxPerYear = int.Parse(Console.ReadLine());

double shoes = taxPerYear - taxPerYear * 0.4;

double outflit = shoes - shoes * 0.2;

double ball = outflit / 4;

double accessories = ball / 5;

double sum = taxPerYear + shoes + outflit + ball + accessories;

Console.WriteLine(sum);
