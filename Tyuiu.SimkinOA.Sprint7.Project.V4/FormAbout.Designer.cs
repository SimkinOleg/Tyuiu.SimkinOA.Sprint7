


namespace Tyuiu.SimkinOA.Sprint7.Project.V4
{
    partial class FormAbout
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
            pictureBoxAvtor_SOA = new PictureBox();
            labelInformation_SOA = new Label();
            groupBoxAboutProgramm_SOA = new GroupBox();
            labelAboutProgramm_SOA = new Label();
            buttonClose_SOA = new Button();
            groupBoxInformation_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvtor_SOA).BeginInit();
            groupBoxAboutProgramm_SOA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInformation_SOA
            // 
            groupBoxInformation_SOA.Controls.Add(pictureBoxAvtor_SOA);
            groupBoxInformation_SOA.Controls.Add(labelInformation_SOA);
            groupBoxInformation_SOA.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxInformation_SOA.Location = new Point(14, 14);
            groupBoxInformation_SOA.Margin = new Padding(4, 3, 4, 3);
            groupBoxInformation_SOA.Name = "groupBoxInformation_SOA";
            groupBoxInformation_SOA.Padding = new Padding(4, 3, 4, 3);
            groupBoxInformation_SOA.Size = new Size(662, 260);
            groupBoxInformation_SOA.TabIndex = 0;
            groupBoxInformation_SOA.TabStop = false;
            groupBoxInformation_SOA.Text = "О разработчике";
            // 
            // pictureBoxAvtor_SOA
            // 
            pictureBoxAvtor_SOA.Image = Properties.Resources.photo;
            pictureBoxAvtor_SOA.Location = new Point(7, 24);
            pictureBoxAvtor_SOA.Margin = new Padding(4, 3, 4, 3);
            pictureBoxAvtor_SOA.Name = "pictureBoxAvtor_SOA";
            pictureBoxAvtor_SOA.Size = new Size(173, 228);
            pictureBoxAvtor_SOA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvtor_SOA.TabIndex = 1;
            pictureBoxAvtor_SOA.TabStop = false;
            // 
            // labelInformation_SOA
            // 
            labelInformation_SOA.AutoSize = true;
            labelInformation_SOA.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInformation_SOA.Location = new Point(187, 24);
            labelInformation_SOA.Margin = new Padding(4, 0, 4, 0);
            labelInformation_SOA.Name = "labelInformation_SOA";
            labelInformation_SOA.Size = new Size(0, 16);
            labelInformation_SOA.TabIndex = 0;
            // 
            // groupBoxAboutProgramm_SOA
            // 
            groupBoxAboutProgramm_SOA.Controls.Add(labelAboutProgramm_SOA);
            groupBoxAboutProgramm_SOA.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxAboutProgramm_SOA.Location = new Point(14, 280);
            groupBoxAboutProgramm_SOA.Margin = new Padding(4, 3, 4, 3);
            groupBoxAboutProgramm_SOA.Name = "groupBoxAboutProgramm_SOA";
            groupBoxAboutProgramm_SOA.Padding = new Padding(4, 3, 4, 3);
            groupBoxAboutProgramm_SOA.Size = new Size(662, 182);
            groupBoxAboutProgramm_SOA.TabIndex = 1;
            groupBoxAboutProgramm_SOA.TabStop = false;
            groupBoxAboutProgramm_SOA.Text = "О программе";
            // 
            // labelAboutProgramm_SOA
            // 
            labelAboutProgramm_SOA.AutoSize = true;
            labelAboutProgramm_SOA.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAboutProgramm_SOA.Location = new Point(7, 21);
            labelAboutProgramm_SOA.Margin = new Padding(4, 0, 4, 0);
            labelAboutProgramm_SOA.Name = "labelAboutProgramm_SOA";
            labelAboutProgramm_SOA.Size = new Size(0, 16);
            labelAboutProgramm_SOA.TabIndex = 0;
            // 
            // buttonClose_SOA
            // 
            buttonClose_SOA.BackColor = Color.LightPink;
            buttonClose_SOA.FlatStyle = FlatStyle.Flat;
            buttonClose_SOA.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClose_SOA.Location = new Point(553, 470);
            buttonClose_SOA.Margin = new Padding(4, 3, 4, 3);
            buttonClose_SOA.Name = "buttonClose_SOA";
            buttonClose_SOA.Size = new Size(114, 40);
            buttonClose_SOA.TabIndex = 2;
            buttonClose_SOA.Text = "Закрыть";
            buttonClose_SOA.UseVisualStyleBackColor = false;
            buttonClose_SOA.Click += buttonClose_SOA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 518);
            Controls.Add(buttonClose_SOA);
            Controls.Add(groupBoxAboutProgramm_SOA);
            Controls.Add(groupBoxInformation_SOA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация";
            groupBoxInformation_SOA.ResumeLayout(false);
            groupBoxInformation_SOA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvtor_SOA).EndInit();
            groupBoxAboutProgramm_SOA.ResumeLayout(false);
            groupBoxAboutProgramm_SOA.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformation_SOA;
        private System.Windows.Forms.Label labelInformation_SOA;
        private System.Windows.Forms.PictureBox pictureBoxAvtor_SOA;
        private System.Windows.Forms.GroupBox groupBoxAboutProgramm_SOA;
        private System.Windows.Forms.Label labelAboutProgramm_SOA;
        private System.Windows.Forms.Button buttonClose_SOA;
    }
}