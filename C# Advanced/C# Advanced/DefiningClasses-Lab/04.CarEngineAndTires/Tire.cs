﻿namespace CarManufacturer;

public class Tire
{
    private int year;
    private double pressure;

    public Tire(int year, double pressure)
    {
        Year = year;
        Pressure = pressure;
    }

    public int Year
    {
        get
        {
            return this.year;
        }
        set
        {
            this.year = value;
        }
    }

    public double Pressure
    {
        get
        {
            return this.pressure;
        }
        set
        {
            this.pressure = value;
        }
    }
}