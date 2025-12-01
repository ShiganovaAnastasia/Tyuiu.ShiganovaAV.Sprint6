using System;
using System.Windows.Forms;
using Tyuiu.ShiganovaAV.Sprint6.Task0.V19.Lib;

namespace Tyuiu.ShiganovaAV.Sprint6.Task0.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBoxVarX_SAV.Text = "3";
        }

        private void buttonDone_SAV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int x = Convert.ToInt32(textBoxVarX_SAV.Text);
                double result = ds.Calculate(x);
                textBoxResult_SAV.Text = result.ToString("F3");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_SAV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РИСб-23-1 Шиганова Анастасия Викторовна",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private PictureBox pictureBoxLogo_SAV;
    }
}