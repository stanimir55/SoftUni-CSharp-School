int number = int.Parse(Console.ReadLine());
int pages = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int hours;

hours = number / pages / days;

Console.WriteLine(hours);
