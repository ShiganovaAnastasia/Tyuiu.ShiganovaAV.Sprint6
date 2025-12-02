using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

namespace Tyuiu.ShiganovaAV.Sprint6.Task5.V27.Lib
{
    public class DataService
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            string[] lines = File.ReadAllLines(path);
            List<double> result = new List<double>();

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string normalizedLine = line.Replace(',', '.');

                if (double.TryParse(normalizedLine,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out double number))
                {
                    if (Math.Abs(number % 5) > 0.00001)
                    {
                        double roundedNumber = Math.Round(number, 3);
                        result.Add(roundedNumber);
                    }
                }
                else
                {
                    Console.WriteLine($"Не удалось распарсить строку: '{line}'");
                }
            }

            if (result.Count == 0)
            {
                return new double[] { 0 };
            }

            return result.ToArray();
        }
    }
}