int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double volume = length * width * height;
double litters = volume * 0.001;
double space = percent / 100;
double needed = litters * Math.Abs(1 - space);

Console.WriteLine(needed);
