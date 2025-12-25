using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SimkinOA.Sprint7.Project.V4
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            labelInformation_SOA.Text = "Симкин О.А.\r\nГруппа: РППб-25-1\r\nПредмет: Программирование\r\nСпринт 7, Проект V4\r\nТюменский индустриальный университет";


            labelAboutProgramm_SOA.Text = "Программа \"Библиотека\"\r\n\r\nФункционал:\r\n• Загрузка данных из CSV\r\n• Просмотр и редактирование\r\n• Поиск и статистика\r\n• Построение графиков\r\n• Сохранение изменений\r\n\r\nВсе данные хранятся в CSV-файлах.";

        }

        private void buttonClose_SOA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}