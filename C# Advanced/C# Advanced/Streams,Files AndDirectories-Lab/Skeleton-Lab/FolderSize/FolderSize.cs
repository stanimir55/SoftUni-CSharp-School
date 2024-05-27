namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double size = 0;

            DirectoryInfo directoryInfo = new(folderPath);
            var fileInfos = directoryInfo.GetFiles("*", SearchOption.AllDirectories);

            foreach (var fileInfo in fileInfos)
            {
                size += fileInfo.Length;
            }

            File.WriteAllText(outputFilePath, $"{size / 1024} KB");
        }
    }
}
