﻿using System;
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
    public partial class HistogramAll : Form
    {
        public HistogramAll(int[,] hist)
        {
            InitializeComponent();

            DataPointCollection list1 = chart1.Series[0].Points;
            DataPointCollection list2 = chart1.Series[1].Points;
            DataPointCollection list3 = chart1.Series[2].Points;
            DataPointCollection list4 = chart1.Series[3].Points;

            for (int i = 0; i < hist.GetLength(1); i++)
            {
                list1.AddXY(i, hist[0, i]);
                list2.AddXY(i, hist[1, i]);
                list3.AddXY(i, hist[2, i]);
                list4.AddXY(i, hist[3, i]);
            }
            chart1.Series[0].Color = Color.Gray;
            chart1.Series[1].Color = Color.Blue;
            chart1.Series[2].Color = Color.Green;
            chart1.Series[3].Color = Color.Red;
            chart1.ChartAreas[0].AxisX.Maximum = 255;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.ChartAreas[0].AxisY.Interval = 20;
            //chart1.ChartAreas[0].AxisY.IsLogarithmic = true;
            chart1.ChartAreas[0].AxisX.Title = "Intensidade";
            chart1.ChartAreas[0].AxisY.Title = "Contagem";
            chart1.ResumeLayout();

        }
    }
}
