namespace Tyuiu.ShiganovaAV.Sprint6.Task6.V17
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelButtons;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelStop = new System.Windows.Forms.Label();
            this.labelStep = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panelInput.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // dataGridView
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(10, 40);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(380, 200);
            this.dataGridView.TabIndex = 0;

            // labelTitle
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(10, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(380, 30);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Результат:";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelStart
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(20, 20);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(70, 16);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "Старт шага:";

            // labelStop
            this.labelStop.AutoSize = true;
            this.labelStop.Location = new System.Drawing.Point(20, 60);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(73, 16);
            this.labelStop.TabIndex = 3;
            this.labelStop.Text = "Конец шага:";

            // labelStep
            this.labelStep.AutoSize = true;
            this.labelStep.Location = new System.Drawing.Point(20, 100);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(38, 16);
            this.labelStep.TabIndex = 4;
            this.labelStep.Text = "Шаг:";

            // textBoxStart
            this.textBoxStart.Location = new System.Drawing.Point(120, 17);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(150, 22);
            this.textBoxStart.TabIndex = 5;
            this.textBoxStart.Text = "0";

            // textBoxStop
            this.textBoxStop.Location = new System.Drawing.Point(120, 57);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(150, 22);
            this.textBoxStop.TabIndex = 6;
            this.textBoxStop.Text = "10";

            // textBoxStep
            this.textBoxStep.Location = new System.Drawing.Point(120, 97);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(150, 22);
            this.textBoxStep.TabIndex = 7;
            this.textBoxStep.Text = "0,5";

            // buttonExecute
            this.buttonExecute.Location = new System.Drawing.Point(20, 140);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(120, 40);
            this.buttonExecute.TabIndex = 8;
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);

            // buttonInfo
            this.buttonInfo.Location = new System.Drawing.Point(150, 140);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(120, 40);
            this.buttonInfo.TabIndex = 9;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);

            // chart
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(10, 10);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(380, 230);
            this.chart.TabIndex = 10;
            this.chart.Text = "chart";

            // panelInput
            this.panelInput.Controls.Add(this.labelStart);
            this.panelInput.Controls.Add(this.labelStop);
            this.panelInput.Controls.Add(this.labelStep);
            this.panelInput.Controls.Add(this.textBoxStart);
            this.panelInput.Controls.Add(this.textBoxStop);
            this.panelInput.Controls.Add(this.textBoxStep);
            this.panelInput.Controls.Add(this.buttonExecute);
            this.panelInput.Controls.Add(this.buttonInfo);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(20);
            this.panelInput.Size = new System.Drawing.Size(300, 200);
            this.panelInput.TabIndex = 11;

            // panelResult
            this.panelResult.Controls.Add(this.dataGridView);
            this.panelResult.Controls.Add(this.labelTitle);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResult.Location = new System.Drawing.Point(300, 250);
            this.panelResult.Name = "panelResult";
            this.panelResult.Padding = new System.Windows.Forms.Padding(10);
            this.panelResult.Size = new System.Drawing.Size(400, 250);
            this.panelResult.TabIndex = 12;

            // panelChart
            this.panelChart.Controls.Add(this.chart);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(300, 0);
            this.panelChart.Name = "panelChart";
            this.panelChart.Padding = new System.Windows.Forms.Padding(10);
            this.panelChart.Size = new System.Drawing.Size(400, 250);
            this.panelChart.TabIndex = 13;

            // panelButtons
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(300, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(0, 250);
            this.panelButtons.TabIndex = 14;

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelResult);
            this.MinimumSize = new System.Drawing.Size(718, 547);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}