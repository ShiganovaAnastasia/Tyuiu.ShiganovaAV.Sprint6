namespace Tyuiu.ShiganovaAV.Sprint6.Task1.V26
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_SAV = new Panel();
            groupBoxTask_SAV = new GroupBox();
            textBoxTask_SAV = new TextBox();
            groupBoxInput_SAV = new GroupBox();
            labelEnd_SAV = new Label();
            textBoxEnd_SAV = new TextBox();
            labelStart_SAV = new Label();
            textBoxStart_SAV = new TextBox();
            groupBoxOutput_SAV = new GroupBox();
            textBoxResult_SAV = new TextBox();
            panelBottom_SAV = new Panel();
            buttonHelp_SAV = new Button();
            buttonDone_SAV = new Button();
            panelTop_SAV.SuspendLayout();
            groupBoxTask_SAV.SuspendLayout();
            groupBoxInput_SAV.SuspendLayout();
            groupBoxOutput_SAV.SuspendLayout();
            panelBottom_SAV.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_SAV
            // 
            panelTop_SAV.Controls.Add(groupBoxTask_SAV);
            panelTop_SAV.Controls.Add(groupBoxInput_SAV);
            panelTop_SAV.Dock = DockStyle.Top;
            panelTop_SAV.Location = new Point(0, 0);
            panelTop_SAV.Margin = new Padding(4, 5, 4, 5);
            panelTop_SAV.Name = "panelTop_SAV";
            panelTop_SAV.Size = new Size(1043, 308);
            panelTop_SAV.TabIndex = 0;
            // 
            // groupBoxTask_SAV
            // 
            groupBoxTask_SAV.Controls.Add(textBoxTask_SAV);
            groupBoxTask_SAV.Location = new Point(16, 18);
            groupBoxTask_SAV.Margin = new Padding(4, 5, 4, 5);
            groupBoxTask_SAV.Name = "groupBoxTask_SAV";
            groupBoxTask_SAV.Padding = new Padding(4, 5, 4, 5);
            groupBoxTask_SAV.Size = new Size(1013, 154);
            groupBoxTask_SAV.TabIndex = 0;
            groupBoxTask_SAV.TabStop = false;
            groupBoxTask_SAV.Text = "Условие";
            // 
            // textBoxTask_SAV
            // 
            textBoxTask_SAV.BackColor = SystemColors.Control;
            textBoxTask_SAV.BorderStyle = BorderStyle.None;
            textBoxTask_SAV.Dock = DockStyle.Fill;
            textBoxTask_SAV.Location = new Point(4, 25);
            textBoxTask_SAV.Margin = new Padding(4, 5, 4, 5);
            textBoxTask_SAV.Multiline = true;
            textBoxTask_SAV.Name = "textBoxTask_SAV";
            textBoxTask_SAV.ReadOnly = true;
            textBoxTask_SAV.Size = new Size(1005, 124);
            textBoxTask_SAV.TabIndex = 0;
            textBoxTask_SAV.Text = resources.GetString("textBoxTask_SAV.Text");
            // 
            // groupBoxInput_SAV
            // 
            groupBoxInput_SAV.Controls.Add(labelEnd_SAV);
            groupBoxInput_SAV.Controls.Add(textBoxEnd_SAV);
            groupBoxInput_SAV.Controls.Add(labelStart_SAV);
            groupBoxInput_SAV.Controls.Add(textBoxStart_SAV);
            groupBoxInput_SAV.Location = new Point(16, 182);
            groupBoxInput_SAV.Margin = new Padding(4, 5, 4, 5);
            groupBoxInput_SAV.Name = "groupBoxInput_SAV";
            groupBoxInput_SAV.Padding = new Padding(4, 5, 4, 5);
            groupBoxInput_SAV.Size = new Size(1013, 108);
            groupBoxInput_SAV.TabIndex = 1;
            groupBoxInput_SAV.TabStop = false;
            groupBoxInput_SAV.Text = "Ввод данных";
            // 
            // labelEnd_SAV
            // 
            labelEnd_SAV.AutoSize = true;
            labelEnd_SAV.Location = new Point(333, 46);
            labelEnd_SAV.Margin = new Padding(4, 0, 4, 0);
            labelEnd_SAV.Name = "labelEnd_SAV";
            labelEnd_SAV.Size = new Size(94, 20);
            labelEnd_SAV.TabIndex = 3;
            labelEnd_SAV.Text = "Конец шага:";
            // 
            // textBoxEnd_SAV
            // 
            textBoxEnd_SAV.Location = new Point(439, 42);
            textBoxEnd_SAV.Margin = new Padding(4, 5, 4, 5);
            textBoxEnd_SAV.Name = "textBoxEnd_SAV";
            textBoxEnd_SAV.Size = new Size(132, 27);
            textBoxEnd_SAV.TabIndex = 2;
            textBoxEnd_SAV.KeyPress += textBoxEnd_SAV_KeyPress;
            // 
            // labelStart_SAV
            // 
            labelStart_SAV.AutoSize = true;
            labelStart_SAV.Location = new Point(27, 46);
            labelStart_SAV.Margin = new Padding(4, 0, 4, 0);
            labelStart_SAV.Name = "labelStart_SAV";
            labelStart_SAV.Size = new Size(88, 20);
            labelStart_SAV.TabIndex = 1;
            labelStart_SAV.Text = "Старт шага:";
            // 
            // textBoxStart_SAV
            // 
            textBoxStart_SAV.Location = new Point(124, 42);
            textBoxStart_SAV.Margin = new Padding(4, 5, 4, 5);
            textBoxStart_SAV.Name = "textBoxStart_SAV";
            textBoxStart_SAV.Size = new Size(132, 27);
            textBoxStart_SAV.TabIndex = 0;
            textBoxStart_SAV.KeyPress += textBoxStart_SAV_KeyPress;
            // 
            // groupBoxOutput_SAV
            // 
            groupBoxOutput_SAV.Controls.Add(textBoxResult_SAV);
            groupBoxOutput_SAV.Dock = DockStyle.Fill;
            groupBoxOutput_SAV.Location = new Point(0, 308);
            groupBoxOutput_SAV.Margin = new Padding(4, 5, 4, 5);
            groupBoxOutput_SAV.Name = "groupBoxOutput_SAV";
            groupBoxOutput_SAV.Padding = new Padding(4, 5, 4, 5);
            groupBoxOutput_SAV.Size = new Size(1043, 466);
            groupBoxOutput_SAV.TabIndex = 1;
            groupBoxOutput_SAV.TabStop = false;
            groupBoxOutput_SAV.Text = "Вывод данных";
            // 
            // textBoxResult_SAV
            // 
            textBoxResult_SAV.Dock = DockStyle.Fill;
            textBoxResult_SAV.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_SAV.Location = new Point(4, 25);
            textBoxResult_SAV.Margin = new Padding(4, 5, 4, 5);
            textBoxResult_SAV.Multiline = true;
            textBoxResult_SAV.Name = "textBoxResult_SAV";
            textBoxResult_SAV.ReadOnly = true;
            textBoxResult_SAV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SAV.Size = new Size(1035, 436);
            textBoxResult_SAV.TabIndex = 0;
            // 
            // panelBottom_SAV
            // 
            panelBottom_SAV.Controls.Add(buttonHelp_SAV);
            panelBottom_SAV.Controls.Add(buttonDone_SAV);
            panelBottom_SAV.Dock = DockStyle.Bottom;
            panelBottom_SAV.Location = new Point(0, 774);
            panelBottom_SAV.Margin = new Padding(4, 5, 4, 5);
            panelBottom_SAV.Name = "panelBottom_SAV";
            panelBottom_SAV.Size = new Size(1043, 77);
            panelBottom_SAV.TabIndex = 2;
            // 
            // buttonHelp_SAV
            // 
            buttonHelp_SAV.BackColor = Color.CornflowerBlue;
            buttonHelp_SAV.Location = new Point(796, 23);
            buttonHelp_SAV.Margin = new Padding(4, 5, 4, 5);
            buttonHelp_SAV.Name = "buttonHelp_SAV";
            buttonHelp_SAV.Size = new Size(100, 35);
            buttonHelp_SAV.TabIndex = 1;
            buttonHelp_SAV.Text = "Справка";
            buttonHelp_SAV.UseVisualStyleBackColor = false;
            buttonHelp_SAV.Click += buttonHelp_SAV_Click;
            // 
            // buttonDone_SAV
            // 
            buttonDone_SAV.BackColor = Color.IndianRed;
            buttonDone_SAV.Location = new Point(904, 23);
            buttonDone_SAV.Margin = new Padding(4, 5, 4, 5);
            buttonDone_SAV.Name = "buttonDone_SAV";
            buttonDone_SAV.Size = new Size(125, 35);
            buttonDone_SAV.TabIndex = 0;
            buttonDone_SAV.Text = "Выполнить";
            buttonDone_SAV.UseVisualStyleBackColor = false;
            buttonDone_SAV.Click += buttonDone_SAV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 851);
            Controls.Add(groupBoxOutput_SAV);
            Controls.Add(panelBottom_SAV);
            Controls.Add(panelTop_SAV);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1061, 898);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 26 | Шиганова А. В.";
            panelTop_SAV.ResumeLayout(false);
            groupBoxTask_SAV.ResumeLayout(false);
            groupBoxTask_SAV.PerformLayout();
            groupBoxInput_SAV.ResumeLayout(false);
            groupBoxInput_SAV.PerformLayout();
            groupBoxOutput_SAV.ResumeLayout(false);
            groupBoxOutput_SAV.PerformLayout();
            panelBottom_SAV.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SAV;
        private System.Windows.Forms.GroupBox groupBoxTask_SAV;
        private System.Windows.Forms.TextBox textBoxTask_SAV;
        private System.Windows.Forms.GroupBox groupBoxInput_SAV;
        private System.Windows.Forms.Label labelEnd_SAV;
        private System.Windows.Forms.TextBox textBoxEnd_SAV;
        private System.Windows.Forms.Label labelStart_SAV;
        private System.Windows.Forms.TextBox textBoxStart_SAV;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAV;
        private System.Windows.Forms.TextBox textBoxResult_SAV;
        private System.Windows.Forms.Panel panelBottom_SAV;
        private System.Windows.Forms.Button buttonHelp_SAV;
        private System.Windows.Forms.Button buttonDone_SAV;
    }
}