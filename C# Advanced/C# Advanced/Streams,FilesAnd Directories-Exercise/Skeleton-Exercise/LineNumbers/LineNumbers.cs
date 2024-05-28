namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            var allLines = File.ReadAllLines(inputFilePath);
            StringBuilder sb = new StringBuilder();

            int counter = 1;
            
            foreach (var line in allLines)
            {
                int countOfLetters = line.Count(char.IsLetter);
                int countOfPunctiantions = line.Count(char.IsPunctuation);

                sb.AppendLine($"Line {counter}: {line} ({countOfLetters})({countOfPunctiantions}) (37)(4)");
            }

            File.WriteAllText(outputFilePath, sb.ToString().TrimEnd());
        }
    }
}
