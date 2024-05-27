namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using StreamReader readerWords = new(wordsFilePath);
            using StreamReader readerText = new(textFilePath);
            using StreamWriter writer = new(outputFilePath);
            Dictionary<string, int> counts = new Dictionary<string, int>();

            string[] words = readerWords.ReadLine().ToLower().Split();
            string text = readerText.ReadToEnd().ToLower();

            foreach (string word in words)
            {
                string pattern = string.Format(@"\b{0}\b", word);
                MatchCollection matches = Regex.Matches(text, pattern);

                if (!counts.ContainsKey(word))
                {
                    counts[word] = matches.Count;
                }
            }

            foreach (var (key, value) in counts.OrderByDescending(x => x.Value))
            {
                writer.WriteLine($"{key} - {value}");
            }
        }
    }
}
