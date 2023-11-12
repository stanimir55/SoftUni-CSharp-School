int number = int.Parse(Console.ReadLine());

int[] arr = new int[number];

FillArray(number, arr);
PrintMatrix(arr);

static void FillArray(int number, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number;
    }
}

void PrintMatrix(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(string.Join(" ", arr));
    }

}
