namespace _02.GenericBoxOfInteger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);

                Console.WriteLine(box.ToString());
            }
        }
    }
}