using System;
using System.Text;
using System.Windows.Forms;
using Tyuiu.ShiganovaAV.Sprint6.Task1.V26.Lib;

namespace Tyuiu.ShiganovaAV.Sprint6.Task1.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_SAV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_SAV.Text);
                int end = Convert.ToInt32(textBoxEnd_SAV.Text);

                if (start > end)
                {
                    MessageBox.Show("Начальное значение должно быть меньше конечного",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataService ds = new DataService();

                double[] values = ds.GetMassFunction(start, end);

                StringBuilder result = new StringBuilder();
                result.AppendLine("Табулирование функции:");
                result.AppendLine("F(x) = (2cos(x)+2)/(2x-1) + cos(x) - 5x + 3");
                result.AppendLine($"Диапазон: [{start}; {end}], шаг = 1");
                result.AppendLine();
                result.AppendLine("┌───────┬──────────┐");
                result.AppendLine("│   X   │   F(x)   │");
                result.AppendLine("├───────┼──────────┤");

                int index = 0;
                for (int x = start; x <= end; x++)
                {
                    double y = values[index];
                    result.AppendLine($"│ {x,5} │ {y,8:F2} │");
                    index++;
                }

                result.AppendLine("└───────┴──────────┘");
                result.AppendLine();
                result.AppendLine($"Всего значений: {values.Length}");

                textBoxResult_SAV.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены неверные данные. Используйте целые числа.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStart_SAV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '-' && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && ((TextBox)sender).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void textBoxEnd_SAV_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxStart_SAV_KeyPress(sender, e);
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 вариант 26 выполнил студент группы ПИНб-25-1 Шиганова Анастасия Владимировна",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}