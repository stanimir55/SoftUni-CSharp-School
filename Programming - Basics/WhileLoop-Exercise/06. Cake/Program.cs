//int lenthCake = int.Parse(Console.ReadLine());
//int widthCake = int.Parse(Console.ReadLine());
//int partsCake = lenthCake * widthCake;
//for (int i = 0; i < 1000000; i++)
//{
//    string partsC = Console.ReadLine();
//    if (partsC == "STOP")
//    {
//        Console.WriteLine("{0} pieces are left.", Math.Abs(partsCake));
//        break;
//    }
//    int parts = int.Parse(partsC);
//    partsCake = partsCake - parts;

//    if (partsCake < 0)
//    {
//        Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(partsCake)); break;
//    }

//}


int lenghtCake = int.Parse(Console.ReadLine());
int widthCake = int.Parse(Console.ReadLine());

int numCake = lenghtCake * widthCake;
string stop = "";

while (stop != "STOP")
{
    int input = int.Parse(Console.ReadLine());
    numCake = numCake - input;
    if (numCake < input)
    {
        numCake = numCake + input;
        Console.WriteLine($"No more cake left! You need {Math.Abs(numCake - input)} pieces more.");
        break;
    }

    stop = Console.ReadLine();
    if (stop == "STOP")
    {
        int leftOverCake = lenghtCake * widthCake;
        leftOverCake = leftOverCake - input;

        Console.WriteLine($"{leftOverCake - input} pieces are left.");
    }

}


