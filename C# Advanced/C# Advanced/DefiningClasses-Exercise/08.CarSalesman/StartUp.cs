namespace _08.CarSalesman;

public class StartUp
{
    static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());

        List<Car> cars = new List<Car>();
        List<Engine> engines = new List<Engine>();

        for (int i = 0; i < linesCount; i++)
        {
            string[] arguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string model = arguments[0];
            string power = arguments[1];

            if (arguments.Count() == 3)
            {
                string thirdParam = arguments[2]; //displacement or efficiency
                if (int.TryParse(thirdParam, out int displacement))
                {
                    Engine newEngine = new Engine(model, power, displacement);
                    engines.Add(newEngine);
                }

                else
                {
                    string efficiency = arguments[2];
                    Engine newEngine = new Engine(model, power, efficiency);
                    engines.Add(newEngine);
                }
            }
            else if (arguments.Count() == 4)
            {
                int displacement = int.Parse(arguments[2]);
                string efficiency = arguments[3];

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }
            else
            {
                Engine engine = new Engine(model, power);
                engines.Add(engine);
            }

        }

        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            string[] arguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string model = arguments[0];
            string engine = arguments[1];

            if (arguments.Count() == 2)
            {
                if (engines.Exists(x => x.Model == engine)) // TODO Exist
                {
                    Engine findEngine = engines.Where(x => x.Model == engine).First();
                    Car newCar = new Car(model, findEngine);
                    cars.Add(newCar);
                }
            }
            else if (arguments.Count() == 3)
            {
                string thirdParam = arguments[2]; // TODO Weight Or Color

                if (engines.Any(x => x.Model == engine))
                {
                    Engine findEngine = engines.Where(x => x.Model == engine).First();

                    if (int.TryParse(thirdParam, out int weight))
                    {
                        Car newCar = new Car(model, findEngine, weight);
                        cars.Add(newCar);
                    }
                    else
                    {
                        string color = arguments[2];
                        Car newCar = new Car(model, findEngine, color);
                        cars.Add(newCar);
                    }
                }
            }
            else if (arguments.Count() == 4)
            {
                int weight = int.Parse(arguments[2]);
                string color = arguments[3];

                if (engines.Any(e => e.Model == engine))
                {
                    Engine findedEngine = engines.Where(e => e.Model == engine).First();
                    var newCar = new Car(model, findedEngine, weight, color);
                    cars.Add(newCar);
                }
            }
        }

        cars.ForEach(Console.WriteLine);
    }
}

/*
2
V8-101 220 50
V4-33 140 28 B
3
FordFocus V4-33 1300 Silver
FordMustang V8-101
VolkswagenGolf V4-33 Orange 
 */