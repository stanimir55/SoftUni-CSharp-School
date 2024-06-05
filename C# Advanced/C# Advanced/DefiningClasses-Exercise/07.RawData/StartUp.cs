namespace _07.RawData;

public class StartUp
{
    static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());

        List<Car> cars = new List<Car>();

        for (int i = 0; i < linesCount; i++)
        {
            string[] arguments = Console.ReadLine().Split();

            string model = arguments[0];
            int engineSpeed = int.Parse(arguments[1]);
            int enginePower = int.Parse(arguments[2]);
            int engineWeight = int.Parse(arguments[3]);
            string cargoType = arguments[4];
            int counter = 0;

            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoType, engineWeight);
            Tire[] tires = new Tire[4];

            for (int k = 5; k <= 12; k += 2)
            {
                double tirePressure = double.Parse(arguments[k]);
                int tireAge = int.Parse(arguments[k + 1]);

                tires[counter++] = new Tire(tireAge, tirePressure);
            }

            Car car = new Car(model, engine, cargo, tires);
            cars.Add(car);
        }

        string command = Console.ReadLine();

        cars.Where(x => x.Cargo.Tyoe == command &&
        (command == "fragile" ? x.Tires.Any(x => x.Pressure < 1) :
        x.Engine.Power > 250))
            .ToList()
            .ForEach(x => Console.WriteLine(x.Model));
    }
}

/*
2
ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4
Citroen2CV 190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1
fragile
 */