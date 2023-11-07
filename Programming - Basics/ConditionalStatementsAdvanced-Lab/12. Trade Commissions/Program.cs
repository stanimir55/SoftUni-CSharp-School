using System;

string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());
double commission = 0;

if (sales <= 500)
{
    switch (city)
    {
        case "Sofia":
            if (sales < 0)
            {
                Console.WriteLine("error"); break;
            }
            else if (city != "Sofia") 
            {
                Console.WriteLine("error");break;
            }
            commission = sales * 0.05;
            Console.WriteLine($"{commission:F2}"); break;
        case "Varna":
            if (sales < 0)
            {
                Console.WriteLine("error");break;
            }
            else if (city != "Varna")
            {
                Console.WriteLine("error");break;
            }
            commission = sales * 0.045;
            Console.WriteLine($"{commission:F2}"); break;
        case "Plovdiv":
            if (sales < 0)
            {
                Console.WriteLine("error"); break;
            }
            else if (city != "Plovdiv")
            {
                Console.WriteLine("error");break;
            }
            commission = sales * 0.055;
            Console.WriteLine($"{commission:F2}"); break;
        default:
            Console.WriteLine("error"); break;
    }
}
else if (sales <= 1000)
{
    switch (city)
    {
        case "Sofia":
            commission = sales * 0.07;
            Console.WriteLine($"{commission:F2}"); break;
        case "Varna":
            commission = sales * 0.075;
            Console.WriteLine($"{commission:F2}"); break;
        case "Plovdiv":
            commission = sales * 0.08;
            Console.WriteLine($"{commission:F2}"); break;
        default:
            Console.WriteLine("error");break;
    }

}
else if (sales <= 10000)
{
    switch (city)
    {
        case "Sofia":
            commission = sales * 0.08;
            Console.WriteLine($"{commission:F2}"); break;
        case "Varna":
            commission = sales * 0.10;
            Console.WriteLine($"{commission:F2}"); break;
        case "Plovdiv":
            commission = sales * 0.12;
            Console.WriteLine($"{commission:F2}"); break;
        default:
            Console.WriteLine("error"); break;
    }
}
else if (sales > 10000)
{
    switch (city)
    {
        case "Sofia":
            commission = sales * 0.12;
            Console.WriteLine($"{commission:F2}"); break;
        case "Varna":
            commission = sales * 0.13;
            Console.WriteLine($"{commission:F2}"); break;
        case "Plovdiv":
            commission = sales * 0.145;
            Console.WriteLine($"{commission:F2}"); break;
    }
}
