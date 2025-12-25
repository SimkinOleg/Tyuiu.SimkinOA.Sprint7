namespace Tyuiu.SimkinOA.Sprint7.Project.V4
{
    partial class FormTutorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxInformation_SOA = new GroupBox();
            labelInformation_SOA = new Label();
            buttonCloseTut_SOA = new Button();
            groupBoxInformation_SOA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInformation_SOA
            // 
            groupBoxInformation_SOA.Controls.Add(labelInformation_SOA);
            groupBoxInformation_SOA.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxInformation_SOA.Location = new Point(14, 14);
            groupBoxInformation_SOA.Margin = new Padding(4, 3, 4, 3);
            groupBoxInformation_SOA.Name = "groupBoxInformation_SOA";
            groupBoxInformation_SOA.Padding = new Padding(4, 3, 4, 3);
            groupBoxInformation_SOA.Size = new Size(892, 360);
            groupBoxInformation_SOA.TabIndex = 1;
            groupBoxInformation_SOA.TabStop = false;
            groupBoxInformation_SOA.Text = "Краткое руководство пользователя";
            // 
            // labelInformation_SOA
            // 
            labelInformation_SOA.Dock = DockStyle.Fill;
            labelInformation_SOA.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInformation_SOA.Location = new Point(4, 18);
            labelInformation_SOA.Margin = new Padding(4, 0, 4, 0);
            labelInformation_SOA.Name = "labelInformation_SOA";
            labelInformation_SOA.Padding = new Padding(12, 12, 12, 12);
            labelInformation_SOA.Size = new Size(884, 339);
            labelInformation_SOA.TabIndex = 0;
            // СНАЧАЛА УДАЛИТЕ ЭТУ СТРОКУ (если есть):
            // labelInformation_SOA.Click += labelInformation_SOA_Click;
            // А ЗАТЕМ ДОБАВЬТЕ ЭТОТ ТЕКСТ:
            labelInformation_SOA.Text = @"1. ОТКРЫТИЕ ДАННЫХ
• Нажмите кнопку с иконкой папки 'Открыть файл'.
• Выберите CSV-файл с данными библиотеки.

2. РАБОТА С ДАННЫХ
• Просматривайте книги и читателей в таблице.
• Используйте поле 'Поиск', чтобы найти читателя по номеру билета.

3. СТАТИСТИКА
• Кнопки в группе 'Статистика' рассчитают:
    - Суммарную стоимость книг
    - Минимальную и максимальную цену
    - Среднюю стоимость
    - Количество читателей

4. ГРАФИКИ
• Нажмите 'Показать графики' для визуализации цен.

5. СОХРАНЕНИЕ
• Используйте кнопку с иконкой дискеты, чтобы сохранить изменения.

Справка: кнопка '?' откроет это руководство, кнопка 'i' — информацию о программе.";
            // 
            // buttonCloseTut_SOA
            // 
            buttonCloseTut_SOA.BackColor = Color.LightPink;
            buttonCloseTut_SOA.FlatStyle = FlatStyle.Flat;
            buttonCloseTut_SOA.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCloseTut_SOA.Location = new Point(783, 381);
            buttonCloseTut_SOA.Margin = new Padding(4, 3, 4, 3);
            buttonCloseTut_SOA.Name = "buttonCloseTut_SOA";
            buttonCloseTut_SOA.Size = new Size(114, 40);
            buttonCloseTut_SOA.TabIndex = 3;
            buttonCloseTut_SOA.Text = "Закрыть";
            buttonCloseTut_SOA.UseVisualStyleBackColor = false;
            buttonCloseTut_SOA.Click += buttonCloseTut_SOA_Click;
            // 
            // FormTutorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 435);
            Controls.Add(buttonCloseTut_SOA);
            Controls.Add(groupBoxInformation_SOA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTutorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тьюториал";
            groupBoxInformation_SOA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformation_SOA;
        private System.Windows.Forms.Label labelInformation_SOA;
        private System.Windows.Forms.Button buttonCloseTut_SOA;
    }
}