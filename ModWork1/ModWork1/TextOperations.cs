using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModWork1;

public class TextOperations
{

    public delegate string TextOperation(string text);

    public string ToUpperCase(string text)
    {
        string result = text.ToUpper();
        return $"Текст в Upper Case: {result}";
    }

    public string CountSymbols(string text)
    {
        int symbolsCount = 0;
        for (int i = 0; i < text.Length; i++)
        {
            symbolsCount++;
        }
        return $"Кількість символів: {symbolsCount}";
    }

    public string CountWords(string text)
    {
        int wordsCount = 0;
        if (text.Trim().Length > 0)
        {
            wordsCount = 1;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' && i + 1 < text.Length && text[i + 1] != ' ')
                {
                    wordsCount++;
                }
            }
        }
        return $"Кількість слів: {wordsCount}";
    }
}
