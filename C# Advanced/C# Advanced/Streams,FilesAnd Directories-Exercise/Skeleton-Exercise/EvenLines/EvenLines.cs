namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using StreamReader streamReader = new(inputFilePath);
            StringBuilder sb = new StringBuilder();
            int counter = 0;

            while (true)
            {
                string line = streamReader.ReadLine();
                if (line == null)
                {
                    break;
                }

                if (counter % 2 == 0)
                {
                    string[] words = line.Split().Reverse().ToArray();
                    string text = string.Join(" ", words);
                    sb.AppendLine(text);
                }

                counter++;
            }

            char[] symbols = { '-', ',', '.', '!', '?' };

            for (int i = 0; i < symbols.Length; i++)
            {
                sb = sb.Replace(symbols[i], '@');
            }

            return sb.ToString().TrimEnd();
        }
    }
}
