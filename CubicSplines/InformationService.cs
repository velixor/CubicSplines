using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CubicSplines
{
    internal class InformationService
    {
        // Вывод информции о функции в DataGridView
        public static void WriteToDataGridView(DataGridView a1, Dictionary<double, double> a)
        {
            a1.RowCount = a.Keys.Count;
            var i = 0;
            foreach (var i1 in a.Keys)
            {
                a1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                a1[0, i].Value = i1;
                a1[1, i].Value = a[i1];
                i++;
            }
        }

        // Запись в файл
        public static void WriteToFile(DataGridView a, string s)
        {
            var f1 = new StreamWriter(s);
            for (var i = 0; i < a.RowCount; i++)
            {
                f1.WriteLine("{0} {1}", a[0, i].Value, a[1, i].Value);
            }

            f1.Close();
        }

        /// <summary>
        /// Создание словаря случайных значений,
        /// случайные значения принадлежат отрезку [a1,b1], количество значений n
        /// </summary>
        public static Dictionary<double, double> GetRandomFunction(double a1, double b1, int n)
        {
            var random = new Random();
            var function = new Dictionary<double, double>();
            var h = (b1 - a1) / n;
            
            var x = a1;
            while (x<=b1)
            {
                var y = random.Next(-100, 100) / 10;
                function.Add(x, y);
                x += h;
            }

            return function;
        }


        /// <summary>
        /// Чтение информации из файла, прочитанные значения сортируются по значению аргумента, между значениями в файле может быть любое число пробелов
        /// </summary>
        public static Dictionary<double, double> ReadFile(string s)
        {
            var a = new Dictionary<double, double>();
            var b = new Dictionary<double, double>();
            var f1 = new StreamReader(s, Encoding.Default);
            
            while (!f1.EndOfStream)
            {
                var s1 = f1.ReadLine();
                while (s1.Contains("  "))
                {
                    s1 = s1.Replace("  ", " ");
                }

                var words = s1.Split();
                if (double.TryParse(words[0], out var a1) &&
                    double.TryParse(words[1], out var a2))
                {
                    b[a1] = a2;
                }
                else
                {
                    b = new Dictionary<double, double>();
                    break;
                }
            }

            if (b.Keys.Count > 0)
            {
                var q = new List<double>(b.Keys);
                q.Sort();
                foreach (var t in q)
                {
                    a[t] = b[t];
                }
            }

            f1.Close();
            return a;
        }
    }
}