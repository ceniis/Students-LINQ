using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_LINQ
{
    partial class Cmp
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Panel chartPanel;

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
            dataGridView1 = new DataGridView();
            chartPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 15);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(262, 262);
            dataGridView1.TabIndex = 0;
            // 
            // chartPanel
            // 
            chartPanel.BackColor = Color.White;
            chartPanel.Location = new Point(306, 15);
            chartPanel.Margin = new Padding(3, 2, 3, 2);
            chartPanel.Name = "chartPanel";
            chartPanel.Size = new Size(368, 262);
            chartPanel.TabIndex = 1;
            chartPanel.Paint += chartPanel_Paint;
            // 
            // Cmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(700, 293);
            Controls.Add(dataGridView1);
            Controls.Add(chartPanel);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cmp";
            Text = "Compare Sorting Performance";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

    }
}