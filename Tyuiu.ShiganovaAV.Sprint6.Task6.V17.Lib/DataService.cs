using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShiganovaAV.Sprint6.Task6.V17.Lib
{
    public class DataService : ISprint6Task6V17
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            string[] lines = File.ReadAllLines(path);
            List<string> resultWords = new List<string>();

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length >= 3)
                {
                    resultWords.Add(words[2]);
                }
            }

            return string.Join(" ", resultWords);
        }
    }
}