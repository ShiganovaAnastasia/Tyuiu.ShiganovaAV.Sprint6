using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ShiganovaAV.Sprint6.Task2.V12.Lib;

namespace Tyuiu.ShiganovaAV.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetupChart();

            textBoxStart_SAV.Text = "-5";
            textBoxStop_SAV.Text = "5";
        }

        private void SetupChart()
        {
            chartFunction_SAV.Titles.Clear();
            chartFunction_SAV.Series.Clear();
            chartFunction_SAV.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainChartArea");
            chartArea.AxisX.Title = "X";
            chartArea.AxisY.Title = "F(x)";
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartFunction_SAV.ChartAreas.Add(chartArea);

            Series series = new Series("Function");
            series.ChartType = SeriesChartType.Spline;
            series.Color = Color.RoyalBlue;
            series.BorderWidth = 3;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.MarkerColor = Color.Red;
            chartFunction_SAV.Series.Add(series);
        }

        private void buttonDone_SAV_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_SAV.Text);
                int stopValue = Convert.ToInt32(textBoxStop_SAV.Text);

                if (startValue > stopValue)
                {
                    MessageBox.Show("Начальное значение не может быть больше конечного!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataService ds = new DataService();

                double[] values = ds.GetMassFunction(startValue, stopValue);

                dataGridViewResult_SAV.Rows.Clear();
                chartFunction_SAV.Series["Function"].Points.Clear();

                int count = 0;
                for (int x = startValue; x <= stopValue; x++)
                {
                    dataGridViewResult_SAV.Rows.Add(x.ToString(), values[count].ToString("F2"));

                    chartFunction_SAV.Series["Function"].Points.AddXY(x, values[count]);

                    count++;
                }

                chartFunction_SAV.Titles.Clear();
                chartFunction_SAV.Titles.Add($"График функции F(x) = (2x+6)/(cos(x)+x) - 3");

                dataGridViewResult_SAV.Columns[0].HeaderText = "X";
                dataGridViewResult_SAV.Columns[1].HeaderText = "F(x)";

                labelInfo_SAV.Text = $"Количество точек: {values.Length}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные целочисленные значения!",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 вариант 12 выполнил студент группы ПИНб-25-1 Шиганова Анастасия Владимировна",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_SAV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && ((TextBox)sender).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void textBoxStop_SAV_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxStart_SAV_KeyPress(sender, e);
        }
    }
}