int peopleNum = int.Parse(Console.ReadLine());
int elevatorCapacity = int.Parse(Console.ReadLine());

double courses = Math.Ceiling((double)peopleNum / elevatorCapacity);

Console.WriteLine(courses);