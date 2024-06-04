using System;
namespace CarManufacturer
{
    public class Car
    {
        //public string Make { get; set; }

        //public string Model { get; set; }

        //public int Year { get; set; }

        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }
}
