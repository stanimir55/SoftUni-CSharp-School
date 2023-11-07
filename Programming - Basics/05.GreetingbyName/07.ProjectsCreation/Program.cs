string Thearchitect =(Console.ReadLine());
int projects = int.Parse(Console.ReadLine());
int hours = 3;
int willneed = projects * hours;

Console.WriteLine($"The architect {Thearchitect} will need {willneed} hours to complete {projects} project/s.");
