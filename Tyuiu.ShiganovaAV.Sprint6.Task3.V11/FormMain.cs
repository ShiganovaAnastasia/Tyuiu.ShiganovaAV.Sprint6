namespace Tyuiu.ShiganovaAV.Sprint6.Task3.V11
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxCondition_SAV;
        private System.Windows.Forms.TextBox textBoxResult_SAV;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SAV;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAV;
        private System.Windows.Forms.Button buttonExecute_SAV;
        private System.Windows.Forms.Button buttonHelp_SAV;
        private System.Windows.Forms.Panel panelCondition;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.TextBox textBoxStart_SAV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelCondition = new Label();
            labelOutput = new Label();
            textBoxCondition_SAV = new TextBox();
            textBoxResult_SAV = new TextBox();
            dataGridViewMatrix_SAV = new DataGridView();
            dataGridViewResult_SAV = new DataGridView();
            buttonExecute_SAV = new Button();
            buttonHelp_SAV = new Button();
            panelCondition = new Panel();
            panelOutput = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_SAV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SAV).BeginInit();
            panelCondition.SuspendLayout();
            panelOutput.SuspendLayout();
            SuspendLayout();
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCondition.Location = new Point(40, 38);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(86, 20);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Условие";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelOutput.Location = new Point(440, 38);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(144, 20);
            labelOutput.TabIndex = 1;
            labelOutput.Text = "Вывод данных";
            // 
            // textBoxCondition_SAV
            // 
            textBoxCondition_SAV.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCondition_SAV.Location = new Point(15, 13);
            textBoxCondition_SAV.Margin = new Padding(3, 4, 3, 4);
            textBoxCondition_SAV.Multiline = true;
            textBoxCondition_SAV.Name = "textBoxCondition_SAV";
            textBoxCondition_SAV.ReadOnly = true;
            textBoxCondition_SAV.ScrollBars = ScrollBars.Vertical;
            textBoxCondition_SAV.Size = new Size(280, 222);
            textBoxCondition_SAV.TabIndex = 2;
            // 
            // textBoxResult_SAV
            // 
            textBoxResult_SAV.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_SAV.Location = new Point(17, 13);
            textBoxResult_SAV.Margin = new Padding(3, 4, 3, 4);
            textBoxResult_SAV.Multiline = true;
            textBoxResult_SAV.Name = "textBoxResult_SAV";
            textBoxResult_SAV.ReadOnly = true;
            textBoxResult_SAV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SAV.Size = new Size(287, 222);
            textBoxResult_SAV.TabIndex = 3;
            // 
            // dataGridViewMatrix_SAV
            // 
            dataGridViewMatrix_SAV.AllowUserToAddRows = false;
            dataGridViewMatrix_SAV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMatrix_SAV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMatrix_SAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewMatrix_SAV.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMatrix_SAV.Location = new Point(15, 267);
            dataGridViewMatrix_SAV.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMatrix_SAV.Name = "dataGridViewMatrix_SAV";
            dataGridViewMatrix_SAV.ReadOnly = true;
            dataGridViewMatrix_SAV.RowHeadersVisible = false;
            dataGridViewMatrix_SAV.RowHeadersWidth = 51;
            dataGridViewMatrix_SAV.RowTemplate.Height = 24;
            dataGridViewMatrix_SAV.Size = new Size(280, 150);
            dataGridViewMatrix_SAV.TabIndex = 4;
            dataGridViewMatrix_SAV.CellContentClick += dataGridViewMatrix_SAV_CellContentClick;
            // 
            // dataGridViewResult_SAV
            // 
            dataGridViewResult_SAV.AllowUserToAddRows = false;
            dataGridViewResult_SAV.AllowUserToDeleteRows = false;
            dataGridViewResult_SAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SAV.Location = new Point(17, 267);
            dataGridViewResult_SAV.Margin = new Padding(3, 4, 3, 4);
            dataGridViewResult_SAV.Name = "dataGridViewResult_SAV";
            dataGridViewResult_SAV.ReadOnly = true;
            dataGridViewResult_SAV.RowHeadersVisible = false;
            dataGridViewResult_SAV.RowHeadersWidth = 51;
            dataGridViewResult_SAV.RowTemplate.Height = 24;
            dataGridViewResult_SAV.Size = new Size(287, 150);
            dataGridViewResult_SAV.TabIndex = 5;
            dataGridViewResult_SAV.CellContentClick += dataGridViewResult_SAV_CellContentClick;
            // 
            // buttonExecute_SAV
            // 
            buttonExecute_SAV.BackColor = Color.DodgerBlue;
            buttonExecute_SAV.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExecute_SAV.ForeColor = Color.White;
            buttonExecute_SAV.Location = new Point(151, 13);
            buttonExecute_SAV.Margin = new Padding(3, 4, 3, 4);
            buttonExecute_SAV.Name = "buttonExecute_SAV";
            buttonExecute_SAV.Size = new Size(115, 50);
            buttonExecute_SAV.TabIndex = 6;
            buttonExecute_SAV.Text = "Выполнить";
            buttonExecute_SAV.UseVisualStyleBackColor = false;
            buttonExecute_SAV.Click += buttonExecute_SAV_Click;
            // 
            // buttonHelp_SAV
            // 
            buttonHelp_SAV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_SAV.Location = new Point(272, 13);
            buttonHelp_SAV.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_SAV.Name = "buttonHelp_SAV";
            buttonHelp_SAV.Size = new Size(40, 50);
            buttonHelp_SAV.TabIndex = 7;
            buttonHelp_SAV.Text = "?";
            buttonHelp_SAV.UseVisualStyleBackColor = true;
            buttonHelp_SAV.Click += buttonHelp_SAV_Click;
            // 
            // panelCondition
            // 
            panelCondition.BorderStyle = BorderStyle.FixedSingle;
            panelCondition.Controls.Add(dataGridViewMatrix_SAV);
            panelCondition.Controls.Add(textBoxCondition_SAV);
            panelCondition.Location = new Point(40, 75);
            panelCondition.Margin = new Padding(3, 4, 3, 4);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(307, 437);
            panelCondition.TabIndex = 8;
            // 
            // panelOutput
            // 
            panelOutput.BorderStyle = BorderStyle.FixedSingle;
            panelOutput.Controls.Add(dataGridViewResult_SAV);
            panelOutput.Controls.Add(textBoxResult_SAV);
            panelOutput.Location = new Point(440, 75);
            panelOutput.Margin = new Padding(3, 4, 3, 4);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(320, 437);
            panelOutput.TabIndex = 9;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(panelOutput);
            Controls.Add(panelCondition);
            Controls.Add(buttonHelp_SAV);
            Controls.Add(buttonExecute_SAV);
            Controls.Add(labelOutput);
            Controls.Add(labelCondition);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 11 | Шиганова А.В.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_SAV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SAV).EndInit();
            panelCondition.ResumeLayout(false);
            panelCondition.PerformLayout();
            panelOutput.ResumeLayout(false);
            panelOutput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewResult_SAV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMatrix_SAV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}