namespace GenericArrayCreator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ",ArrayCreator.Create(20, "T")));
        }
    }
}
