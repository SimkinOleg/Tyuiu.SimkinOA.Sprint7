using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SimkinOA.Sprint7.Project.V4
{
    public partial class FormFunction : Form
    {
        public FormFunction()
        {
            InitializeComponent();
            ApplyColorScheme();
        }

        private void buttonCloseTut_SOA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string pathFunc;
        static int rows;
        static int cols;
        static int cost;

        public static string[,] Array(string path)
        {

            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    try
                    {
                        int lin = Convert.ToInt32(strok[j]);
                        cost = j;
                        break;
                    }
                    catch
                    {
                        continue;
                    }

                }
            }

            string[,] mtr = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    mtr[i, j] = strok[j];
                }
            }
            return mtr;
        }

        private void FormFunction_Load(object sender, EventArgs e)
        {
            this.chartPrice_SOA.ChartAreas[0].AxisX.Title = "Номер читательского билета";
            this.chartPrice_SOA.ChartAreas[0].AxisY.Title = "Цена книги";
            this.chartPrice_SOA.Titles.Add("График цен книг, купленных читателями");
            chartPrice_SOA.Series[0].Points.Clear();
            string[,] res = Array(pathFunc);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((i > 0) && (j == cost))
                    {
                        chartPrice_SOA.Series[0].Points.AddXY(i, res[i, j]);
                    }
                }
            }
        }

        private void ApplyColorScheme()
        {
            this.BackColor = Color.FromArgb(240, 245, 249);

            // График
            chartPrice_SOA.BackColor = Color.FromArgb(240, 245, 249);
            chartPrice_SOA.ChartAreas[0].BackColor = Color.FromArgb(240, 245, 249);
            chartPrice_SOA.ChartAreas[0].AxisX.LineColor = Color.FromArgb(41, 128, 185);
            chartPrice_SOA.ChartAreas[0].AxisY.LineColor = Color.FromArgb(41, 128, 185);
            chartPrice_SOA.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.FromArgb(41, 128, 185);
            chartPrice_SOA.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(41, 128, 185);
            chartPrice_SOA.ChartAreas[0].AxisX.TitleForeColor = Color.FromArgb(41, 128, 185);
            chartPrice_SOA.ChartAreas[0].AxisY.TitleForeColor = Color.FromArgb(41, 128, 185);

            // Заголовок графика
            chartPrice_SOA.Titles[0].ForeColor = Color.FromArgb(41, 128, 185);

            // Легенда
            chartPrice_SOA.Legends[0].ForeColor = Color.FromArgb(41, 128, 185);

            // Кнопка закрытия
            buttonCloseTut_SOA.BackColor = Color.FromArgb(231, 76, 60);
            buttonCloseTut_SOA.ForeColor = Color.White;
            buttonCloseTut_SOA.FlatStyle = FlatStyle.Flat;
            buttonCloseTut_SOA.FlatAppearance.BorderSize = 0;
            buttonCloseTut_SOA.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }



    }
}