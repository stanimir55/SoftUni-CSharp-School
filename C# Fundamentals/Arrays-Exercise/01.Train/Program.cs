int n = int.Parse(Console.ReadLine());

int[] wagons = new int[n];
int sum = 0;

for (int i = 0; i < n; i++)
{
    wagons[i] = int.Parse(Console.ReadLine());

    sum += wagons[i];
}
Console.WriteLine(string.Join(" ", wagons));
Console.WriteLine(sum);


//int n = int.Parse(Console.ReadLine());

//int sum = 0;

//for (int i = 0; i < n; i++)
//{
//    int wagons = int.Parse(Console.ReadLine());
//    sum += wagons;

//    Console.Write(wagons + " ");
//}

//Console.WriteLine();
//Console.WriteLine(sum);