namespace _05.GenericCountMethodString
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

            string valueToCompare = Console.ReadLine();

            int count = box.CountOfLargerElements(valueToCompare);

            Console.WriteLine(count);
        }
    }
}

/*
3
aa
aaa
bb
aa
 */