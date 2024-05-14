int n = int.Parse(Console.ReadLine());
Queue<string> cars = new Queue<string>();
string command;
int passedCarsCount = 0;

while ((command = Console.ReadLine()) != "end")
{
    if (command == "green")
    {
        for (int i = 0; i < n; i++)
        {
            if (cars.Count == 0)
            {
                break;
            }
            Console.WriteLine($"{cars.Dequeue()} passed!");
            passedCarsCount++;
        }
    }
    else
    {
        cars.Enqueue(command);
    }
}

Console.WriteLine($"{passedCarsCount} cars passed the crossroads.");
