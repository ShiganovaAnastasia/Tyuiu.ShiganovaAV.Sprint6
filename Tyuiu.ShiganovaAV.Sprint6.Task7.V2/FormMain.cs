namespace Tyuiu.ShiganovaAV.Sprint6.Task7.V2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewIn_SAV;
        private System.Windows.Forms.DataGridView dataGridViewOut_SAV;
        private System.Windows.Forms.Button buttonOpenFile_SAV;
        private System.Windows.Forms.Button buttonSave_SAV;
        private System.Windows.Forms.Button buttonHelp_SAV;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewIn_SAV = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_SAV = new System.Windows.Forms.DataGridView();
            this.buttonOpenFile_SAV = new System.Windows.Forms.Button();
            this.buttonSave_SAV = new System.Windows.Forms.Button();
            this.buttonHelp_SAV = new System.Windows.Forms.Button();
            this.labelIn = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SAV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_SAV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // dataGridViewIn_SAV
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewIn_SAV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIn_SAV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIn_SAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_SAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_SAV.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewIn_SAV.Name = "dataGridViewIn_SAV";
            this.dataGridViewIn_SAV.ReadOnly = true;
            this.dataGridViewIn_SAV.RowHeadersWidth = 51;
            this.dataGridViewIn_SAV.Size = new System.Drawing.Size(400, 320);
            this.dataGridViewIn_SAV.TabIndex = 0;

            // dataGridViewOut_SAV
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            this.dataGridViewOut_SAV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOut_SAV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOut_SAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_SAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_SAV.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewOut_SAV.Name = "dataGridViewOut_SAV";
            this.dataGridViewOut_SAV.ReadOnly = true;
            this.dataGridViewOut_SAV.RowHeadersWidth = 51;
            this.dataGridViewOut_SAV.Size = new System.Drawing.Size(396, 320);
            this.dataGridViewOut_SAV.TabIndex = 1;

            // buttonOpenFile_SAV
            this.buttonOpenFile_SAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_SAV.Location = new System.Drawing.Point(20, 20);
            this.buttonOpenFile_SAV.Name = "buttonOpenFile_SAV";
            this.buttonOpenFile_SAV.Size = new System.Drawing.Size(180, 40);
            this.buttonOpenFile_SAV.TabIndex = 2;
            this.buttonOpenFile_SAV.Text = "📂";
            this.buttonOpenFile_SAV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SAV.Click += new System.EventHandler(this.buttonOpenFile_SAV_Click);

            // buttonSave_SAV
            this.buttonSave_SAV.Enabled = false;
            this.buttonSave_SAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_SAV.Location = new System.Drawing.Point(210, 20);
            this.buttonSave_SAV.Name = "buttonSave_SAV";
            this.buttonSave_SAV.Size = new System.Drawing.Size(180, 40);
            this.buttonSave_SAV.TabIndex = 3;
            this.buttonSave_SAV.Text = "💾";
            this.buttonSave_SAV.UseVisualStyleBackColor = true;
            this.buttonSave_SAV.Click += new System.EventHandler(this.buttonSave_SAV_Click);

            // buttonHelp_SAV
            this.buttonHelp_SAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SAV.Location = new System.Drawing.Point(400, 20);
            this.buttonHelp_SAV.Name = "buttonHelp_SAV";
            this.buttonHelp_SAV.Size = new System.Drawing.Size(180, 40);
            this.buttonHelp_SAV.TabIndex = 4;
            this.buttonHelp_SAV.Text = "❓";
            this.buttonHelp_SAV.UseVisualStyleBackColor = true;
            this.buttonHelp_SAV.Click += new System.EventHandler(this.buttonHelp_SAV_Click);

            // labelIn
            this.labelIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIn.Location = new System.Drawing.Point(0, 0);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(400, 30);
            this.labelIn.TabIndex = 5;
            this.labelIn.Text = "Ввод:";
            this.labelIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelOut
            this.labelOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOut.Location = new System.Drawing.Point(0, 0);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(396, 30);
            this.labelOut.TabIndex = 6;
            this.labelOut.Text = "Вывод:";
            this.labelOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // splitContainer1
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 80);
            this.splitContainer1.Name = "splitContainer1";

            // splitContainer1.Panel1
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewIn_SAV);
            this.splitContainer1.Panel1.Controls.Add(this.labelIn);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);

            // splitContainer1.Panel2
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewOut_SAV);
            this.splitContainer1.Panel2.Controls.Add(this.labelOut);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            this.splitContainer1.Size = new System.Drawing.Size(800, 350);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 7;

            // panelButtons
            this.panelButtons.Controls.Add(this.buttonOpenFile_SAV);
            this.panelButtons.Controls.Add(this.buttonSave_SAV);
            this.panelButtons.Controls.Add(this.buttonHelp_SAV);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(20);
            this.panelButtons.Size = new System.Drawing.Size(800, 80);
            this.panelButtons.TabIndex = 8;

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelButtons);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 2 | Шиганова А.В.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SAV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_SAV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}