namespace Tyuiu.ShiganovaAV.Sprint6.Task4.V5
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxStart_SAV = new System.Windows.Forms.TextBox();
            this.textBoxStop_SAV = new System.Windows.Forms.TextBox();
            this.textBoxResult_SAV = new System.Windows.Forms.TextBox();
            this.buttonResult_SAV = new System.Windows.Forms.Button();
            this.buttonSave_SAV = new System.Windows.Forms.Button();
            this.buttonHelp_SAV = new System.Windows.Forms.Button();
            this.chartFunction_SAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelStart_SAV = new System.Windows.Forms.Label();
            this.labelStop_SAV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStart_SAV
            // 
            this.textBoxStart_SAV.Location = new System.Drawing.Point(120, 15);
            this.textBoxStart_SAV.Name = "textBoxStart_SAV";
            this.textBoxStart_SAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SAV.TabIndex = 0;
            this.textBoxStart_SAV.Text = "-5";
            // 
            // textBoxStop_SAV
            // 
            this.textBoxStop_SAV.Location = new System.Drawing.Point(120, 45);
            this.textBoxStop_SAV.Name = "textBoxStop_SAV";
            this.textBoxStop_SAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SAV.TabIndex = 1;
            this.textBoxStop_SAV.Text = "5";
            // 
            // textBoxResult_SAV
            // 
            this.textBoxResult_SAV.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SAV.Location = new System.Drawing.Point(12, 100);
            this.textBoxResult_SAV.Multiline = true;
            this.textBoxResult_SAV.Name = "textBoxResult_SAV";
            this.textBoxResult_SAV.ReadOnly = true;
            this.textBoxResult_SAV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SAV.Size = new System.Drawing.Size(300, 338);
            this.textBoxResult_SAV.TabIndex = 2;
            // 
            // buttonResult_SAV
            // 
            this.buttonResult_SAV.BackColor = System.Drawing.Color.LightBlue;
            this.buttonResult_SAV.Location = new System.Drawing.Point(240, 10);
            this.buttonResult_SAV.Name = "buttonResult_SAV";
            this.buttonResult_SAV.Size = new System.Drawing.Size(120, 40);
            this.buttonResult_SAV.TabIndex = 3;
            this.buttonResult_SAV.Text = "Выполнить";
            this.buttonResult_SAV.UseVisualStyleBackColor = false;
            this.buttonResult_SAV.Click += new System.EventHandler(this.buttonResult_SAV_Click);
            // 
            // buttonSave_SAV
            // 
            this.buttonSave_SAV.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSave_SAV.Location = new System.Drawing.Point(380, 10);
            this.buttonSave_SAV.Name = "buttonSave_SAV";
            this.buttonSave_SAV.Size = new System.Drawing.Size(120, 40);
            this.buttonSave_SAV.TabIndex = 4;
            this.buttonSave_SAV.Text = "Сохранить";
            this.buttonSave_SAV.UseVisualStyleBackColor = false;
            this.buttonSave_SAV.Click += new System.EventHandler(this.buttonSave_SAV_Click);
            // 
            // buttonHelp_SAV
            // 
            this.buttonHelp_SAV.BackColor = System.Drawing.Color.LightYellow;
            this.buttonHelp_SAV.Location = new System.Drawing.Point(520, 10);
            this.buttonHelp_SAV.Name = "buttonHelp_SAV";
            this.buttonHelp_SAV.Size = new System.Drawing.Size(120, 40);
            this.buttonHelp_SAV.TabIndex = 5;
            this.buttonHelp_SAV.Text = "Справка";
            this.buttonHelp_SAV.UseVisualStyleBackColor = false;
            this.buttonHelp_SAV.Click += new System.EventHandler(this.buttonHelp_SAV_Click);
            // 
            // chartFunction_SAV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SAV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SAV.Legends.Add(legend1);
            this.chartFunction_SAV.Location = new System.Drawing.Point(320, 100);
            this.chartFunction_SAV.Name = "chartFunction_SAV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "F(x)";
            this.chartFunction_SAV.Series.Add(series1);
            this.chartFunction_SAV.Size = new System.Drawing.Size(452, 338);
            this.chartFunction_SAV.TabIndex = 6;
            this.chartFunction_SAV.Text = "График функции";
            // 
            // labelStart_SAV
            // 
            this.labelStart_SAV.AutoSize = true;
            this.labelStart_SAV.Location = new System.Drawing.Point(30, 18);
            this.labelStart_SAV.Name = "labelStart_SAV";
            this.labelStart_SAV.Size = new System.Drawing.Size(81, 13);
            this.labelStart_SAV.TabIndex = 7;
            this.labelStart_SAV.Text = "Старт шага:";
            // 
            // labelStop_SAV
            // 
            this.labelStop_SAV.AutoSize = true;
            this.labelStop_SAV.Location = new System.Drawing.Point(30, 48);
            this.labelStop_SAV.Name = "labelStop_SAV";
            this.labelStop_SAV.Size = new System.Drawing.Size(84, 13);
            this.labelStop_SAV.TabIndex = 8;
            this.labelStop_SAV.Text = "Конец шага:";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.labelStop_SAV);
            this.Controls.Add(this.labelStart_SAV);
            this.Controls.Add(this.chartFunction_SAV);
            this.Controls.Add(this.buttonHelp_SAV);
            this.Controls.Add(this.buttonSave_SAV);
            this.Controls.Add(this.buttonResult_SAV);
            this.Controls.Add(this.textBoxResult_SAV);
            this.Controls.Add(this.textBoxStop_SAV);
            this.Controls.Add(this.textBoxStart_SAV);
            this.MinimumSize = new System.Drawing.Size(800, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 5 | Шиганова А. В.";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxStart_SAV;
        private System.Windows.Forms.TextBox textBoxStop_SAV;
        private System.Windows.Forms.TextBox textBoxResult_SAV;
        private System.Windows.Forms.Button buttonResult_SAV;
        private System.Windows.Forms.Button buttonSave_SAV;
        private System.Windows.Forms.Button buttonHelp_SAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAV;
        private System.Windows.Forms.Label labelStart_SAV;
        private System.Windows.Forms.Label labelStop_SAV;
    }
}