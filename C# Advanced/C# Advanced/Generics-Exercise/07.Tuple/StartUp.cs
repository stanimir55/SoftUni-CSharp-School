namespace _07.Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            string[] alcholicPerson = Console.ReadLine().Split();
            string[] values = Console.ReadLine().Split();

            string personName = personInfo[0] + " " + personInfo[1];
            string personTown = personInfo[2];

            string alcholicName = alcholicPerson[0];
            int alcholicLiters = int.Parse(alcholicPerson[1]);

            int integerValue = int.Parse(values[0]);
            double doubleValue = double.Parse(values[1]);

            var personInfoTuple = new MyTuple<string, string>(personName, personTown);
            var AlcholicPErsonTuple = new MyTuple<string, int>(alcholicName, alcholicLiters);
            var valuesTuple = new MyTuple<int, double>(integerValue, doubleValue);

            Console.WriteLine($"{personInfoTuple.Item1} -> {personInfoTuple.Item2}");
            Console.WriteLine($"{AlcholicPErsonTuple.Item1} -> {AlcholicPErsonTuple.Item2}");
            Console.WriteLine($"{valuesTuple.Item1} -> {valuesTuple.Item2}");
        }
    }

    /*
Adam Smith California
Mark 2
23 21.23212321
     */
}