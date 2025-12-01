using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.ShiganovaAV.Sprint6.Task3.V11.Lib;

namespace Tyuiu.ShiganovaAV.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
            ShowCondition();
        }

        private void ShowCondition()
        {
            textBoxCondition_SAV.Text = "Дан массив 5 на 5 элементов.\r\nВыполнить сортировку по возрастанию в первом столбце.\r\n\r\nИсходный массив:\r\n27 -15  14   2  27\r\n-8  14 -10  33   0\r\n1   7 -11 -11  23\r\n-13 -20  15 -16  34\r\n-3   1 -1   5   1";
        }

        private void buttonDone_SAV_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = ds.GetMatrix();
                int[,] sortedMatrix = ds.Calculate(matrix);
                ShowResult(sortedMatrix);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowResult(int[,] sortedMatrix)
        {
            textBoxResult_SAV.Clear();
            textBoxResult_SAV.AppendText("Результат:" + Environment.NewLine + Environment.NewLine);

            for (int i = 0; i < 5; i++)
            {
                string row = "";
                for (int j = 0; j < 5; j++)
                {
                    row += sortedMatrix[i, j].ToString().PadLeft(4);
                }
                textBoxResult_SAV.AppendText(row + Environment.NewLine);
            }

            textBoxResult_SAV.AppendText(Environment.NewLine + "Первый столбец отсортирован:" + Environment.NewLine);
            for (int i = 0; i < 5; i++)
            {
                textBoxResult_SAV.AppendText(sortedMatrix[i, 0].ToString().PadLeft(4) + " ");
            }
        }

        private void textBoxStart_SAV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            string info = "Таск 3 вариант 11 выполнил студент группы ПИНб-25-1\r\nШиганова Анастасия Владимировна";
            MessageBox.Show(info, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}