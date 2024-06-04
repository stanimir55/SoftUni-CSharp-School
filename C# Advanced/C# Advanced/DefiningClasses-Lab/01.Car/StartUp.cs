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

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}