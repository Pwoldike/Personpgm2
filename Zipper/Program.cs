using System.IO.Compression;

namespace Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = @"E:\example\start";
            string zipPath = @"E:\example\resultat.zip";
            string extractPath = @"E:\example\extract";

            NewMethod(startPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }

        private static void NewMethod(string startPath, string zipPath)
        {
            System.IO.Compression.ZipFile.CreateFromDirectory(startPath, zipPath);
        }
    }
}
