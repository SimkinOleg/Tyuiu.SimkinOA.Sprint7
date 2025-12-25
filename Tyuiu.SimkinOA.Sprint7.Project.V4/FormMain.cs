using System.Text;
using Tyuiu.SimkinOA.Sprint7.Project.V4.Lib;
namespace Tyuiu.SimkinOA.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
            // 1. НАСТРОЙКА ДИАЛОГА (без имени по умолчанию)
            saveFileDialog_SOA.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialog_SOA.DefaultExt = "csv"; // Расширение по умолчанию
            saveFileDialog_SOA.InitialDirectory = @"C:\Users\Desktop";
            saveFileDialog_SOA.FileName = "NewFile.csv"; // Укажите нормальное имя по умолчанию

            // 2. ПОКАЗЫВАЕМ ДИАЛОГ И ПРОВЕРЯЕМ РЕЗУЛЬТАТ
            if (saveFileDialog_SOA.ShowDialog() == DialogResult.OK)
            {
                string pathnew = saveFileDialog_SOA.FileName;

                // 3. СОХРАНЕНИЕ ДАННЫХ
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

                                {
                                    dataGridViewData_SOA.Rows[1].Cells[j].Value = res[i, j];
                                    dataGridViewData_SOA.Columns[j].Width = 100;
                                    dataGridViewData_SOA.Rows[i].Height = 25;
                                }
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
    }
}