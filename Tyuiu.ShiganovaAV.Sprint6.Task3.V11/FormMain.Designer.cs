using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.ShiganovaAV.Sprint6.Task3.V11.Lib;

namespace Tyuiu.ShiganovaAV.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        private int[,] matrix = new int[5, 5]
        {
            { 27, -15, 14,  2, 27 },
            { -8,  14, -10, 33,  0 },
            {  1,   7, -11, -11, 23 },
            { -13, -20, 15, -16, 34 },
            { -3,   1, -1,   5,  1 }
        };

        public FormMain()
        {
            InitializeComponent();

            ShowCondition();

            ShowMatrix();
        }

        private void ShowCondition()
        {
            textBoxCondition_SAV.Text = "Дан массив 5 на 5 элементов.\r\n" +
                                       "Выполнить сортировку по возрастанию в первом столбце.\r\n\r\n" +
                                       "Исходный массив:\r\n" +
                                       "27 -15  14   2  27\r\n" +
                                       "-8  14 -10  33   0\r\n" +
                                       "1   7 -11 -11  23\r\n" +
                                       "-13 -20  15 -16  34\r\n" +
                                       "-3   1 -1   5   1";
        }

        private void ShowMatrix()
        {
            dataGridViewMatrix_SAV.Rows.Clear();
            dataGridViewMatrix_SAV.Columns.Clear();

            for (int j = 0; j < 5; j++)
            {
                dataGridViewMatrix_SAV.Columns.Add($"col{j}", $"");
                dataGridViewMatrix_SAV.Columns[j].Width = 40;
                dataGridViewMatrix_SAV.Columns[j].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            for (int i = 0; i < 5; i++)
            {
                dataGridViewMatrix_SAV.Rows.Add();
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewMatrix_SAV.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonExecute_SAV_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] sortedMatrix = ds.Calculate(matrix);

                ShowResultMatrix(sortedMatrix);

                ShowResultText(sortedMatrix);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowResultMatrix(int[,] sortedMatrix)
        {
            dataGridViewResult_SAV.Rows.Clear();
            dataGridViewResult_SAV.Columns.Clear();

            for (int j = 0; j < 5; j++)
            {
                dataGridViewResult_SAV.Columns.Add($"col{j}", $"");
                dataGridViewResult_SAV.Columns[j].Width = 40;
                dataGridViewResult_SAV.Columns[j].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            for (int i = 0; i < 5; i++)
            {
                dataGridViewResult_SAV.Rows.Add();
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewResult_SAV.Rows[i].Cells[j].Value = sortedMatrix[i, j];
                }
            }
        }

        private void ShowResultText(int[,] sortedMatrix)
        {
            textBoxResult_SAV.Clear();
            textBoxResult_SAV.AppendText("Результат:" + Environment.NewLine);
            textBoxResult_SAV.AppendText("Массив отсортирован по первому столбцу." + Environment.NewLine + Environment.NewLine);

            textBoxResult_SAV.AppendText("Первый столбец после сортировки:" + Environment.NewLine);
            for (int i = 0; i < 5; i++)
            {
                textBoxResult_SAV.AppendText(sortedMatrix[i, 0].ToString().PadLeft(4) + Environment.NewLine);
            }
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            string info = "Таск 3 вариант 11 выполнил студент группы ПИНб-25-1\r\n" +
                         "Шиганова Анастасия Владимировна";

            MessageBox.Show(info, "Справка",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_SAV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}