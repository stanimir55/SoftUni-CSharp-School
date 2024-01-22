//double dul, sh, V = 0;

//Console.WriteLine("Length: ");

//dul = double.Parse(Console.ReadLine());

//Console.WriteLine("Width: ");

//sh = double.Parse(Console.ReadLine());

//Console.WriteLine("Heigth: ");

//V = double.Parse(Console.ReadLine());

//V = (dul + sh + V) / 3;

//Console.WriteLine($"Pyramid Volume: {V:f2}");

double lenght = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

double result = (lenght * width * height) / 3;

Console.WriteLine($"Length: Width: Height: Pyramid Volume: {result:F2}");