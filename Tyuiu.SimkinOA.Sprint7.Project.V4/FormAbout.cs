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
            ApplyColorScheme();
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

        private void ApplyColorScheme()
        {
            this.BackColor = Color.FromArgb(240, 245, 249);

            // GroupBox
            groupBoxInformation_SOA.ForeColor = Color.FromArgb(41, 128, 185);
            groupBoxAboutProgramm_SOA.ForeColor = Color.FromArgb(41, 128, 185);

            // Кнопка закрытия
            buttonClose_SOA.BackColor = Color.FromArgb(231, 76, 60);
            buttonClose_SOA.ForeColor = Color.White;
            buttonClose_SOA.FlatStyle = FlatStyle.Flat;
            buttonClose_SOA.FlatAppearance.BorderSize = 0;
            buttonClose_SOA.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // Labels (текст)
            labelInformation_SOA.ForeColor = Color.Black;
            labelAboutProgramm_SOA.ForeColor = Color.Black;

           
        }



    }

}