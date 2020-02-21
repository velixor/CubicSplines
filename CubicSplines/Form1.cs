using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CubicSplines
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Значения аргумента и функции
        /// </summary>
        private Dictionary<double, double> x = new Dictionary<double, double>();

        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Действия при выборе пункта меню для чтения значений аргумента и функции из файла
        /// </summary>
        private void ReadToolStripMenu_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                x = WorkWithInformation.ReadFile(
                    openFileDialog.FileName);
                WorkWithInformation.WriteToDataGridView(
                    x, dataGridView);
                var a = new Spline(x);
                a.OutToDataGridView(dataGridView2);
            }
        }

        /// <summary>
        /// Действия при выборе пункта меню для создания значений аргумента и функции как случайных чисел
        /// </summary>
        private void RandomValuesToolStripMenu_Click(object sender, EventArgs e)
        {
            x = WorkWithInformation.CreateDictionary(1, 10, 50);
            WorkWithInformation.WriteToDataGridView(
                x, dataGridView);
            var a = new Spline(x);
            a.OutToDataGridView(dataGridView2);
        }

        /// <summary>
        /// Действия при выборе пункта меню для сохранения значений аргумента и функции в файл
        /// </summary>
        private void SaveValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Application.StartupPath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK
                && dataGridView.RowCount > 0)
            {
                WorkWithInformation.WriteToFile(
                    dataGridView, saveFileDialog.FileName);
            }
        }
    }
}