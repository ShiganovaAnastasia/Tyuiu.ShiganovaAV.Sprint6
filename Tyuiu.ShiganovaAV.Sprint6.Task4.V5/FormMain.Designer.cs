using System;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShiganovaAV.Sprint6.Task4.V5.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ShiganovaAV.Sprint6.Task4.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonResult_SAV_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_SAV.Text);
                int stopValue = Convert.ToInt32(textBoxStop_SAV.Text);

                double[] resultArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_SAV.Text = "Результаты табулирования функции:\r\n";
                textBoxResult_SAV.Text += "F(x) = (2*sin(x))/(3*x+1.2) + cos(x) - 7*x*2\r\n";
                textBoxResult_SAV.Text += "----------------------------------------\r\n";
                textBoxResult_SAV.Text += "   x   |   F(x)\r\n";
                textBoxResult_SAV.Text += "-------------------\r\n";

                for (int i = 0; i < resultArray.Length; i++)
                {
                    int x = startValue + i;
                    string line = $"{x,6} | {resultArray[i],8:F2}\r\n";
                    textBoxResult_SAV.AppendText(line);
                }

                // Рисуем график
                DrawGraph(resultArray, startValue, stopValue);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawGraph(double[] array, int start, int stop)
        {
            chartFunction_SAV.Series[0].Points.Clear();
            chartFunction_SAV.ChartAreas[0].AxisX.Title = "Ось X";
            chartFunction_SAV.ChartAreas[0].AxisY.Title = "F(x)";
            chartFunction_SAV.Titles.Clear();
            chartFunction_SAV.Titles.Add("График функции F(x)");

            for (int i = 0; i < array.Length; i++)
            {
                int x = start + i;
                chartFunction_SAV.Series[0].Points.AddXY(x, array[i]);
            }

            chartFunction_SAV.Series[0].ChartType = SeriesChartType.Line;
            chartFunction_SAV.Series[0].BorderWidth = 3;
            chartFunction_SAV.Series[0].Color = System.Drawing.Color.Blue;
        }

        private void buttonSave_SAV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V5.txt";

                int startValue = Convert.ToInt32(textBoxStart_SAV.Text);
                int stopValue = Convert.ToInt32(textBoxStop_SAV.Text);
                double[] resultArray = ds.GetMassFunction(startValue, stopValue);

                string str = "Табулирование функции F(x):\r\n";
                str += "F(x) = (2*sin(x))/(3*x+1.2) + cos(x) - 7*x*2\r\n\r\n";
                str += "x\tF(x)\r\n";
                str += "------------------------\r\n";

                for (int i = 0; i < resultArray.Length; i++)
                {
                    int x = startValue + i;
                    str += $"{x}\t{resultArray[i]:F2}\r\n";
                }

                File.WriteAllText(path, str);

                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранен успешно!\nОткрыть его в блокноте?",
                    "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("notepad.exe", path);
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ПИНб-25-1 Шиганова А.В.",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}