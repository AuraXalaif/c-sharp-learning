using System;
using System.IO;
using static ModWork1.TextOperations;

namespace ModWork1
{
    public class ProcessFile
    {
        public void Process(string inputPath, string outputPath, TextOperation operation)
        {
            using (var sr = new StreamReader(inputPath))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    string result = operation(line);
                    Console.WriteLine(result);
                    FileWriter(outputPath, result);
                }
            }
        }

        private void FileWriter(string outputPath, string line)
        {
            using (var sw = new StreamWriter(outputPath, true))
            {
                sw.WriteLine(line);
            }
        }
    }
}