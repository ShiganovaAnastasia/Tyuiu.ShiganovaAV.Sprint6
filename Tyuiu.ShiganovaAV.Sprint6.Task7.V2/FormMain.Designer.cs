using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Tyuiu.ShiganovaAV.Sprint6.Task7.V2
{
    public partial class FormMain : Form
    {
        private string[,] matrixData;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_SAV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV файлы|*.csv|Все файлы|*.*";
            openFileDialog.Title = "Открыть CSV файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadCSVFile(openFileDialog.FileName);
                    buttonSave_SAV.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCSVFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            matrixData = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    matrixData[i, j] = values[j];
                }
            }

            ShowMatrix(dataGridViewIn_SAV, matrixData);
            ShowMatrix(dataGridViewOut_SAV, matrixData);
        }

        private void ShowMatrix(DataGridView grid, string[,] data)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                grid.Columns.Add($"Col{j}", j.ToString());
            }

            for (int i = 0; i < rows; i++)
            {
                string[] row = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = data[i, j];
                }
                grid.Rows.Add(row);
            }
        }

        private void buttonSave_SAV_Click(object sender, EventArgs e)
        {
            if (matrixData == null) return;

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV файлы|*.csv|Все файлы|*.*";
            saveDialog.FileName = "OutPutFileTask7.csv";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                SaveCSVFile(saveDialog.FileName);
                MessageBox.Show("Файл сохранен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveCSVFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                int rows = matrixData.GetLength(0);
                int cols = matrixData.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(matrixData[i, j]);
                        if (j < cols - 1) writer.Write(";");
                    }
                    writer.WriteLine();
                }
            }
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            Form infoForm = new Form();
            infoForm.Text = "О программе";
            infoForm.Size = new Size(550, 350);
            infoForm.StartPosition = FormStartPosition.CenterParent;
            infoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            infoForm.MaximizeBox = false;
            infoForm.MinimizeBox = false;

            PictureBox pictureBox = new PictureBox();

            try
            {
                if (File.Exists(@"C:\DataSprint6\dXT6NC73beaDC3Km3EFjGBur_8wudhSei6JL3v0CuIfJpxw0znzsGYslgfH-4QY94S8l-DkRcXNT3Lp2yZoQRl6G.jpg"))
                {
                    pictureBox.Image = Image.FromFile(@"C:\DataSprint6\dXT6NC73beaDC3Km3EFjGBur_8wudhSei6JL3v0CuIfJpxw0znzsGYslgfH-4QY94S8l-DkRcXNT3Lp2yZoQRl6G.jpg");
                }
                else
                {
                    pictureBox.Image = SystemIcons.Information.ToBitmap();
                }
            }
            catch
            {
                pictureBox.Image = SystemIcons.Information.ToBitmap();
            }

            pictureBox.Location = new Point(20, 20);
            pictureBox.Size = new Size(150, 150);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;

            Label label = new Label();
            label.Location = new Point(180, 20);
            label.Size = new Size(350, 220);
            label.Text = "Разработчик: Шиганова А.В.\n" +
                         "Группа: ПИНб-25-1\n\n" + "Программа разработана в рамках изучения языка C#\n\n" +
                         "Тюменский индустриальный университет (с) 2025\n" +
                         "Высшая школа цифровых технологий (с) 2025\n\n" +
                         "Внутреннее имя: Tyuiu.ShiganovaAV.Sprint6.Task7.V2";
            label.Font = new Font("Microsoft Sans Serif", 9F);

            Button button = new Button();
            button.Text = "OK";
            button.Location = new Point(235, 250);
            button.Size = new Size(80, 30);
            button.Click += (s, args) => infoForm.Close();

            infoForm.Controls.Add(pictureBox);
            infoForm.Controls.Add(label);
            infoForm.Controls.Add(button);
            infoForm.ShowDialog();
        }
    }
}