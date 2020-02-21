﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CubicSplines
{
    internal class WorkWithInformation
    {
        /*  Вывод информции о функции в DataGridView,  */
        public static void WriteToDataGridView(
            Dictionary<double, double> a, DataGridView a1)
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

        /*  Запись в файл,   */
        public static void WriteToFile(DataGridView a,
            string s)
        {
            var f1 = new StreamWriter(s);
            for (var i = 0; i < a.RowCount; i++)
            {
                f1.WriteLine("{0} {1}", a[0, i].Value, a[1, i].Value);
            }

            f1.Close();
        }

        /*  Создание словаря случайных значений, 
          случайные значения принадлежат отрезку [a1,b1],
          количество значений  n,                              */
        public static Dictionary<double, double> CreateDictionary(
            double a1, double b1, int n)
        {
            var a = new Dictionary<double, double>();
            var q = new List<double>();
            var r = new Random();
            double w = 0;
            q.Add(a1);
            q.Add(b1);
            while (q.Count < n)
            {
                w = a1 + (b1 - a1) * (1.0 * r.Next(100)) / 100;
                if (!q.Contains(w))
                {
                    q.Add(w);
                }
            }

            q.Sort();
            for (var i = 0; i < n; i++)
            {
                a[q[i]] = 1.0 * r.Next(100) / 10;
            }

            return a;
        }


        /*    Чтение информации из файла, 
           прочитанные  значения 
           сортируются по значению аргумента, 
           между значениями в файле может быть 
           любое число пробелов,  */
        public static Dictionary<double, double> ReadFile(string s)
        {
            var a = new Dictionary<double, double>();
            var b = new Dictionary<double, double>();
            var f1 = new StreamReader(s, Encoding.Default);
            double a1 = 0;
            double a2 = 0;
            string s1;
            var q = new List<double>();
            while (!f1.EndOfStream)
            {
                s1 = f1.ReadLine();
                while (s1.Contains("  "))
                {
                    s1 = s1.Replace("  ", " ");
                }

                var words = s1.Split();
                if (double.TryParse(words[0], out a1) &&
                    double.TryParse(words[1], out a2))
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
                q = new List<double>(b.Keys);
                q.Sort();
                for (var i = 0; i < q.Count; i++)
                {
                    a[q[i]] = b[q[i]];
                }
            }

            f1.Close();
            return a;
        }
    }
}