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
using Tyuiu.SimkinOA.Sprint7.Project.V4.Lib;

namespace Tyuiu.SimkinOA.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            ApplyColorScheme();
        }

        public string openFilePath;
        DataService ds = new DataService();

        private void buttonHelp_SOA_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
            buttonTutorial_SOA.Enabled = true;
        }

        static int cols;
        static int rows;
        public string path;
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

        private void buttonSaveFile_SOA_Click(object sender, EventArgs e)
        {
            saveFileDialog_SOA.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialog_SOA.DefaultExt = "csv";
            saveFileDialog_SOA.InitialDirectory = @"C:\Users\Desktop";
            saveFileDialog_SOA.FileName = "NewFile.csv";

            if (saveFileDialog_SOA.ShowDialog() == DialogResult.OK)
            {
                string pathnew = saveFileDialog_SOA.FileName;
                FileInfo file = new FileInfo(pathnew);
                if (file.Exists)
                {
                    File.Delete(pathnew);
                }

                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (j != cols - 1)
                        {
                            str = str + dataGridViewData_SOA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewData_SOA.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(pathnew, str + Environment.NewLine, Encoding.UTF8);
                    str = "";
                }

                MessageBox.Show("Файл успешно сохранен!", "Успех",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonOpenFile_SOA_Click(object sender, EventArgs e)
        {
            openFileDialog_SOA.ShowDialog();
            path = openFileDialog_SOA.FileName;

            string[,] res = Array(path);
            dataGridViewData_SOA.Columns.Clear();
            dataGridViewData_SOA.Rows.Clear();

            dataGridViewData_SOA.ColumnCount = cols;
            dataGridViewData_SOA.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewData_SOA.Rows[i].Cells[j].Value = res[i, j];
                    dataGridViewData_SOA.Columns[j].Width = 100;
                    dataGridViewData_SOA.Rows[i].Height = 25;
                }
            }

            buttonBookMax_SOA.Enabled = true;
            buttonCount_SOA.Enabled = true;
            buttonMax_SOA.Enabled = true;
            buttonMin_SOA.Enabled = true;
            buttonMiddle_SOA.Enabled = true;
            buttonSearch_SOA.Enabled = true;
            buttonSaveFile_SOA.Enabled = true;
        }

        private void buttonAddBook_SOA_Click(object sender, EventArgs e)
        {
            textBoxSumm_SOA.Text = Convert.ToString(ds.BookSumm(path, cost));
        }

        private void buttonMax_SOA_Click(object sender, EventArgs e)
        {
            textBoxMax_SOA.Text = Convert.ToString(ds.BookMax(path, cost));
        }

        private void buttonMin_SOA_Click(object sender, EventArgs e)
        {
            textBoxMin_SOA.Text = Convert.ToString(ds.BookMin(path, cost));
        }

        private void buttonMiddle_SOA_Click(object sender, EventArgs e)
        {
            textBoxMiddle_SOA.Text = Convert.ToString(ds.BookSumm(path, cost) / (rows - 1));
        }

        private void buttonCount_SOA_Click(object sender, EventArgs e)
        {
            textBoxCount_SOA.Text = Convert.ToString(rows - 1);
            buttonFunction_SOA.Enabled = true;
        }

        private void buttonSearch_SOA_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBoxNumber_SOA.Text);
                dataGridViewData_SOA.Columns.Clear();
                dataGridViewData_SOA.Rows.Clear();
                string[,] res = Array(path);
                dataGridViewData_SOA.ColumnCount = cols;
                dataGridViewData_SOA.RowCount = ID + 1;
                if (ID < rows)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (i == ID)
                            {
                                dataGridViewData_SOA.Rows[1].Cells[j].Value = res[i, j];
                                dataGridViewData_SOA.Columns[j].Width = 100;
                                dataGridViewData_SOA.Rows[i].Height = 25;
                            }
                            else if (i == 0)
                            {
                                dataGridViewData_SOA.Rows[i].Cells[j].Value = res[i, j];
                            }
                        }
                    }
                }
                else
                {
                    dataGridViewData_SOA.Columns.Clear();
                    dataGridViewData_SOA.Rows.Clear();
                    MessageBox.Show("В базе данных нет такого количества элементов! Загрузите файл заново!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                dataGridViewData_SOA.Columns.Clear();
                dataGridViewData_SOA.Rows.Clear();
                MessageBox.Show("Нельзя найти отрицательный или нулевой элемент! Загрузите файл заново!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTutorial_SOA_Click(object sender, EventArgs e)
        {
            FormTutorial formTut = new FormTutorial();
            formTut.ShowDialog();
            buttonOpenFile_SOA.Enabled = true;
        }

        private void buttonFunction_SOA_Click(object sender, EventArgs e)
        {
            FormFunction formf = new FormFunction();
            formf.pathFunc = path;
            formf.Show();
        }

        private void ApplyColorScheme()
        {
            // Фон формы
            this.BackColor = Color.FromArgb(240, 245, 249);

            // 1. УБИРАЕМ старые панели и меняем структуру
            panel1.Dock = DockStyle.None;
            panel2.Dock = DockStyle.None;

            // 2. ВЕРХНЯЯ ПАНЕЛЬ
            panelTop_SOA.BackColor = Color.FromArgb(52, 152, 219);
            panelTop_SOA.Dock = DockStyle.Top;
            panelTop_SOA.Height = 80;

            // Кнопки на верхней панели
            Color mainButtonColor = Color.FromArgb(52, 152, 219);
            buttonOpenFile_SOA.BackColor = mainButtonColor;
            buttonSaveFile_SOA.BackColor = mainButtonColor;
            buttonHelp_SOA.BackColor = Color.FromArgb(231, 76, 60);
            buttonTutorial_SOA.BackColor = Color.FromArgb(231, 76, 60);

            // Стиль кнопок верхней панели
            foreach (Control ctrl in panelTop_SOA.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }

            // 3. ЛЕВАЯ ПАНЕЛЬ С КНОПКАМИ - УВЕЛИЧИВАЕМ ШИРИНУ
            panel1.Location = new Point(0, panelTop_SOA.Height);
            panel1.Size = new Size(380, this.ClientSize.Height - panelTop_SOA.Height); // Увеличили с 300 до 380
            panel1.BackColor = Color.FromArgb(41, 128, 185);

            // GroupBox "Статистика" - увеличиваем ширину
            groupBoxStats_SOA.Location = new Point(15, 20);
            groupBoxStats_SOA.Size = new Size(350, 400); // Увеличили с 280 до 350
            groupBoxStats_SOA.ForeColor = Color.White;
            groupBoxStats_SOA.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Кнопки статистики - увеличиваем ширину кнопок
            int buttonY = 30;
            int buttonWidth = 320; // Увеличили с 250 до 320

            Button[] statButtons = { buttonBookMax_SOA, buttonMax_SOA, buttonMin_SOA,
                           buttonMiddle_SOA, buttonCount_SOA };
            string[] buttonTexts = { "📊 Сумма книг", "📈 Макс. цена", "📉 Мин. цена",
                           "⚖️ Средняя цена", "👥 Кол-во читателей" };

            for (int i = 0; i < statButtons.Length; i++)
            {
                statButtons[i].Location = new Point(15, buttonY);
                statButtons[i].Size = new Size(buttonWidth, 45);
                statButtons[i].BackColor = Color.FromArgb(52, 152, 219);
                statButtons[i].ForeColor = Color.White;
                statButtons[i].FlatStyle = FlatStyle.Flat;
                statButtons[i].FlatAppearance.BorderSize = 0;
                statButtons[i].Font = new Font("Segoe UI", 10, FontStyle.Bold);
                statButtons[i].Text = buttonTexts[i];
                buttonY += 55;
            }

            // Текстовые поля результатов - увеличиваем ширину
            TextBox[] resultBoxes = { textBoxSumm_SOA, textBoxMax_SOA, textBoxMin_SOA,
                            textBoxMiddle_SOA, textBoxCount_SOA };
            int textBoxY = buttonY + 10;

            for (int i = 0; i < resultBoxes.Length; i++)
            {
                resultBoxes[i].Location = new Point(15, textBoxY);
                resultBoxes[i].Size = new Size(buttonWidth, 30);
                resultBoxes[i].BackColor = Color.White;
                resultBoxes[i].ForeColor = Color.Black;
                resultBoxes[i].Font = new Font("Segoe UI", 9);
                textBoxY += 35;
            }

            // GroupBox "Поиск" - увеличиваем ширину
            groupBox1.Location = new Point(15, textBoxY + 20);
            groupBox1.Size = new Size(350, 180); // Увеличили с 280 до 350
            groupBox1.ForeColor = Color.White;
            groupBox1.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Элементы поиска - увеличиваем ширину
            label2.Location = new Point(15, 30);
            label2.ForeColor = Color.White;
            label2.Font = new Font("Segoe UI", 10);

            textBoxNumber_SOA.Location = new Point(15, 60);
            textBoxNumber_SOA.Size = new Size(320, 30); // Увеличили с 250 до 320
            textBoxNumber_SOA.BackColor = Color.White;

            buttonSearch_SOA.Location = new Point(15, 100);
            buttonSearch_SOA.Size = new Size(320, 45); // Увеличили с 250 до 320
            buttonSearch_SOA.BackColor = Color.FromArgb(46, 204, 113);
            buttonSearch_SOA.ForeColor = Color.White;
            buttonSearch_SOA.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonSearch_SOA.Text = "🔍 Найти читателя";
            buttonSearch_SOA.FlatStyle = FlatStyle.Flat;
            buttonSearch_SOA.FlatAppearance.BorderSize = 0;

            // 4. Кнопка "Графики" - увеличиваем ширину
            buttonFunction_SOA.Location = new Point(15, panel1.Height - 100);
            buttonFunction_SOA.Size = new Size(350, 60); // Увеличили с 280 до 350
            buttonFunction_SOA.BackColor = Color.FromArgb(155, 89, 182);
            buttonFunction_SOA.ForeColor = Color.White;
            buttonFunction_SOA.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            buttonFunction_SOA.Text = "📈 ПОКАЗАТЬ ГРАФИКИ";
            buttonFunction_SOA.FlatStyle = FlatStyle.Flat;
            buttonFunction_SOA.FlatAppearance.BorderSize = 0;

            // 5. ОСНОВНАЯ ОБЛАСТЬ С ДАННЫМИ - уменьшаем ширину из-за увеличения левой панели
            panel2.Location = new Point(panel1.Width, panelTop_SOA.Height);
            panel2.Size = new Size(this.ClientSize.Width - panel1.Width,
                                 this.ClientSize.Height - panelTop_SOA.Height);
            panel2.BackColor = Color.FromArgb(240, 245, 249);

            // DataGridView на всю правую область
            dataGridViewData_SOA.Dock = DockStyle.Fill;
            dataGridViewData_SOA.BackgroundColor = Color.FromArgb(240, 245, 249);
            dataGridViewData_SOA.GridColor = Color.FromArgb(200, 200, 200);
            dataGridViewData_SOA.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewData_SOA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewData_SOA.ColumnHeadersHeight = 40;
            dataGridViewData_SOA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewData_SOA.EnableHeadersVisualStyles = false;
            dataGridViewData_SOA.RowHeadersVisible = false;
            dataGridViewData_SOA.Font = new Font("Segoe UI", 10);
        }
    }
}