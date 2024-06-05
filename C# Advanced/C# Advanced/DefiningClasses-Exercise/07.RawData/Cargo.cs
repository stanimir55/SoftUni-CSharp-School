using System;
namespace _07.RawData
{
	public class Cargo
	{
        public Cargo(string tyoe, int weight)
        {
            Tyoe = tyoe;
            Weight = weight;
        }

        public string Tyoe { get; set; }

		public int Weight { get; set; }
	}
}

