namespace _06.GenericCountMethodDouble
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < linesCount; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Items.Add(input);
            }

            double valueToCompare = double.Parse(Console.ReadLine());

            int count = box.CountOfLargerElements(valueToCompare);

            Console.WriteLine(count);
        }
    }
}

/*
3
7.13
123.22
42.78
7.55
 */