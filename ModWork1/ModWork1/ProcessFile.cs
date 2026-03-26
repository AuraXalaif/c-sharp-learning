using ModWork1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModWork1;

public class ProcessFile
{
    private TextOperations TextOperations = new TextOperations();

    public void Process(string inputPath, string outputPath, TextOperations.TextOperation operation)
    {
        using (FileStream fsRead = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
        using (StreamReader sr = new StreamReader(fsRead))
        {
            string line;
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
        using (FileStream fs = new FileStream(outputPath, FileMode.Append, FileAccess.Write))
        using (StreamWriter sw = new StreamWriter(fs))
        {
            sw.WriteLine(line);
        }
    }
}