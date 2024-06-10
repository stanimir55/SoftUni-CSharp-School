namespace _03.GenericSwapMethodString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < linesCount; i++)
            {
                string input = Console.ReadLine();
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
Peter
George
Swap me with Peter
0 2
 */