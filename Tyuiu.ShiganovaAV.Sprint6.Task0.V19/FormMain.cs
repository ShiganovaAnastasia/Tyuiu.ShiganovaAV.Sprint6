using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.ShiganovaAV.Sprint6.Task0.V19
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, созданный конструктором форм

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            labelCondition_SAV = new Label();
            labelTask_SAV = new Label();
            groupBoxInput_SAV = new GroupBox();
            labelVarX_SAV = new Label();
            textBoxVarX_SAV = new TextBox();
            groupBoxOutput_SAV = new GroupBox();
            labelResult_SAV = new Label();
            textBoxResult_SAV = new TextBox();
            buttonDone_SAV = new Button();
            buttonHelp_SAV = new Button();
            this.pictureBoxLogo_SAV = new PictureBox();
            groupBoxInput_SAV.SuspendLayout();
            groupBoxOutput_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.pictureBoxLogo_SAV).BeginInit();
            SuspendLayout();

            labelCondition_SAV.AutoSize = true;
            labelCondition_SAV.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCondition_SAV.Location = new Point(16, 14);
            labelCondition_SAV.Margin = new Padding(4, 0, 4, 0);
            labelCondition_SAV.Name = "labelCondition_SAV";
            labelCondition_SAV.Size = new Size(79, 20);
            labelCondition_SAV.TabIndex = 0;
            labelCondition_SAV.Text = "Условие";

            labelTask_SAV.AutoSize = true;
            labelTask_SAV.Font = new Font("Microsoft Sans Serif", 10F);
            labelTask_SAV.Location = new Point(16, 44);
            labelTask_SAV.Margin = new Padding(4, 0, 4, 0);
            labelTask_SAV.Name = "labelTask_SAV";
            labelTask_SAV.Size = new Size(283, 20);
            labelTask_SAV.TabIndex = 1;
            labelTask_SAV.Text = "Вычислить выражение при x = 3:";

            groupBoxInput_SAV.Controls.Add(labelVarX_SAV);
            groupBoxInput_SAV.Controls.Add(textBoxVarX_SAV);
            groupBoxInput_SAV.Location = new Point(16, 120);
            groupBoxInput_SAV.Margin = new Padding(4, 5, 4, 5);
            groupBoxInput_SAV.Name = "groupBoxInput_SAV";
            groupBoxInput_SAV.Padding = new Padding(4, 5, 4, 5);
            groupBoxInput_SAV.Size = new Size(300, 100);
            groupBoxInput_SAV.TabIndex = 3;
            groupBoxInput_SAV.TabStop = false;
            groupBoxInput_SAV.Text = "Ввод данных";

            labelVarX_SAV.AutoSize = true;
            labelVarX_SAV.Location = new Point(8, 35);
            labelVarX_SAV.Margin = new Padding(4, 0, 4, 0);
            labelVarX_SAV.Name = "labelVarX_SAV";
            labelVarX_SAV.Size = new Size(114, 20);
            labelVarX_SAV.TabIndex = 0;
            labelVarX_SAV.Text = "Переменная X:";

            textBoxVarX_SAV.Location = new Point(140, 32);
            textBoxVarX_SAV.Margin = new Padding(4, 5, 4, 5);
            textBoxVarX_SAV.Name = "textBoxVarX_SAV";
            textBoxVarX_SAV.Size = new Size(150, 27);
            textBoxVarX_SAV.TabIndex = 1;
            textBoxVarX_SAV.KeyPress += textBoxVarX_SAV_KeyPress;

            groupBoxOutput_SAV.Controls.Add(labelResult_SAV);
            groupBoxOutput_SAV.Controls.Add(textBoxResult_SAV);
            groupBoxOutput_SAV.Location = new Point(332, 120);
            groupBoxOutput_SAV.Margin = new Padding(4, 5, 4, 5);
            groupBoxOutput_SAV.Name = "groupBoxOutput_SAV";
            groupBoxOutput_SAV.Padding = new Padding(4, 5, 4, 5);
            groupBoxOutput_SAV.Size = new Size(300, 100);
            groupBoxOutput_SAV.TabIndex = 4;
            groupBoxOutput_SAV.TabStop = false;
            groupBoxOutput_SAV.Text = "Вывод данных";

            labelResult_SAV.AutoSize = true;
            labelResult_SAV.Location = new Point(8, 35);
            labelResult_SAV.Margin = new Padding(4, 0, 4, 0);
            labelResult_SAV.Name = "labelResult_SAV";
            labelResult_SAV.Size = new Size(78, 20);
            labelResult_SAV.TabIndex = 0;
            labelResult_SAV.Text = "Результат:";

            textBoxResult_SAV.Location = new Point(140, 32);
            textBoxResult_SAV.Margin = new Padding(4, 5, 4, 5);
            textBoxResult_SAV.Name = "textBoxResult_SAV";
            textBoxResult_SAV.ReadOnly = true;
            textBoxResult_SAV.Size = new Size(150, 27);
            textBoxResult_SAV.TabIndex = 1;

            buttonDone_SAV.Location = new Point(499, 242);
            buttonDone_SAV.Margin = new Padding(4, 5, 4, 5);
            buttonDone_SAV.Name = "buttonDone_SAV";
            buttonDone_SAV.Size = new Size(133, 46);
            buttonDone_SAV.TabIndex = 5;
            buttonDone_SAV.Text = "Выполнить";
            buttonDone_SAV.UseVisualStyleBackColor = true;
            buttonDone_SAV.Click += buttonDone_SAV_Click;

            buttonHelp_SAV.Location = new Point(447, 242);
            buttonHelp_SAV.Margin = new Padding(4, 5, 4, 5);
            buttonHelp_SAV.Name = "buttonHelp_SAV";
            buttonHelp_SAV.Size = new Size(44, 46);
            buttonHelp_SAV.TabIndex = 6;
            buttonHelp_SAV.Text = "?";
            buttonHelp_SAV.UseVisualStyleBackColor = true;
            buttonHelp_SAV.Click += buttonHelp_SAV_Click;

            this.pictureBoxLogo_SAV.Image = (Image)resources.GetObject("pictureBoxLogo_SAV.Image");
            this.pictureBoxLogo_SAV.Location = new Point(390, 14);
            this.pictureBoxLogo_SAV.Name = "pictureBoxLogo_SAV";
            this.pictureBoxLogo_SAV.Size = new Size(208, 62);
            this.pictureBoxLogo_SAV.TabIndex = 7;
            this.pictureBoxLogo_SAV.TabStop = false;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 302);
            Controls.Add(this.pictureBoxLogo_SAV);
            Controls.Add(buttonHelp_SAV);
            Controls.Add(buttonDone_SAV);
            Controls.Add(groupBoxOutput_SAV);
            Controls.Add(groupBoxInput_SAV);
            Controls.Add(labelTask_SAV);
            Controls.Add(labelCondition_SAV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 19 | Шиганова А.В.";
            groupBoxInput_SAV.ResumeLayout(false);
            groupBoxInput_SAV.PerformLayout();
            groupBoxOutput_SAV.ResumeLayout(false);
            groupBoxOutput_SAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.pictureBoxLogo_SAV).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCondition_SAV;
        private System.Windows.Forms.Label labelTask_SAV;
        private System.Windows.Forms.GroupBox groupBoxInput_SAV;
        private System.Windows.Forms.Label labelVarX_SAV;
        private System.Windows.Forms.TextBox textBoxVarX_SAV;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAV;
        private System.Windows.Forms.Label labelResult_SAV;
        private System.Windows.Forms.TextBox textBoxResult_SAV;
        private System.Windows.Forms.Button buttonDone_SAV;
        private System.Windows.Forms.Button buttonHelp_SAV;
    }
}