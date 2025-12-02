using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ShiganovaAV.Sprint6.Task5.V27.Lib;

namespace Tyutu.ShiganovaAV.Sprint6.Task5.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DataSprint6\InPutDataFileTask5V27.txt";

                if (!File.Exists(path))
                {
                    MessageBox.Show($"Файл не найден: {path}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Чтение данных из файла
                string[] lines = File.ReadAllLines(path);

                // Очищаем DataGridView и Chart
                dataGridView.Rows.Clear();
                chart.Series[0].Points.Clear();

                // Добавляем столбцы в DataGridView
                if (dataGridView.Columns.Count == 0)
                {
                    dataGridView.Columns.Add("Index", "№");
                    dataGridView.Columns.Add("Value", "Значение");
                }

                int index = 1;
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // Парсим число (учёт разделителя запятой для десятичных дробей)
                    if (double.TryParse(line.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double value))
                    {
                        // Проверяем, что число НЕ кратно 5
                        if (Math.Abs(value % 5) > 0.001) // Учитываем погрешность для вещественных чисел
                        {
                            // Округляем до 3 знаков после запятой
                            double roundedValue = Math.Round(value, 3);

                            // Добавляем в DataGridView
                            dataGridView.Rows.Add(index, roundedValue.ToString("F3"));

                            // Добавляем в диаграмму
                            chart.Series[0].Points.AddXY(index, roundedValue);
                            chart.Series[0].Points.Last().ToolTip = $"Значение: {roundedValue:F3}";

                            index++;
                        }
                    }
                }

                // Настройка диаграммы
                chart.ChartAreas[0].AxisX.Title = "Номер элемента";
                chart.ChartAreas[0].AxisY.Title = "Значение";
                chart.Series[0].ChartType = SeriesChartType.Column;
                chart.Series[0].Name = "Значения не кратные 5";
                chart.Titles.Clear();
                chart.Titles.Add("Диаграмма значений (не кратные 5)");

                MessageBox.Show($"Обработано {lines.Length} строк. Выведено {dataGridView.Rows.Count} значений не кратных 5.",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5. Вариант 27.\n" +
                           "Выполнила: Шиганова А.В.\n\n" +
                           "1. Нажмите 'Открыть файл' для загрузки данных\n" +
                           "2. В таблице выводятся только значения НЕ кратные 5\n" +
                           "3. Вещественные значения округлены до 3 знаков после запятой\n" +
                           "4. По этим значениям строится столбчатая диаграмма",
                           "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}