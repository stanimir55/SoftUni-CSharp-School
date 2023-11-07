int windowsNum = int.Parse(Console.ReadLine());
string windowsType = Console.ReadLine();
string shipment = Console.ReadLine();

double price = 0;
double totalPrice = 0;

if (windowsNum < 10)
{
    Console.WriteLine("Invalid order");
}
else if (windowsType == "90X130")
{
    price = windowsNum * 110;
    if (windowsNum >= 10)
    {
        totalPrice = windowsNum * 190;
    }
    if (windowsNum > 30)
    {
        totalPrice = price - price * 0.05;
    }
    if (windowsNum > 60)
    {
        totalPrice = price - price * 0.08;
    }
    if (shipment == "With delivery")
    {
        totalPrice = totalPrice + 60;
    }
    if (windowsNum > 99)
    {
        totalPrice = totalPrice - totalPrice * 0.04;
    }
    Console.WriteLine($"{totalPrice:F2} BGN");
}
else if (windowsType == "100X150")
{
    price = windowsNum * 140;
    if (windowsNum >= 10)
    {
        totalPrice = windowsNum * 190;
    }
    if (windowsNum > 40)
    {
        totalPrice = price - price * 0.06;
    }
    if (windowsNum > 80)
    {
        totalPrice = price - price * 0.10;
    }
    if (shipment == "With delivery")
    {
        totalPrice = totalPrice + 60;
    }
    if (windowsNum > 99)
    {
        totalPrice = totalPrice - totalPrice * 0.04;
    }
    Console.WriteLine($"{totalPrice:F2} BGN");
}
else if (windowsType == "130X180")
{
    price = windowsNum * 190;
    if (windowsNum >= 10)
    {
        totalPrice = windowsNum * 190;
    }
    if (windowsNum > 20)
    {
        totalPrice = price - price * 0.07;
    }
    if (windowsNum > 50)
    {
        totalPrice = price - price * 0.12;
    }
    if (shipment == "With delivery")
    {
        totalPrice = totalPrice + 60;
    }
    if (windowsNum > 99)
    {
        totalPrice = totalPrice - totalPrice * 0.04;
    }
    Console.WriteLine($"{totalPrice:F2} BGN");
}
else if (windowsType == "200X300")
{
    price = windowsNum * 250;
    if (windowsNum >= 10)
    {
        totalPrice = windowsNum * 190;
    }
    if (windowsNum > 25)
    {
        totalPrice = price - price * 0.09;
    }
    if (windowsNum > 50)
    {
        totalPrice = price - price * 0.14;
    }
    if (shipment == "With delivery")
    {
        totalPrice = totalPrice + 60;
    }
    if (windowsNum > 99)
    {
        totalPrice = totalPrice - totalPrice * 0.04;
    }
    Console.WriteLine($"{totalPrice:F2} BGN");
}


//using System;

//namespace _02.Add_Bags
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int windowsNum = int.Parse(Console.ReadLine());
//            string windowsType = Console.ReadLine();
//            string shipment = Console.ReadLine();

//            double price = 0;
//            double totalPrice = 0;

//            if (windowsNum < 10)
//            {
//                Console.WriteLine("Invalid order");
//            }
//            else if (windowsType == "90X130")
//            {
//                price = windowsNum * 110;
//                if (windowsNum > 30)
//                {
//                    totalPrice = price - price * 0.05;

//                }
//                if (windowsNum > 60)
//                {
//                    totalPrice = price - price * 0.08;

//                }
//                if (shipment == "With delivery")
//                {
//                    totalPrice = totalPrice + 60;
//                }
//                if (windowsNum > 99)
//                {
//                    totalPrice = totalPrice - totalPrice * 0.04;
//                }
//                Console.WriteLine($"{totalPrice:F2} BGN");
//            }
//            else if (windowsType == "100X150")
//            {
//                price = windowsNum * 140;
//                if (windowsNum > 40)
//                {
//                    totalPrice = price - price * 0.06;

//                }
//                if (windowsNum > 80)
//                {
//                    totalPrice = price - price * 0.10;

//                }
//                if (shipment == "With delivery")
//                {
//                    totalPrice = totalPrice + 60;
//                }
//                if (windowsNum > 99)
//                {
//                    totalPrice = totalPrice - totalPrice * 0.04;
//                }
//                Console.WriteLine($"{totalPrice:F2} BGN");
//            }
//            else if (windowsType == "130X180")
//            {
//                price = windowsNum * 190;
//                if (windowsNum > 20)
//                {
//                    totalPrice = price - price * 0.07;

//                }
//                if (windowsNum > 50)
//                {
//                    totalPrice = price - price * 0.12;

//                }
//                if (shipment == "With delivery")
//                {
//                    totalPrice = totalPrice + 60;
//                }
//                if (windowsNum > 99)
//                {
//                    totalPrice = totalPrice - totalPrice * 0.04;
//                }
//                Console.WriteLine($"{totalPrice:F2} BGN");
//            }
//            else if (windowsType == "200X300")
//            {
//                price = windowsNum * 250;
//                if (windowsNum > 25)
//                {
//                    totalPrice = price - price * 0.09;

//                }
//                if (windowsNum > 50)
//                {
//                    totalPrice = price - price * 0.14;

//                }
//                if (shipment == "With delivery")
//                {
//                    totalPrice = totalPrice + 60;
//                }
//                if (windowsNum > 99)
//                {
//                    totalPrice = totalPrice - totalPrice * 0.04;
//                }
//                Console.WriteLine($"{totalPrice:F2} BGN");
//            }

//            else if (windowsNum < 10)
//            {
//                Console.WriteLine("Invalid order");
//            }


//        }
//    }
//}















