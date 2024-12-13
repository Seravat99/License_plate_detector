using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SS_OpenCV
{
    public partial class HistogramWhiteY : Form
    {
        public HistogramWhiteY(int[] hist)
        {
            InitializeComponent();

            DataPointCollection list1 = chart1.Series[0].Points;
            for (int i = 0; i < hist.Length; i++)
            {
                list1.AddXY(-i, hist[i]);
            }
            chart1.Series[0].Color = Color.Red;
            chart1.ChartAreas[0].AxisX.Maximum = 0;
            chart1.ChartAreas[0].AxisX.Minimum = -hist.Length;
            chart1.ChartAreas[0].AxisX.Title = "Y Column";
            chart1.ChartAreas[0].AxisY.Title = "Whites in line";
            chart1.ResumeLayout();
        }
    }
}
