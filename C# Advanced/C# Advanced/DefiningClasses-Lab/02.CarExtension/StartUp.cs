using System;
using System.Runtime.ConstrainedExecution;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "Golf";
            car.Year = 2005;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;

            car.Drive(2000);

            Console.WriteLine(car.WhoAmi());
        }
    }
}