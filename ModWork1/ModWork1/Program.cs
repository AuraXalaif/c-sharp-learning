using ModWork1;
class Program
{
    static void Main(string[] args)
    {
        string inputPath = "textPD25.txt";
        string outputPath = "resultPD25.txt";


        File.WriteAllText(outputPath, string.Empty);

        ProcessFile processFile = new ProcessFile();
        TextOperations textOperations = new TextOperations();


        File.AppendAllText(outputPath, "=== UPPERCASE ===" + Environment.NewLine);
        processFile.Process(inputPath, outputPath, textOperations.ToUpperCase);


        File.AppendAllText(outputPath, Environment.NewLine + "=== КІЛЬКІСТЬ СИМВОЛІВ ===" + Environment.NewLine);
        processFile.Process(inputPath, outputPath, textOperations.CountSymbols);


        File.AppendAllText(outputPath, Environment.NewLine + "=== КІЛЬКІСТЬ СЛІВ ===" + Environment.NewLine);
        processFile.Process(inputPath, outputPath, textOperations.CountWords);

        Console.WriteLine($"\nГотово! Результати збережено у {outputPath}");
    }
}