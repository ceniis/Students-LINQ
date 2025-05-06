using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Student_LINQ
{
    public partial class Cmp : Form
    {
        private readonly int[] sizes = { 1000, 5000, 10000, 50000, 100000 };
        private readonly double[] builtInTimes;
        private readonly double[] linqTimes;

        public Cmp()
        {
            InitializeComponent();

            builtInTimes = new double[sizes.Length];
            linqTimes = new double[sizes.Length];

            dataGridView1.Columns.Add("Size", "Array Size");
            dataGridView1.Columns.Add("BuiltIn", "Built-in Sort (ms)");
            dataGridView1.Columns.Add("LINQ", "LINQ Sort (ms)");

            Compare();
        }

        private void Compare()
        {
            Random rnd = new Random();

            for (int i = 0; i < sizes.Length; i++)
            {
                int[] arr = new int[sizes[i]];
                for (int j = 0; j < arr.Length; j++)
                    arr[j] = rnd.Next();

                var sw = Stopwatch.StartNew();
                Array.Sort((int[])arr.Clone());
                sw.Stop();
                builtInTimes[i] = sw.Elapsed.TotalMilliseconds;

                sw.Restart();
                _ = arr.OrderBy(x => x).ToArray();
                sw.Stop();
                linqTimes[i] = sw.Elapsed.TotalMilliseconds;

                dataGridView1.Rows.Add(sizes[i], builtInTimes[i].ToString("F2"), linqTimes[i].ToString("F2"));
            }

            chartPanel.Invalidate();
        }

        private void chartPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            var panelWidth = chartPanel.Width;
            var panelHeight = chartPanel.Height;
            var padding = 50;
            var graphWidth = panelWidth - 2 * padding;
            var graphHeight = panelHeight - 2 * padding;

            Pen axisPen = new Pen(Color.Black, 2);
            Pen builtInPen = new Pen(Color.Blue, 2);
            Pen linqPen = new Pen(Color.Red, 2);
            Font font = chartPanel.Font;

            // Axis lines
            g.DrawLine(axisPen, padding, panelHeight - padding, panelWidth - padding, panelHeight - padding); // X
            g.DrawLine(axisPen, padding, padding, padding, panelHeight - padding); // Y

            double maxTime = Math.Max(builtInTimes.Max(), linqTimes.Max());
            if (maxTime == 0) maxTime = 1;

            PointF[] builtInPoints = new PointF[sizes.Length];
            PointF[] linqPoints = new PointF[sizes.Length];

            for (int i = 0; i < sizes.Length; i++)
            {
                float x = padding + i * (graphWidth / (sizes.Length - 1));
                float yBuiltIn = panelHeight - padding - (float)(builtInTimes[i] / maxTime * graphHeight);
                float yLinq = panelHeight - padding - (float)(linqTimes[i] / maxTime * graphHeight);

                builtInPoints[i] = new PointF(x, yBuiltIn);
                linqPoints[i] = new PointF(x, yLinq);

                // Tick marks & labels
                g.DrawLine(Pens.Black, x, panelHeight - padding, x, panelHeight - padding + 5);
                g.DrawString(sizes[i].ToString(), font, Brushes.Black, x - 15, panelHeight - padding + 10);
            }

            // Y-axis labels (just a few steps)
            for (int j = 0; j <= 5; j++)
            {
                float y = padding + (graphHeight / 5f * j);
                double val = maxTime - (maxTime / 5f * j);
                g.DrawLine(Pens.Black, padding - 5, y, padding, y);
                g.DrawString($"{val:F1}", font, Brushes.Black, 5, y - 8);
            }

            // Draw curves
            g.DrawLines(builtInPen, builtInPoints);
            g.DrawLines(linqPen, linqPoints);

            // Legend
            g.FillRectangle(builtInPen.Brush, panelWidth - 160, 20, 12, 12);
            g.DrawString("Built-in Sort", font, Brushes.Black, panelWidth - 140, 18);
            g.FillRectangle(linqPen.Brush, panelWidth - 160, 40, 12, 12);
            g.DrawString("LINQ Sort", font, Brushes.Black, panelWidth - 140, 38);

            // Axis titles
            g.DrawString("Array Size", font, Brushes.Black, panelWidth / 2 - 30, panelHeight - 20);
            g.DrawString("Time (ms)", font, Brushes.Black, 5, 10);
        }
    }
}