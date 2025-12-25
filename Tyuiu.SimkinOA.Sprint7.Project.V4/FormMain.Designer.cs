namespace Tyuiu.SimkinOA.Sprint7.Project.V4
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.panelTop_SOA = new System.Windows.Forms.Panel();
            this.buttonTutorial_SOA = new System.Windows.Forms.Button();
            this.buttonSaveFile_SOA = new System.Windows.Forms.Button();
            this.buttonHelp_SOA = new System.Windows.Forms.Button();
            this.buttonOpenFile_SOA = new System.Windows.Forms.Button();
            this.buttonBookMax_SOA = new System.Windows.Forms.Button();
            this.openFileDialog_SOA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_SOA = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewData_SOA = new System.Windows.Forms.DataGridView();
            this.textBoxSumm_SOA = new System.Windows.Forms.TextBox();
            this.groupBoxStats_SOA = new System.Windows.Forms.GroupBox();
            this.buttonFunction_SOA = new System.Windows.Forms.Button();
            this.textBoxCount_SOA = new System.Windows.Forms.TextBox();
            this.textBoxMiddle_SOA = new System.Windows.Forms.TextBox();
            this.textBoxMin_SOA = new System.Windows.Forms.TextBox();
            this.textBoxMax_SOA = new System.Windows.Forms.TextBox();
            this.buttonCount_SOA = new System.Windows.Forms.Button();
            this.buttonMiddle_SOA = new System.Windows.Forms.Button();
            this.buttonMin_SOA = new System.Windows.Forms.Button();
            this.buttonMax_SOA = new System.Windows.Forms.Button();
            this.toolTip_SOA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber_SOA = new System.Windows.Forms.TextBox();
            this.buttonSearch_SOA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTop_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_SOA)).BeginInit();
            this.groupBoxStats_SOA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_SOA
            // 
            this.panelTop_SOA.Controls.Add(this.buttonTutorial_SOA);
            this.panelTop_SOA.Controls.Add(this.buttonSaveFile_SOA);
            this.panelTop_SOA.Controls.Add(this.buttonHelp_SOA);
            this.panelTop_SOA.Controls.Add(this.buttonOpenFile_SOA);
            this.panelTop_SOA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SOA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SOA.Name = "panelTop_SOA";
            this.panelTop_SOA.Size = new System.Drawing.Size(1109, 92);
            this.panelTop_SOA.TabIndex = 0;



            // 
            // buttonTutorial_SOA
            // 
            this.buttonTutorial_SOA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTutorial_SOA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonTutorial_SOA.Enabled = false;
            this.buttonTutorial_SOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTutorial_SOA.Image = global::Tyuiu.SimkinOA.Sprint7.Project.V4.Properties.Resources.help;
            this.buttonTutorial_SOA.Location = new System.Drawing.Point(941, 13);
            this.buttonTutorial_SOA.Name = "buttonTutorial_SOA";
            this.buttonTutorial_SOA.Size = new System.Drawing.Size(75, 65);
            this.buttonTutorial_SOA.TabIndex = 4;
            this.toolTip_SOA.SetToolTip(this.buttonTutorial_SOA, "Краткое руководство о пользовании программой\r\n");
            this.buttonTutorial_SOA.UseVisualStyleBackColor = false;
            this.buttonTutorial_SOA.Click += new System.EventHandler(this.buttonTutorial_SOA_Click);
            // 
            // buttonSaveFile_SOA
            // 
            this.buttonSaveFile_SOA.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSaveFile_SOA.Enabled = false;
            this.buttonSaveFile_SOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_SOA.Image = global::Tyuiu.SimkinOA.Sprint7.Project.V4.Properties.Resources.page_save;
            this.buttonSaveFile_SOA.Location = new System.Drawing.Point(93, 13);
            this.buttonSaveFile_SOA.Name = "buttonSaveFile_SOA";
            this.buttonSaveFile_SOA.Size = new System.Drawing.Size(75, 65);
            this.buttonSaveFile_SOA.TabIndex = 3;
            this.toolTip_SOA.SetToolTip(this.buttonSaveFile_SOA, "Сохранить файл по указаному пути");
            this.buttonSaveFile_SOA.UseVisualStyleBackColor = false;
            this.buttonSaveFile_SOA.Click += new System.EventHandler(this.buttonSaveFile_SOA_Click);
            // 
            // buttonHelp_SOA
            // 
            this.buttonHelp_SOA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SOA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHelp_SOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SOA.Image = global::Tyuiu.SimkinOA.Sprint7.Project.V4.Properties.Resources.information;
            this.buttonHelp_SOA.Location = new System.Drawing.Point(1022, 13);
            this.buttonHelp_SOA.Name = "buttonHelp_SOA";
            this.buttonHelp_SOA.Size = new System.Drawing.Size(75, 65);
            this.buttonHelp_SOA.TabIndex = 2;
            this.toolTip_SOA.SetToolTip(this.buttonHelp_SOA, "Информации о программе\r\nи разработчике");
            this.buttonHelp_SOA.UseVisualStyleBackColor = false;
            this.buttonHelp_SOA.Click += new System.EventHandler(this.buttonHelp_SOA_Click);
            // 
            // buttonOpenFile_SOA
            // 
            this.buttonOpenFile_SOA.BackColor = System.Drawing.SystemColors.Info;
            this.buttonOpenFile_SOA.Enabled = false;
            this.buttonOpenFile_SOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_SOA.Image = global::Tyuiu.SimkinOA.Sprint7.Project.V4.Properties.Resources.folder_page;
            this.buttonOpenFile_SOA.Location = new System.Drawing.Point(12, 13);
            this.buttonOpenFile_SOA.Name = "buttonOpenFile_SOA";
            this.buttonOpenFile_SOA.Size = new System.Drawing.Size(75, 65);
            this.buttonOpenFile_SOA.TabIndex = 0;
            this.toolTip_SOA.SetToolTip(this.buttonOpenFile_SOA, "Выберите фалй, с которым вы хотите выполнить редактирование\r\nили поиск информации" +
        "\r\n");
            this.buttonOpenFile_SOA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SOA.Click += new System.EventHandler(this.buttonOpenFile_SOA_Click);
            // 
            // buttonBookMax_SOA
            // 
            this.buttonBookMax_SOA.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonBookMax_SOA.Enabled = false;
            this.buttonBookMax_SOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookMax_SOA.Location = new System.Drawing.Point(6, 49);
            this.buttonBookMax_SOA.Name = "buttonBookMax_SOA";
            this.buttonBookMax_SOA.Size = new System.Drawing.Size(98, 37);
            this.buttonBookMax_SOA.TabIndex = 1;
            this.buttonBookMax_SOA.Text = "Сумма книг\r\n\r\n";
            this.toolTip_SOA.SetToolTip(this.buttonBookMax_SOA, "Считает общую стоимость \r\nвсех книг в базе данных");
            this.buttonBookMax_SOA.UseVisualStyleBackColor = false;
            this.buttonBookMax_SOA.Click += new System.EventHandler(this.buttonAddBook_SOA_Click);
            // 
            // openFileDialog_SOA
            // 
            this.openFileDialog_SOA.FileName = "openFileDialog1";
            // 
            // dataGridViewData_SOA
            // 
            this.dataGridViewData_SOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_SOA.ColumnHeadersVisible = false;
            this.dataGridViewData_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData_SOA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewData_SOA.Name = "dataGridViewData_SOA";
            this.dataGridViewData_SOA.RowHeadersVisible = false;
            this.dataGridViewData_SOA.Size = new System.Drawing.Size(1109, 391);
            this.dataGridViewData_SOA.TabIndex = 1;
            // 
            // textBoxSumm_SOA
            // 
            this.textBoxSumm_SOA.Location = new System.Drawing.Point(7, 92);
            this.textBoxSumm_SOA.Name = "textBoxSumm_SOA";
            this.textBoxSumm_SOA.ReadOnly = true;
            this.textBoxSumm_SOA.Size = new System.Drawing.Size(97, 20);
            this.textBoxSumm_SOA.TabIndex = 2;
            // 
            // groupBoxStats_SOA
            // 
            this.groupBoxStats_SOA.Controls.Add(this.buttonFunction_SOA);
            this.groupBoxStats_SOA.Controls.Add(this.textBoxCount_SOA);
            this.groupBoxStats_SOA.Controls.Add(this.textBoxMiddle_SOA);
            this.groupBoxStats_SOA.Controls.Add(this.textBoxMin_SOA);
            this.groupBoxStats_SOA.Controls.Add(this.textBoxMax_SOA);
            this.groupBoxStats_SOA.Controls.Add(this.buttonCount_SOA);
            this.groupBoxStats_SOA.Controls.Add(this.buttonMiddle_SOA);
            this.groupBoxStats_SOA.Controls.Add(this.buttonMin_SOA);
            this.groupBoxStats_SOA.Controls.Add(this.buttonMax_SOA);
            this.groupBoxStats_SOA.Controls.Add(this.textBoxSumm_SOA);
            this.groupBoxStats_SOA.Controls.Add(this.buttonBookMax_SOA);
            this.groupBoxStats_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxStats_SOA.Location = new System.Drawing.Point(12, 15);
            this.groupBoxStats_SOA.Name = "groupBoxStats_SOA";
            this.groupBoxStats_SOA.Size = new System.Drawing.Size(640, 149);
            this.groupBoxStats_SOA.TabIndex = 4;
            this.groupBoxStats_SOA.TabStop = false;
            this.groupBoxStats_SOA.Text = "Статистика";
            // 
            // buttonFunction_SOA
            // 
            this.buttonFunction_SOA.BackColor = System.Drawing.Color.Khaki;
            this.buttonFunction_SOA.Enabled = false;
            this.buttonFunction_SOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFunction_SOA.Location = new System.Drawing.Point(525, 47);
            this.buttonFunction_SOA.Name = "buttonFunction_SOA";
            this.buttonFunction_SOA.Size = new System.Drawing.Size(109, 65);
            this.buttonFunction_SOA.TabIndex = 11;
            this.buttonFunction_SOA.Text = "Показать графики";
            this.buttonFunction_SOA.UseVisualStyleBackColor = false;
            this.buttonFunction_SOA.Click += new System.EventHandler(this.buttonFunction_SOA_Click);
            // 
            // textBoxCount_SOA
            // 
            this.textBoxCount_SOA.Location = new System.Drawing.Point(421, 92);
            this.textBoxCount_SOA.Name = "textBoxCount_SOA";
            this.textBoxCount_SOA.ReadOnly = true;
            this.textBoxCount_SOA.Size = new System.Drawing.Size(98, 20);
            this.textBoxCount_SOA.TabIndex = 10;
            // 
            // textBoxMiddle_SOA
            // 
            this.textBoxMiddle_SOA.Location = new System.Drawing.Point(318, 92);
            this.textBoxMiddle_SOA.Name = "textBoxMiddle_SOA";
            this.textBoxMiddle_SOA.ReadOnly = true;
            this.textBoxMiddle_SOA.Size = new System.Drawing.Size(97, 20);
            this.textBoxMiddle_SOA.TabIndex = 9;
            // 
            // textBoxMin_SOA
            // 
            this.textBoxMin_SOA.Location = new System.Drawing.Point(214, 92);
            this.textBoxMin_SOA.Name = "textBoxMin_SOA";
            this.textBoxMin_SOA.ReadOnly = true;
            this.textBoxMin_SOA.Size = new System.Drawing.Size(98, 20);
            this.textBoxMin_SOA.TabIndex = 8;
            // 
            // textBoxMax_SOA
            // 
            this.textBoxMax_SOA.Location = new System.Drawing.Point(110, 92);
            this.textBoxMax_SOA.Name = "textBoxMax_SOA";
            this.textBoxMax_SOA.ReadOnly = true;
            this.textBoxMax_SOA.Size = new System.Drawing.Size(98, 20);
            this.textBoxMax_SOA.TabIndex = 7;
            // 
            // buttonCount_SOA
            // 
            this.buttonCount_SOA.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonCount_SOA.Enabled = false;
            this.buttonCount_SOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCount_SOA.Location = new System.Drawing.Point(421, 49);
            this.buttonCount_SOA.Name = "buttonCount_SOA";
            this.buttonCount_SOA.Size = new System.Drawing.Size(98, 37);
            this.buttonCount_SOA.TabIndex = 6;
            this.buttonCount_SOA.Text = "Кол-во читателей";
            this.toolTip_SOA.SetToolTip(this.buttonCount_SOA, "Выводит количество людей, \r\nкоторые взяли книгу");
            this.buttonCount_SOA.UseVisualStyleBackColor = false;
            this.buttonCount_SOA.Click += new System.EventHandler(this.buttonCount_SOA_Click);
            // 
            // buttonMiddle_SOA
            // 
            this.buttonMiddle_SOA.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonMiddle_SOA.Enabled = false;
            this.buttonMiddle_SOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMiddle_SOA.Location = new System.Drawing.Point(318, 49);
            this.buttonMiddle_SOA.Name = "buttonMiddle_SOA";
            this.buttonMiddle_SOA.Size = new System.Drawing.Size(98, 37);
            this.buttonMiddle_SOA.TabIndex = 5;
            this.buttonMiddle_SOA.Text = "Срденяя стоимость";
            this.toolTip_SOA.SetToolTip(this.buttonMiddle_SOA, "Выводит среднюю стоимость книги\r\n");
            this.buttonMiddle_SOA.UseVisualStyleBackColor = false;
            this.buttonMiddle_SOA.Click += new System.EventHandler(this.buttonMiddle_SOA_Click);
            // 
            // buttonMin_SOA
            // 
            this.buttonMin_SOA.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonMin_SOA.Enabled = false;
            this.buttonMin_SOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin_SOA.Location = new System.Drawing.Point(214, 49);
            this.buttonMin_SOA.Name = "buttonMin_SOA";
            this.buttonMin_SOA.Size = new System.Drawing.Size(98, 37);
            this.buttonMin_SOA.TabIndex = 4;
            this.buttonMin_SOA.Text = "Мин. стоимость";
            this.toolTip_SOA.SetToolTip(this.buttonMin_SOA, "Выводит стоимость самой дешевой книги");
            this.buttonMin_SOA.UseVisualStyleBackColor = false;
            this.buttonMin_SOA.Click += new System.EventHandler(this.buttonMin_SOA_Click);
            // 
            // buttonMax_SOA
            // 
            this.buttonMax_SOA.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonMax_SOA.Enabled = false;
            this.buttonMax_SOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax_SOA.Location = new System.Drawing.Point(110, 49);
            this.buttonMax_SOA.Name = "buttonMax_SOA";
            this.buttonMax_SOA.Size = new System.Drawing.Size(98, 37);
            this.buttonMax_SOA.TabIndex = 3;
            this.buttonMax_SOA.Text = "Макс. стоимость";
            this.toolTip_SOA.SetToolTip(this.buttonMax_SOA, "Выводит стоимость самой дорогой книги");
            this.buttonMax_SOA.UseVisualStyleBackColor = false;
            this.buttonMax_SOA.Click += new System.EventHandler(this.buttonMax_SOA_Click);
            // 
            // toolTip_SOA
            // 
            this.toolTip_SOA.IsBalloon = true;
            this.toolTip_SOA.Tag = "";
            this.toolTip_SOA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SOA.ToolTipTitle = "Подсказка";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNumber_SOA);
            this.groupBox1.Controls.Add(this.buttonSearch_SOA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(658, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 149);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по базе данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите номер читательского билета:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // textBoxNumber_SOA
            // 
            this.textBoxNumber_SOA.Location = new System.Drawing.Point(9, 51);
            this.textBoxNumber_SOA.Name = "textBoxNumber_SOA";
            this.textBoxNumber_SOA.Size = new System.Drawing.Size(72, 20);
            this.textBoxNumber_SOA.TabIndex = 1;
            // 
            // buttonSearch_SOA
            // 
            this.buttonSearch_SOA.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonSearch_SOA.Enabled = false;
            this.buttonSearch_SOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch_SOA.Location = new System.Drawing.Point(259, 30);
            this.buttonSearch_SOA.Name = "buttonSearch_SOA";
            this.buttonSearch_SOA.Size = new System.Drawing.Size(94, 36);
            this.buttonSearch_SOA.TabIndex = 0;
            this.buttonSearch_SOA.Text = "Найти";
            this.buttonSearch_SOA.UseVisualStyleBackColor = false;
            this.buttonSearch_SOA.Click += new System.EventHandler(this.buttonSearch_SOA_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxStats_SOA);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 188);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewData_SOA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 391);
            this.panel2.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop_SOA);
            this.MinimumSize = new System.Drawing.Size(1125, 710);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проект | Спринт 7 | Вариант 4| Симкин О.А.| РППб-25-1|";
            this.panelTop_SOA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_SOA)).EndInit();
            this.groupBoxStats_SOA.ResumeLayout(false);
            this.groupBoxStats_SOA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SOA;
        private System.Windows.Forms.Button buttonHelp_SOA;
        private System.Windows.Forms.Button buttonBookMax_SOA;
        private System.Windows.Forms.Button buttonOpenFile_SOA;
        private System.Windows.Forms.Button buttonSaveFile_SOA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SOA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_SOA;
        private System.Windows.Forms.DataGridView dataGridViewData_SOA;
        private System.Windows.Forms.TextBox textBoxSumm_SOA;
        private System.Windows.Forms.GroupBox groupBoxStats_SOA;
        private System.Windows.Forms.ToolTip toolTip_SOA;
        private System.Windows.Forms.Button buttonCount_SOA;
        private System.Windows.Forms.Button buttonMiddle_SOA;
        private System.Windows.Forms.Button buttonMin_SOA;
        private System.Windows.Forms.Button buttonMax_SOA;
        private System.Windows.Forms.TextBox textBoxCount_SOA;
        private System.Windows.Forms.TextBox textBoxMiddle_SOA;
        private System.Windows.Forms.TextBox textBoxMin_SOA;
        private System.Windows.Forms.TextBox textBoxMax_SOA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber_SOA;
        private System.Windows.Forms.Button buttonSearch_SOA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTutorial_SOA;
        private System.Windows.Forms.Button buttonFunction_SOA;
    }
}