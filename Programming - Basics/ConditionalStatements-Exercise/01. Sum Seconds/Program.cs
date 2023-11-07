int firs = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int thrid = int.Parse(Console.ReadLine());

int totalTime = firs + second + thrid;

int min = totalTime / 60;
int sec = totalTime % 60;

Console.WriteLine($"{min}:{sec:D2}");



