namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            EqualityScale<int> equalityScale = new EqualityScale<int>(10, 10);
            Console.WriteLine(equalityScale.AreEqual());
        }
    }
}
