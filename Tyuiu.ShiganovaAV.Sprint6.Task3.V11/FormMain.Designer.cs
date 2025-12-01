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
            LoadMatrixToGrid();
        }

        private void ShowCondition()
        {
            textBoxCondition_SAV.Text = "Дан массив 5 на 5 элементов.\r\nВыполнить сортировку по возрастанию в первом столбце.\r\n\r\nИсходный массив:\r\n27 -15  14   2  27\r\n-8  14 -10  33   0\r\n1   7 -11 -11  23\r\n-13 -20  15 -16  34\r\n-3   1 -1   5   1";
        }

        private void LoadMatrixToGrid()
        {
            int[,] matrix = ds.GetMatrix();

            dataGridViewMatrix_SAV.ColumnCount = 5;
            dataGridViewMatrix_SAV.RowCount = 5;
            dataGridViewMatrix_SAV.RowHeadersVisible = false;
            dataGridViewMatrix_SAV.ColumnHeadersVisible = false;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewMatrix_SAV[j, i].Value = matrix[i, j];
                    dataGridViewMatrix_SAV[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void buttonExecute_SAV_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = ds.GetMatrix();
                int[,] sortedMatrix = SortFirstColumn(matrix);
                ShowResult(sortedMatrix);
                ShowResultInGrid(sortedMatrix);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int[,] SortFirstColumn(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (result[i, 0] > result[j, 0])
                    {
                        int temp = result[i, 0];
                        result[i, 0] = result[j, 0];
                        result[j, 0] = temp;
                    }
                }
            }

            return result;
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

        private void ShowResultInGrid(int[,] sortedMatrix)
        {
            dataGridViewResult_SAV.ColumnCount = 5;
            dataGridViewResult_SAV.RowCount = 5;
            dataGridViewResult_SAV.RowHeadersVisible = false;
            dataGridViewResult_SAV.ColumnHeadersVisible = false;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewResult_SAV[j, i].Value = sortedMatrix[i, j];
                    dataGridViewResult_SAV[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
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