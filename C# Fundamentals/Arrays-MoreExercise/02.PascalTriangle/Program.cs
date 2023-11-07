int n = int.Parse(Console.ReadLine());

int[] row = new int[n];
int[] current = new int[n];
row[0] = 1;

Console.WriteLine(row[0]);

for (int i = 1; i < n; i++)
{
    current[0] = 1;
     
    Console.Write(current[0] + " ");

    for (int k = 1; k <= i; k++)
    {
        current[k] = row[k - 1] + row[k];

        Console.Write(current[k] + " ");

    }
    for (int m = 0; m < n; m++)
    {
        row[m] = current[m];
    }
    Console.WriteLine();
}


//int n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    int a = 1;

//    for (int k = 1; k <= i; k++)
//    {
//        Console.Write( a + " ");

//        a = a * (i - k) / k;
//    }
//    Console.WriteLine();
//}