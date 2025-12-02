using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShiganovaAV.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            string[] lines = File.ReadAllLines(path);
            double[] result = new double[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Replace(',', '.');
                result[i] = Convert.ToDouble(line);
            }

            return result;
        }
    }
}