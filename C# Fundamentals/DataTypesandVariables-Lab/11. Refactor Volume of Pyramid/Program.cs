//double lenght, width, height, total = 0;


double lenght = double.Parse(Console.ReadLine());

//lenght = double.Parse(Console.ReadLine());

double width = double.Parse(Console.ReadLine());

//width = double.Parse(Console.ReadLine());

double height = double.Parse(Console.ReadLine());

//height = double.Parse(Console.ReadLine());
double total = lenght * width * height / 3;
//total = (lenght + width + height) / 3;

Console.WriteLine($"Length: Width: Height: Pyramid Volume: {total:F2}");

