namespace _06.SpeedRacing;
public class StartUp
{
    static void Main()
    {
        int carsToTrack = int.Parse(Console.ReadLine());
        var cars = new Dictionary<string, Car>();

        for (int i = 0; i < carsToTrack; i++)
        {
            string[] arguments = Console.ReadLine().Split();

            string model = arguments[0];
            double fuelAmount = double.Parse(arguments[1]);
            double fuelConsumptionForOnekm = double.Parse(arguments[2]);

            Car car = new Car(model, fuelAmount, fuelConsumptionForOnekm);
            cars.Add(model, car);
        }

        string commands;
        while ((commands = Console.ReadLine()) != "End")
        {
            string[] arguments = commands.Split();

            string carModel = arguments[1];
            double amountOfKm = double.Parse(arguments[2]);

            if (cars.ContainsKey(carModel))
            {
                Car car = cars[carModel];

                if (car.CanMove(amountOfKm))
                    car.Drive(amountOfKm);
                else
                    Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        foreach (var car in cars.Values)
        {
            Console.WriteLine(car);
        }
    }
}

/*
2
AudiA4 23 0.3
BMW-M2 45 0.42
Drive BMW-M2 56
Drive AudiA4 5
Drive AudiA4 13
End
 */