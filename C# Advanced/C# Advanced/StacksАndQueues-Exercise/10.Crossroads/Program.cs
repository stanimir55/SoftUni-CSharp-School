int greenLight = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());
Queue<string> cars = new Queue<string>();

int passedCars = 0;
bool isHitted = false;

string command;
while ((command = Console.ReadLine()) != "END")
{
    if (command != "green")
    {
        cars.Enqueue(command);
        continue;
    }

    int currentGreenLight = greenLight;

    while (cars.Any() && currentGreenLight > 0)
    {
        string currentCar = cars.Dequeue();

        if (currentGreenLight - currentCar.Length > 0 || currentGreenLight + freeWindow - currentCar.Length >= 0)
        {
            currentGreenLight -= currentCar.Length;
            passedCars++;
            continue;
        }

        char hittedChar = currentCar[currentGreenLight + freeWindow];

        Console.WriteLine("A crash happened!");
        Console.WriteLine($"{currentCar} was hit at {hittedChar}.");

        isHitted = true;
        break;
    }
}

if (!isHitted)
{
    Console.WriteLine("Everyone is safe.");
    Console.WriteLine($"{passedCars} total cars passed the crossroads.");
}