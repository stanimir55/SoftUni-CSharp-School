﻿using System;
using System.Reflection;

namespace _06.SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public bool CanMove(double distance)
        {
            return distance * FuelConsumptionPerKilometer <= FuelAmount;
        }
        public void Drive(double distance)
        {
            FuelAmount -= distance * FuelConsumptionPerKilometer;
            TravelledDistance += distance;
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TravelledDistance}";
        }
    }
}

