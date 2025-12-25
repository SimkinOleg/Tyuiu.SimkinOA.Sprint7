
namespace Tyuiu.SimkinOA.Sprint7.Project.V4
{
    partial class FormFunction
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPrice_SOA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCloseTut_SOA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice_SOA)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPrice_SOA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPrice_SOA.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.TitleForeColor = System.Drawing.Color.IndianRed;
            this.chartPrice_SOA.Legends.Add(legend1);
            this.chartPrice_SOA.Location = new System.Drawing.Point(3, 12);
            this.chartPrice_SOA.Name = "chartPrice_SOA";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "Цена";
            this.chartPrice_SOA.Series.Add(series1);
            this.chartPrice_SOA.Size = new System.Drawing.Size(785, 354);
            this.chartPrice_SOA.TabIndex = 0;
            this.chartPrice_SOA.Text = "chart1";
            // 
            // buttonCloseTut_SOA
            // 
            this.buttonCloseTut_SOA.BackColor = System.Drawing.Color.LightPink;
            this.buttonCloseTut_SOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseTut_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseTut_SOA.Location = new System.Drawing.Point(690, 386);
            this.buttonCloseTut_SOA.Name = "buttonCloseTut_SOA";
            this.buttonCloseTut_SOA.Size = new System.Drawing.Size(98, 35);
            this.buttonCloseTut_SOA.TabIndex = 4;
            this.buttonCloseTut_SOA.Text = "Закрыть";
            this.buttonCloseTut_SOA.UseVisualStyleBackColor = false;
            this.buttonCloseTut_SOA.Click += new System.EventHandler(this.buttonCloseTut_SOA_Click);
            // 
            // FormFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.buttonCloseTut_SOA);
            this.Controls.Add(this.chartPrice_SOA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 464);
            this.Name = "FormFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFunction";
            this.Load += new System.EventHandler(this.FormFunction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice_SOA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrice_SOA;
        private System.Windows.Forms.Button buttonCloseTut_SOA;
    }
}