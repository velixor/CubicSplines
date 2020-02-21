using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CubicSplines
{
    /// <summary>
    /// Класс для построения кубических сплайнов выполнения интерполяции
    /// </summary>
    internal class Spline
    {
        /// <summary>
        /// Коэффициенты a кубических сплайнов
        /// </summary>
        private readonly double[] a = new double[0];

        /// <summary>
        /// Коэффициенты b кубических сплайнов
        /// </summary>
        private readonly double[] b = new double[0];

        /// <summary>
        /// Коэффициенты c кубических сплайнов
        /// </summary>
        private readonly double[] c = new double[0];

        /// <summary>
        /// Коэффициенты d кубических сплайнов
        /// </summary>
        private readonly double[] d = new double[0];

        /// <summary>
        /// Длины отрезков разбиения
        /// </summary>
        private readonly double[] h = new double[0];

        /// <summary>
        /// Количество точек разбиения
        /// </summary>
        private readonly int n;

        /// <summary>
        /// Количество отрезков разбиения
        /// </summary>
        private readonly int n1;

        /// <summary>
        /// Значения аргумента, то есть точки разбиения
        /// </summary>
        private readonly double[] x = new double[0];

        /// <summary>
        /// Значения функции в точках разбиения
        /// </summary>
        private readonly double[] y = new double[0];

        /// <summary>
        /// Конструктор класса Spline
        /// </summary>
        public Spline(Dictionary<double, double> x1)
        {
            n = x1.Keys.Count;
            n1 = n > 0 ? n - 1 : 0;
            x = new double[n];
            y = new double[n];
            h = new double[n1];
            a = new double[n1];
            b = new double[n1];
            c = new double[n1];
            d = new double[n1];
            for (var i = 0; i < n; i++)
            {
                var a1 = x1.Keys.ElementAt(i);
                x[i] = a1;
                y[i] = x1[a1];
            }

            for (var i = 0; i < n1; i++)
            {
                h[i] = x[i + 1] - x[i];
            }

            CreateCoefficients();
        }

        /// <summary>
        /// Строка для вывода i-го сплайна
        /// </summary>
        private string SplineToString(int i)
        {
            var s = "";
            if (i >= 0 && i < n1)
            {
                s = string.Format("{1:0.###}+{2:0.###}(x-{0})+{3:0.###}(x-{0})^2+{4:0.###}(x-{0})^3,",
                    x[i], a[i], b[i], c[i], d[i]);
            }

            return s;
        }

        /// <summary>
        /// Значение i-го сплайна в точке
        /// </summary>
        private double SplineValue(double a1, int i)
        {
            double f = 0;
            if (i >= 0 && i < n1)
            {
                f = a[i] + b[i] * (a1 - x[i]) +
                    c[i] * Math.Pow(a1 - x[i], 2) +
                    d[i] * Math.Pow(a1 - x[i], 3);
            }

            return f;
        }


        /// <summary>
        /// Вывод информации о коэффициентах сплайнов и самих сплайнов в элемент управления DataGridView
        /// </summary>
        public void OutToDataGridView(DataGridView a1)
        {
            a1.ColumnCount = 7;
            a1.RowCount = n1;
            a1.Columns[0].HeaderText = "a";
            a1.Columns[1].HeaderText = "b";
            a1.Columns[2].HeaderText = "c";
            a1.Columns[3].HeaderText = "d";
            a1.Columns[4].HeaderText = "Сплайн fi";
            a1.Columns[5].HeaderText = "fi(xi)";
            a1.Columns[6].HeaderText = "fi(xi+1)";
            a1.Columns[4].Width = 500;
            for (var i = 0; i < n1; i++)
            {
                a1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                a1[0, i].Value = a[i];
                a1[1, i].Value = b[i];
                a1[2, i].Value = c[i];
                a1[3, i].Value = d[i];
                a1[4, i].Value = SplineToString(i);
                a1[5, i].Value = SplineValue(x[i], i);
                a1[6, i].Value = SplineValue(x[i + 1], i);
            }
        }

        /// <summary>
        /// Создание коэффициентов кубических сплайнов
        /// </summary>
        private void CreateCoefficients()
        {
            for (var i = 0; i < n1; i++)
            {
                a[i] = y[i];
            }

            var m = n1 - 1;
            var a1 = new double[m];
            var b1 = new double[m];
            var c1 = new double[m];
            var f = new double[m];
            var q = new double[m];
            for (var i = 0; i < m; i++)
            {
                a1[i] = h[i];
                b1[i] = 2 * (h[i] + h[i + 1]);
                c1[i] = h[i + 1];
                f[i] = 3 * ((y[i + 2] - y[i + 1]) / h[i + 1] - (y[i + 1] - y[i]) / h[i]);
            }

            a1[0] = 0;
            q = Solution(a1, b1, c1, f, m);
            c[0] = 0;
            for (var i = 0; i < m; i++)
            {
                c[i + 1] = q[i];
            }

            for (var i = 0; i < n1 - 1; i++)
            {
                b[i] = (y[i + 1] - y[i]) / h[i] -
                       h[i] * (c[i + 1] + 2 * c[i]) / 3;
                d[i] = (c[i + 1] - c[i]) / (3 * h[i]);
            }

            b[n - 2] = (y[n - 1] - y[n - 2]) / h[n - 2] -
                       2 * h[n - 2] * c[n - 2] / 3;
            d[n - 2] = -c[n - 2] / (3 * h[n - 2]);
        }

        /// <summary>
        /// Решение системы уравнений с трехдиагональной матрицей методом прогонки
        /// </summary>
        /// <param name="a">массив элементов под главной диагональю</param>
        /// <param name="b">главная диагональ</param>
        /// <param name="c">массив элементов над главной диагональю</param>
        /// <param name="f">столбец свободных членов</param>
        /// <param name="n">количество уравнений, порядок матрицы системы уравнений</param>
        /// <returns></returns>
        public static double[] Solution(
            double[] a, double[] b, double[] c,
            double[] f, int n)
        {
            var x = new double[n];
            // Прямой ход метода прогонки
            c[0] = c[0] / b[0];
            f[0] = f[0] / b[0];
            b[0] = 1;
            for (var i = 1; i < n; i++)
            {
                b[i] = b[i] - a[i] * c[i - 1];
                f[i] = f[i] - a[i] * f[i - 1];
                a[i] = 0;
            }

            /*  Обратный ход метода прогонки,    */
            x[n - 1] = f[n - 1] / b[n - 1];
            for (var i = n - 2; i >= 0; i--)
            {
                x[i] = f[i] - c[i] * x[i + 1];
            }

            return x;
        }
    }
}