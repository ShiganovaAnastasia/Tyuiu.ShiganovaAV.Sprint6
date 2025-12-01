namespace Tyuiu.ShiganovaAV.Sprint6.Task2.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_SAV = new System.Windows.Forms.Panel();
            this.groupBoxTask_SAV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAV = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SAV = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SAV = new System.Windows.Forms.TextBox();
            this.textBoxStart_SAV = new System.Windows.Forms.TextBox();
            this.labelStop_SAV = new System.Windows.Forms.Label();
            this.labelStart_SAV = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxOutput_SAV = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SAV = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxChart_SAV = new System.Windows.Forms.GroupBox();
            this.chartFunction_SAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelBottom_SAV = new System.Windows.Forms.Panel();
            this.labelInfo_SAV = new System.Windows.Forms.Label();
            this.buttonHelp_SAV = new System.Windows.Forms.Button();
            this.buttonDone_SAV = new System.Windows.Forms.Button();
            this.panelTop_SAV.SuspendLayout();
            this.groupBoxTask_SAV.SuspendLayout();
            this.groupBoxInput_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxOutput_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAV)).BeginInit();
            this.groupBoxChart_SAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAV)).BeginInit();
            this.panelBottom_SAV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_SAV
            // 
            this.panelTop_SAV.Controls.Add(this.groupBoxTask_SAV);
            this.panelTop_SAV.Controls.Add(this.groupBoxInput_SAV);
            this.panelTop_SAV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SAV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SAV.Name = "panelTop_SAV";
            this.panelTop_SAV.Size = new System.Drawing.Size(984, 150);
            this.panelTop_SAV.TabIndex = 0;
            // 
            // groupBoxTask_SAV
            // 
            this.groupBoxTask_SAV.Controls.Add(this.textBoxTask_SAV);
            this.groupBoxTask_SAV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAV.Name = "groupBoxTask_SAV";
            this.groupBoxTask_SAV.Size = new System.Drawing.Size(600, 80);
            this.groupBoxTask_SAV.TabIndex = 0;
            this.groupBoxTask_SAV.TabStop = false;
            this.groupBoxTask_SAV.Text = "Условие";
            // 
            // textBoxTask_SAV
            // 
            this.textBoxTask_SAV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SAV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SAV.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SAV.Multiline = true;
            this.textBoxTask_SAV.Name = "textBoxTask_SAV";
            this.textBoxTask_SAV.ReadOnly = true;
            this.textBoxTask_SAV.Size = new System.Drawing.Size(594, 61);
            this.textBoxTask_SAV.TabIndex = 0;
            this.textBoxTask_SAV.Text = "Табулировать функцию F(x) = (2x+6)/(cos(x)+x) - 3 на диапазоне [-5; 5] с шагом 1." +
    "\r\nПроизвести проверку деления на ноль. При делении на ноль вернуть значение 0.\r\n" +
    "Результат вывести в таблицу и построить график.";
            // 
            // groupBoxInput_SAV
            // 
            this.groupBoxInput_SAV.Controls.Add(this.textBoxStop_SAV);
            this.groupBoxInput_SAV.Controls.Add(this.textBoxStart_SAV);
            this.groupBoxInput_SAV.Controls.Add(this.labelStop_SAV);
            this.groupBoxInput_SAV.Controls.Add(this.labelStart_SAV);
            this.groupBoxInput_SAV.Location = new System.Drawing.Point(618, 12);
            this.groupBoxInput_SAV.Name = "groupBoxInput_SAV";
            this.groupBoxInput_SAV.Size = new System.Drawing.Size(354, 80);
            this.groupBoxInput_SAV.TabIndex = 1;
            this.groupBoxInput_SAV.TabStop = false;
            this.groupBoxInput_SAV.Text = "Ввод данных";
            // 
            // textBoxStop_SAV
            // 
            this.textBoxStop_SAV.Location = new System.Drawing.Point(220, 35);
            this.textBoxStop_SAV.Name = "textBoxStop_SAV";
            this.textBoxStop_SAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SAV.TabIndex = 3;
            this.textBoxStop_SAV.Text = "5";
            this.textBoxStop_SAV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStop_SAV_KeyPress);
            // 
            // textBoxStart_SAV
            // 
            this.textBoxStart_SAV.Location = new System.Drawing.Point(70, 35);
            this.textBoxStart_SAV.Name = "textBoxStart_SAV";
            this.textBoxStart_SAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SAV.TabIndex = 2;
            this.textBoxStart_SAV.Text = "-5";
            this.textBoxStart_SAV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_SAV_KeyPress);
            // 
            // labelStop_SAV
            // 
            this.labelStop_SAV.AutoSize = true;
            this.labelStop_SAV.Location = new System.Drawing.Point(180, 38);
            this.labelStop_SAV.Name = "labelStop_SAV";
            this.labelStop_SAV.Size = new System.Drawing.Size(34, 13);
            this.labelStop_SAV.TabIndex = 1;
            this.labelStop_SAV.Text = "Конец:";
            // 
            // labelStart_SAV
            // 
            this.labelStart_SAV.AutoSize = true;
            this.labelStart_SAV.Location = new System.Drawing.Point(20, 38);
            this.labelStart_SAV.Name = "labelStart_SAV";
            this.labelStart_SAV.Size = new System.Drawing.Size(44, 13);
            this.labelStart_SAV.TabIndex = 0;
            this.labelStart_SAV.Text = "Начало:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 150);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxOutput_SAV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxChart_SAV);
            this.splitContainer1.Size = new System.Drawing.Size(984, 411);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBoxOutput_SAV
            // 
            this.groupBoxOutput_SAV.Controls.Add(this.dataGridViewResult_SAV);
            this.groupBoxOutput_SAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_SAV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_SAV.Size = new System.Drawing.Size(450, 411);
            this.groupBoxOutput_SAV.TabIndex = 0;
            this.groupBoxOutput_SAV.TabStop = false;
            this.groupBoxOutput_SAV.Text = "Таблица значений";
            // 
            // dataGridViewResult_SAV
            // 
            this.dataGridViewResult_SAV.AllowUserToAddRows = false;
            this.dataGridViewResult_SAV.AllowUserToDeleteRows = false;
            this.dataGridViewResult_SAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnFx});
            this.dataGridViewResult_SAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_SAV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_SAV.Name = "dataGridViewResult_SAV";
            this.dataGridViewResult_SAV.ReadOnly = true;
            this.dataGridViewResult_SAV.RowHeadersVisible = false;
            this.dataGridViewResult_SAV.Size = new System.Drawing.Size(444, 392);
            this.dataGridViewResult_SAV.TabIndex = 0;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Width = 150;
            // 
            // ColumnFx
            // 
            this.ColumnFx.HeaderText = "F(x)";
            this.ColumnFx.Name = "ColumnFx";
            this.ColumnFx.ReadOnly = true;
            this.ColumnFx.Width = 150;
            // 
            // groupBoxChart_SAV
            // 
            this.groupBoxChart_SAV.Controls.Add(this.chartFunction_SAV);
            this.groupBoxChart_SAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxChart_SAV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxChart_SAV.Name = "groupBoxChart_SAV";
            this.groupBoxChart_SAV.Size = new System.Drawing.Size(530, 411);
            this.groupBoxChart_SAV.TabIndex = 0;
            this.groupBoxChart_SAV.TabStop = false;
            this.groupBoxChart_SAV.Text = "График функции";
            // 
            // chartFunction_SAV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SAV.ChartAreas.Add(chartArea1);
            this.chartFunction_SAV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_SAV.Legends.Add(legend1);
            this.chartFunction_SAV.Location = new System.Drawing.Point(3, 16);
            this.chartFunction_SAV.Name = "chartFunction_SAV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "F(x)";
            this.chartFunction_SAV.Series.Add(series1);
            this.chartFunction_SAV.Size = new System.Drawing.Size(524, 392);
            this.chartFunction_SAV.TabIndex = 0;
            this.chartFunction_SAV.Text = "chart1";
            // 
            // panelBottom_SAV
            // 
            this.panelBottom_SAV.Controls.Add(this.labelInfo_SAV);
            this.panelBottom_SAV.Controls.Add(this.buttonHelp_SAV);
            this.panelBottom_SAV.Controls.Add(this.buttonDone_SAV);
            this.panelBottom_SAV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom_SAV.Location = new System.Drawing.Point(0, 561);
            this.panelBottom_SAV.Name = "panelBottom_SAV";
            this.panelBottom_SAV.Size = new System.Drawing.Size(984, 50);
            this.panelBottom_SAV.TabIndex = 2;
            // 
            // labelInfo_SAV
            // 
            this.labelInfo_SAV.AutoSize = true;
            this.labelInfo_SAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_SAV.Location = new System.Drawing.Point(15, 17);
            this.labelInfo_SAV.Name = "labelInfo_SAV";
            this.labelInfo_SAV.Size = new System.Drawing.Size(110, 16);
            this.labelInfo_SAV.TabIndex = 2;
            this.labelInfo_SAV.Text = "Количество точек:";
            // 
            // buttonHelp_SAV
            // 
            this.buttonHelp_SAV.Location = new System.Drawing.Point(798, 15);
            this.buttonHelp_SAV.Name = "buttonHelp_SAV";
            this.buttonHelp_SAV.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp_SAV.TabIndex = 1;
            this.buttonHelp_SAV.Text = "Справка";
            this.buttonHelp_SAV.UseVisualStyleBackColor = true;
            this.buttonHelp_SAV.Click += new System.EventHandler(this.buttonHelp_SAV_Click);
            // 
            // buttonDone_SAV
            // 
            this.buttonDone_SAV.Location = new System.Drawing.Point(879, 15);
            this.buttonDone_SAV.Name = "buttonDone_SAV";
            this.buttonDone_SAV.Size = new System.Drawing.Size(93, 23);
            this.buttonDone_SAV.TabIndex = 0;
            this.buttonDone_SAV.Text = "Выполнить";
            this.buttonDone_SAV.UseVisualStyleBackColor = true;
            this.buttonDone_SAV.Click += new System.EventHandler(this.buttonDone_SAV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelBottom_SAV);
            this.Controls.Add(this.panelTop_SAV);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 12 | Шиганова А. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_SAV.ResumeLayout(false);
            this.groupBoxTask_SAV.ResumeLayout(false);
            this.groupBoxTask_SAV.PerformLayout();
            this.groupBoxInput_SAV.ResumeLayout(false);
            this.groupBoxInput_SAV.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxOutput_SAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAV)).EndInit();
            this.groupBoxChart_SAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAV)).EndInit();
            this.panelBottom_SAV.ResumeLayout(false);
            this.panelBottom_SAV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SAV;
        private System.Windows.Forms.GroupBox groupBoxTask_SAV;
        private System.Windows.Forms.TextBox textBoxTask_SAV;
        private System.Windows.Forms.GroupBox groupBoxInput_SAV;
        private System.Windows.Forms.TextBox textBoxStop_SAV;
        private System.Windows.Forms.TextBox textBoxStart_SAV;
        private System.Windows.Forms.Label labelStop_SAV;
        private System.Windows.Forms.Label labelStart_SAV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAV;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAV;
        private System.Windows.Forms.GroupBox groupBoxChart_SAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAV;
        private System.Windows.Forms.Panel panelBottom_SAV;
        private System.Windows.Forms.Button buttonHelp_SAV;
        private System.Windows.Forms.Button buttonDone_SAV;
        private System.Windows.Forms.Label labelInfo_SAV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFx;
    }
}