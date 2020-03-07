using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CubicSplines
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///     Значения аргумента и функции
        /// </summary>
        private Dictionary<double, double> functionFromFile = new Dictionary<double, double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadToolStripMenu_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            functionFromFile = InformationService.ReadFile(openFileDialog.FileName);
            InformationService.WriteToDataGridView(dataGridView, functionFromFile);
            var spline = new Spline(functionFromFile);
            spline.OutToDataGridView(dataGridView2);
            
            DrawSeries(spline);
        }

        private void DrawSeries(Spline spline)
        {
            chart1.Series.Clear();
            var series = new Series("1") {ChartType = SeriesChartType.Point};
            spline.AddPointsToSeries(series);
            chart1.Series.Add(series);
            
            var series2 = new Series("2"){ChartType = SeriesChartType.Spline};
            foreach (var fun in spline.GetSolution())
            {
                series2.Points.AddXY(fun.Key, fun.Value);
            }

            chart1.Series.Add(series2);
            
            chart1.Update();
            chart1.ChartAreas.ForEach(x=>x.RecalculateAxesScale());
        }

        private void RandomValuesToolStripMenu_Click(object sender, EventArgs e)
        {
            functionFromFile = InformationService.GetRandomFunction(1, 10, 10);
            InformationService.WriteToDataGridView(dataGridView, functionFromFile);
            var spline = new Spline(functionFromFile);
            spline.OutToDataGridView(dataGridView2);
            DrawSeries(spline);
        }

        private void SaveValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Application.StartupPath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK && dataGridView.RowCount > 0)
            {
                InformationService.WriteToFile(
                    dataGridView, saveFileDialog.FileName);
            }
        }
    }
}