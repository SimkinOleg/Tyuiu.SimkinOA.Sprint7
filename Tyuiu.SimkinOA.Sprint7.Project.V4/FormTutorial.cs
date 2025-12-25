using System.Windows.Forms;

namespace Tyuiu.SimkinOA.Sprint7.Project.V4
{
    public partial class FormTutorial : Form
    {
        public FormTutorial()
        {
            InitializeComponent();
            ApplyColorScheme();
        }

        private void buttonCloseTut_SOA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelInformation_SOA_Click(object sender, EventArgs e)
        {

        }
        private void ApplyColorScheme()
        {
            this.BackColor = Color.FromArgb(240, 245, 249);

            // GroupBox
            groupBoxInformation_SOA.ForeColor = Color.FromArgb(41, 128, 185);
            groupBoxInformation_SOA.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // Текст
            labelInformation_SOA.ForeColor = Color.Black;

            // Кнопка закрытия
            buttonCloseTut_SOA.BackColor = Color.FromArgb(231, 76, 60);
            buttonCloseTut_SOA.ForeColor = Color.White;
            buttonCloseTut_SOA.FlatStyle = FlatStyle.Flat;
            buttonCloseTut_SOA.FlatAppearance.BorderSize = 0;
            buttonCloseTut_SOA.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }
    }
}