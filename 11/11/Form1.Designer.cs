namespace _11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Xi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Variance = new System.Windows.Forms.Label();
            this.Avarage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Prob2 = new System.Windows.Forms.TextBox();
            this.Prob1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Xi
            // 
            this.Xi.AutoSize = true;
            this.Xi.Location = new System.Drawing.Point(444, 526);
            this.Xi.Name = "Xi";
            this.Xi.Size = new System.Drawing.Size(54, 13);
            this.Xi.TabIndex = 57;
            this.Xi.Text = "значение";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Хи-квадрад";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Дисперсия";
            // 
            // Variance
            // 
            this.Variance.AutoSize = true;
            this.Variance.Location = new System.Drawing.Point(444, 481);
            this.Variance.Name = "Variance";
            this.Variance.Size = new System.Drawing.Size(54, 13);
            this.Variance.TabIndex = 54;
            this.Variance.Text = "значение";
            // 
            // Avarage
            // 
            this.Avarage.AutoSize = true;
            this.Avarage.Location = new System.Drawing.Point(444, 435);
            this.Avarage.Name = "Avarage";
            this.Avarage.Size = new System.Drawing.Size(54, 13);
            this.Avarage.TabIndex = 53;
            this.Avarage.Text = "значение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Мат. ожидание";
            // 
            // NN
            // 
            this.NN.Location = new System.Drawing.Point(192, 384);
            this.NN.Name = "NN";
            this.NN.Size = new System.Drawing.Size(67, 20);
            this.NN.TabIndex = 51;
            this.NN.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Количество попыток";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(303, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 96);
            this.button1.TabIndex = 49;
            this.button1.Text = "ПОЕХАЛИ!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Дисперсия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Мат. ожидание";
            // 
            // Prob2
            // 
            this.Prob2.Location = new System.Drawing.Point(192, 343);
            this.Prob2.Name = "Prob2";
            this.Prob2.Size = new System.Drawing.Size(67, 20);
            this.Prob2.TabIndex = 41;
            this.Prob2.Text = "3";
            // 
            // Prob1
            // 
            this.Prob1.Location = new System.Drawing.Point(192, 298);
            this.Prob1.Name = "Prob1";
            this.Prob1.Size = new System.Drawing.Size(67, 20);
            this.Prob1.TabIndex = 40;
            this.Prob1.Text = "2";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(277, 36);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(511, 368);
            this.chart1.TabIndex = 58;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 712);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Xi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Variance);
            this.Controls.Add(this.Avarage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prob2);
            this.Controls.Add(this.Prob1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Xi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Variance;
        private System.Windows.Forms.Label Avarage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Prob2;
        private System.Windows.Forms.TextBox Prob1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

