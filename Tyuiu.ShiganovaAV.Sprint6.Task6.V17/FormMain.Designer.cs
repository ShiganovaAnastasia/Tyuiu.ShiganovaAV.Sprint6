using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace Tyuiu.ShiganovaAV.Sprint6.Task6.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Text = "Спринт 6 | Таск 6 | Вариант 17 | Шиганова А.В.";
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из полей ввода
                double startValue = Convert.ToDouble(textBoxStart.Text);
                double stopValue = Convert.ToDouble(textBoxStop.Text);
                double step = Convert.ToDouble(textBoxStep.Text);

                // Очищаем таблицу и график
                dataGridView.Rows.Clear();
                chart.Series[0].Points.Clear();

                // Добавляем заголовки столбцов
                if (dataGridView.Columns.Count == 0)
                {
                    dataGridView.Columns.Add("X", "X");
                    dataGridView.Columns.Add("F(X)", "F(X)");
                }

                // Вычисляем значения функции
                double x = startValue;
                int rowIndex = 0;

                while (x <= stopValue)
                {
                    // Вычисляем sin(x)
                    double result = Math.Sin(x);

                    // Добавляем в таблицу
                    dataGridView.Rows.Add();
                    dataGridView.Rows[rowIndex].Cells["X"].Value = Math.Round(x, 2);
                    dataGridView.Rows[rowIndex].Cells["F(X)"].Value = Math.Round(result, 2);

                    // Добавляем точку на график
                    chart.Series[0].Points.AddXY(Math.Round(x, 2), Math.Round(result, 2));

                    x += step;
                    rowIndex++;
                }

                // Настраиваем график
                chart.ChartAreas[0].AxisX.Title = "X";
                chart.ChartAreas[0].AxisY.Title = "F(X) = sin(x)";
                chart.Series[0].ChartType = SeriesChartType.Line;
                chart.Series[0].Name = "sin(x)";
                chart.Titles.Clear();
                chart.Titles.Add("График функции sin(x)");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода. Пожалуйста, введите числовые значения.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6. Вариант 17.\n" +
                           "Выполнила: Шиганова А.В.\n\n" +
                           "Программа вычисляет значения функции sin(x) на заданном диапазоне.\n" +
                           "1. Введите начальное значение (Старт шага)\n" +
                           "2. Введите конечное значение (Конец шага)\n" +
                           "3. Введите шаг вычислений\n" +
                           "4. Нажмите 'Выполнить' для расчета и построения графика",
                           "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}