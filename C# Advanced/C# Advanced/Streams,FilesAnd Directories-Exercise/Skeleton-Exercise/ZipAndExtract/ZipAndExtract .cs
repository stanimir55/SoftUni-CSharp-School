namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"/Users/stanimirdimitrov/Desktop/Softuni/C# Advanced/C# Advanced/Streams,FilesAnd Directories-Exercise/Skeleton-Exercise";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\result";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            ZipFile.CreateFromDirectory(inputFilePath, zipArchiveFilePath);
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            ZipFile.ExtractToDirectory(zipArchiveFilePath, outputFilePath);
        }
    }
}
