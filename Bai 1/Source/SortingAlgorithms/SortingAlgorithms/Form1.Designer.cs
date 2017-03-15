namespace SortingAlgorithms
{
    partial class FrmChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.lbInput = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.cbInsert = new System.Windows.Forms.CheckBox();
            this.cbSelect = new System.Windows.Forms.CheckBox();
            this.cbBubble = new System.Windows.Forms.CheckBox();
            this.cbMerge = new System.Windows.Forms.CheckBox();
            this.cbQuickFirst = new System.Windows.Forms.CheckBox();
            this.cbQuickMiddle = new System.Windows.Forms.CheckBox();
            this.cbQuickRandom = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea2.AxisX.Title = "n";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Title = "µs";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY2.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea2.BorderWidth = 200;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.AutoFitMinFontSize = 20;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.MaximumAutoSize = 70F;
            legend2.Name = "Legend1";
            legend2.Title = "Ghi chú";
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(8, 96);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.CustomProperties = "PointWidth=1.5";
            series8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series8.IsValueShownAsLabel = true;
            series8.IsXValueIndexed = true;
            series8.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series8.LabelBorderWidth = 0;
            series8.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series8.Legend = "Legend1";
            series8.MarkerBorderWidth = 50;
            series8.MarkerSize = 10;
            series8.Name = "Insert";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.CustomProperties = "PointWidth=1";
            series9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.IsValueShownAsLabel = true;
            series9.IsXValueIndexed = true;
            series9.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series9.LabelForeColor = System.Drawing.Color.DarkOrange;
            series9.Legend = "Legend1";
            series9.MarkerBorderWidth = 50;
            series9.MarkerSize = 10;
            series9.Name = "Select";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.CustomProperties = "PointWidth=1";
            series10.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series10.IsValueShownAsLabel = true;
            series10.IsXValueIndexed = true;
            series10.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series10.LabelForeColor = System.Drawing.Color.OrangeRed;
            series10.Legend = "Legend1";
            series10.MarkerBorderWidth = 50;
            series10.MarkerSize = 10;
            series10.Name = "Bubble";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.CustomProperties = "PointWidth=1";
            series11.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series11.IsValueShownAsLabel = true;
            series11.IsXValueIndexed = true;
            series11.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series11.LabelForeColor = System.Drawing.Color.Navy;
            series11.Legend = "Legend1";
            series11.MarkerBorderWidth = 50;
            series11.MarkerSize = 10;
            series11.Name = "Merge";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            series12.IsValueShownAsLabel = true;
            series12.IsXValueIndexed = true;
            series12.Legend = "Legend1";
            series12.Name = "QuickFirst";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.CustomProperties = "PointWidth=1";
            series13.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series13.IsValueShownAsLabel = true;
            series13.IsXValueIndexed = true;
            series13.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series13.LabelForeColor = System.Drawing.Color.DarkGray;
            series13.Legend = "Legend1";
            series13.MarkerBorderWidth = 50;
            series13.MarkerSize = 10;
            series13.Name = "QuickMiddle";
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.CustomProperties = "PointWidth=1";
            series14.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic);
            series14.IsValueShownAsLabel = true;
            series14.Legend = "Legend1";
            series14.MarkerBorderWidth = 50;
            series14.MarkerSize = 10;
            series14.Name = "QuickRandom";
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(575, 353);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Biểu đồ thể hiện độ phức tạp của các giải thuật";
            this.chart1.Titles.Add(title2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(248, 14);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(57, 19);
            this.lbInput.TabIndex = 2;
            this.lbInput.Text = "Nhập n";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(332, 14);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(157, 26);
            this.txtN.TabIndex = 3;
            // 
            // cbInsert
            // 
            this.cbInsert.AutoSize = true;
            this.cbInsert.Checked = true;
            this.cbInsert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInsert.Location = new System.Drawing.Point(8, 12);
            this.cbInsert.Name = "cbInsert";
            this.cbInsert.Size = new System.Drawing.Size(72, 23);
            this.cbInsert.TabIndex = 4;
            this.cbInsert.Text = "Insert ";
            this.cbInsert.UseVisualStyleBackColor = true;
            // 
            // cbSelect
            // 
            this.cbSelect.AutoSize = true;
            this.cbSelect.Checked = true;
            this.cbSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSelect.Location = new System.Drawing.Point(86, 12);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(69, 23);
            this.cbSelect.TabIndex = 5;
            this.cbSelect.Text = "Select";
            this.cbSelect.UseVisualStyleBackColor = true;
            // 
            // cbBubble
            // 
            this.cbBubble.AutoSize = true;
            this.cbBubble.Checked = true;
            this.cbBubble.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBubble.Location = new System.Drawing.Point(161, 13);
            this.cbBubble.Name = "cbBubble";
            this.cbBubble.Size = new System.Drawing.Size(75, 23);
            this.cbBubble.TabIndex = 6;
            this.cbBubble.Text = "Bubble";
            this.cbBubble.UseVisualStyleBackColor = true;
            // 
            // cbMerge
            // 
            this.cbMerge.AutoSize = true;
            this.cbMerge.Checked = true;
            this.cbMerge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMerge.Location = new System.Drawing.Point(8, 54);
            this.cbMerge.Name = "cbMerge";
            this.cbMerge.Size = new System.Drawing.Size(74, 23);
            this.cbMerge.TabIndex = 7;
            this.cbMerge.Text = "Merge";
            this.cbMerge.UseVisualStyleBackColor = true;
            // 
            // cbQuickFirst
            // 
            this.cbQuickFirst.AutoSize = true;
            this.cbQuickFirst.Checked = true;
            this.cbQuickFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbQuickFirst.Location = new System.Drawing.Point(86, 54);
            this.cbQuickFirst.Name = "cbQuickFirst";
            this.cbQuickFirst.Size = new System.Drawing.Size(99, 23);
            this.cbQuickFirst.TabIndex = 8;
            this.cbQuickFirst.Text = "QuickFirst";
            this.cbQuickFirst.UseVisualStyleBackColor = true;
            // 
            // cbQuickMiddle
            // 
            this.cbQuickMiddle.AutoSize = true;
            this.cbQuickMiddle.Checked = true;
            this.cbQuickMiddle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbQuickMiddle.Location = new System.Drawing.Point(191, 54);
            this.cbQuickMiddle.Name = "cbQuickMiddle";
            this.cbQuickMiddle.Size = new System.Drawing.Size(116, 23);
            this.cbQuickMiddle.TabIndex = 11;
            this.cbQuickMiddle.Text = "QuickMiddle";
            this.cbQuickMiddle.UseVisualStyleBackColor = true;
            // 
            // cbQuickRandom
            // 
            this.cbQuickRandom.AutoSize = true;
            this.cbQuickRandom.Checked = true;
            this.cbQuickRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbQuickRandom.Location = new System.Drawing.Point(313, 54);
            this.cbQuickRandom.Name = "cbQuickRandom";
            this.cbQuickRandom.Size = new System.Drawing.Size(124, 23);
            this.cbQuickRandom.TabIndex = 12;
            this.cbQuickRandom.Text = "QuickRandom";
            this.cbQuickRandom.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(589, 112);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 23);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tăng dần";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(589, 141);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 23);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Giảm dần";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(589, 170);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 23);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ngẫu nhiên";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FrmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 474);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cbQuickRandom);
            this.Controls.Add(this.cbQuickMiddle);
            this.Controls.Add(this.cbQuickFirst);
            this.Controls.Add(this.cbMerge);
            this.Controls.Add(this.cbBubble);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.cbInsert);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChart";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.CheckBox cbInsert;
        private System.Windows.Forms.CheckBox cbSelect;
        private System.Windows.Forms.CheckBox cbBubble;
        private System.Windows.Forms.CheckBox cbMerge;
        private System.Windows.Forms.CheckBox cbQuickFirst;
        private System.Windows.Forms.CheckBox cbQuickMiddle;
        private System.Windows.Forms.CheckBox cbQuickRandom;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

