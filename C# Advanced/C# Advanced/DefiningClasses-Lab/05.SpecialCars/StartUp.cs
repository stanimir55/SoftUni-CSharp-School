using System;
using System.Runtime.ConstrainedExecution;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            var tires = new Dictionary<int, List<Tire>>();
            var engines = new Dictionary<int, Engine>();
            List<Car> cars = new List<Car>();
            int index = 0;

            string commands;
            while ((commands = Console.ReadLine()) != "No more tires")
            {
                string[] arguments = commands.Split();
                tires.Add(index, new List<Tire>());

                for (int i = 0; i < arguments.Length; i += 2)
                {
                    int year = int.Parse(arguments[i]);
                    double pressure = double.Parse(arguments[i + 1]);

                    Tire tire = new Tire(year, pressure);
                    tires[index].Add(tire);
                }

                index++;
            }

            index = 0;
            while ((commands = Console.ReadLine()) != "Engines done")
            {
                string[] arguments = commands.Split();

                int horsePower = int.Parse(arguments[0]);
                double cubicCapacity = double.Parse(arguments[1]);

                Engine engine = new (horsePower, cubicCapacity);

                engines.Add(index, engine);
                index++;

            }

            while ((commands = Console.ReadLine()) != "Show special")
            {
                string[] arguments = commands.Split();

                string make = arguments[0];
                string model = arguments[1];
                int year = int.Parse(arguments[2]);
                double fuelQuantity = double.Parse(arguments[3]);
                double fuelConsumption = double.Parse(arguments[4]);
                int engineKey = int.Parse(arguments[5]);
                int tiresKey = int.Parse(arguments[5]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption,
                    engines[engineKey], tires[tiresKey].ToArray());

                cars.Add(car);
            }

            var filtredCars = cars
                .Where(x => x.Year >= 2017 &&
                x.Engine.HorsePower > 330 &&
                x.Tires.Sum(x => x.Pressure) > 9 &&
                x.Tires.Sum(x => x.Pressure) < 10);

            foreach (var car in filtredCars)
            {
                car.Drive(20);
                Console.WriteLine(car);
            }
        }
    }
}

/*
2 2.6 3 1.6 2 3.6 3 1.6
1 3.3 2 1.6 5 2.4 1 3.2
No more tires
331 2.2
145 2.0
Engines done
Audi A5 2017 200 12 0 0
BMW X5 2007 175 18 1 1
Show special
 */