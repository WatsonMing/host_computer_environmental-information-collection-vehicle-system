﻿namespace uart
{
    partial class DataChart_Analysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataChart_Analysis));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.dataStart = new System.Windows.Forms.DateTimePicker();
            this.dataStop = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.clean = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.search = new System.Windows.Forms.Button();
            this.strname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nurseryText = new System.Windows.Forms.Label();
            this.maturityText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.temp_Avg = new System.Windows.Forms.Label();
            this.humi_Avg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(840, 30);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(537, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(840, 358);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(537, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1069, 693);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "——→";
            // 
            // dataStart
            // 
            this.dataStart.CalendarFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataStart.Location = new System.Drawing.Point(930, 689);
            this.dataStart.Name = "dataStart";
            this.dataStart.Size = new System.Drawing.Size(122, 21);
            this.dataStart.TabIndex = 6;
            this.dataStart.Value = new System.DateTime(2018, 3, 23, 0, 0, 0, 0);
            this.dataStart.ValueChanged += new System.EventHandler(this.dataStart_ValueChanged);
            // 
            // dataStop
            // 
            this.dataStop.CalendarFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataStop.Location = new System.Drawing.Point(1124, 689);
            this.dataStop.Name = "dataStop";
            this.dataStop.Size = new System.Drawing.Size(122, 21);
            this.dataStop.TabIndex = 7;
            this.dataStop.ValueChanged += new System.EventHandler(this.dataStop_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(837, 692);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "日期选择:";
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.White;
            this.clean.BackgroundImage = global::uart.Properties.Resources.button;
            this.clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clean.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clean.ForeColor = System.Drawing.Color.White;
            this.clean.Location = new System.Drawing.Point(1279, 684);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(98, 30);
            this.clean.TabIndex = 9;
            this.clean.Text = "清空";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(81, 405);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(537, 300);
            this.chart3.TabIndex = 10;
            this.chart3.Text = "chart3";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.BackgroundImage = global::uart.Properties.Resources.button;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(304, 335);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(98, 31);
            this.search.TabIndex = 11;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // strname
            // 
            this.strname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.strname.Location = new System.Drawing.Point(161, 339);
            this.strname.Name = "strname";
            this.strname.Size = new System.Drawing.Size(100, 26);
            this.strname.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(77, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "作物:";
            // 
            // nurseryText
            // 
            this.nurseryText.AutoSize = true;
            this.nurseryText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nurseryText.Location = new System.Drawing.Point(624, 685);
            this.nurseryText.Name = "nurseryText";
            this.nurseryText.Size = new System.Drawing.Size(68, 16);
            this.nurseryText.TabIndex = 14;
            this.nurseryText.Text = "幼苗期:";
            // 
            // maturityText
            // 
            this.maturityText.AutoSize = true;
            this.maturityText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maturityText.Location = new System.Drawing.Point(624, 643);
            this.maturityText.Name = "maturityText";
            this.maturityText.Size = new System.Drawing.Size(68, 16);
            this.maturityText.TabIndex = 15;
            this.maturityText.Text = "成熟期:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(624, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "温度平均值:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(624, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "湿度平均值:";
            // 
            // temp_Avg
            // 
            this.temp_Avg.AutoSize = true;
            this.temp_Avg.Location = new System.Drawing.Point(744, 314);
            this.temp_Avg.Name = "temp_Avg";
            this.temp_Avg.Size = new System.Drawing.Size(53, 12);
            this.temp_Avg.TabIndex = 18;
            this.temp_Avg.Text = "temp_Avg";
            // 
            // humi_Avg
            // 
            this.humi_Avg.AutoSize = true;
            this.humi_Avg.Location = new System.Drawing.Point(744, 362);
            this.humi_Avg.Name = "humi_Avg";
            this.humi_Avg.Size = new System.Drawing.Size(53, 12);
            this.humi_Avg.TabIndex = 19;
            this.humi_Avg.Text = "humi_Avg";
            // 
            // DataChart_Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 781);
            this.Controls.Add(this.humi_Avg);
            this.Controls.Add(this.temp_Avg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maturityText);
            this.Controls.Add(this.nurseryText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.strname);
            this.Controls.Add(this.search);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataStop);
            this.Controls.Add(this.dataStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataChart_Analysis";
            this.Text = "图表分析";
            this.Load += new System.EventHandler(this.DataChart_Analysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataStart;
        private System.Windows.Forms.DateTimePicker dataStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox strname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nurseryText;
        private System.Windows.Forms.Label maturityText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label temp_Avg;
        private System.Windows.Forms.Label humi_Avg;
    }
}