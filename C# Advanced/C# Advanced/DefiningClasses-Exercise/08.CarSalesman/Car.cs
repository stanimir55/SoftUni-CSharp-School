using System;
using System.Text;

namespace _08.CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = null;
            Color = "n/a"; 
        }

        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int? Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Model}:");
            sb.AppendLine($"  {Engine.Model}:");
            sb.AppendLine($"    Power: {Engine.Power}");

            _ = Engine.Displacement == null ? sb.AppendLine($"     Displacement: n/a") : sb.AppendLine($"    Displacement: {Engine.Displacement}");

            sb.AppendLine($"    Efficiency: {Engine.Efficiency}");

            _ = Weight == null ? sb.AppendLine("  Weight: n/a") : sb.AppendLine($"  Weight: {Weight}");

            sb.AppendLine($"  Color: {Color}");

            return sb.ToString().TrimEnd();
        }
    }
}

