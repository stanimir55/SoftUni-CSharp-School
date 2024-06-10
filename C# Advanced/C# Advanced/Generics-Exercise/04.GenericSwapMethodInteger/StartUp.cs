namespace _04.GenericSwapMethodInteger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < linesCount; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Items.Add(input);
            }

            int[] swapIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            box.Swap(swapIndexes[0], swapIndexes[1]);

            Console.WriteLine(box.ToString());

        }
    }
}

/*
3
7
123
42
0 2
 */