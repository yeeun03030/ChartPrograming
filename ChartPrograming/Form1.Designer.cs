namespace ChartPrograming
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors1 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors2 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors3 = new CodeArtEng.Gauge.Themes.ThemeColors();
            this.highBtn = new System.Windows.Forms.Button();
            this.lowBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circularGauge1 = new CodeArtEng.Gauge.CircularGauge();
            this.linearGauge1 = new CodeArtEng.Gauge.LinearGauge();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // highBtn
            // 
            this.highBtn.BackColor = System.Drawing.SystemColors.Control;
            this.highBtn.Font = new System.Drawing.Font("굴림", 10F);
            this.highBtn.Location = new System.Drawing.Point(824, 89);
            this.highBtn.Name = "highBtn";
            this.highBtn.Size = new System.Drawing.Size(80, 60);
            this.highBtn.TabIndex = 0;
            this.highBtn.Text = "Start";
            this.highBtn.UseVisualStyleBackColor = false;
            this.highBtn.Click += new System.EventHandler(this.highBtn_Click);
            // 
            // lowBtn
            // 
            this.lowBtn.BackColor = System.Drawing.SystemColors.Control;
            this.lowBtn.Font = new System.Drawing.Font("굴림", 10F);
            this.lowBtn.Location = new System.Drawing.Point(910, 89);
            this.lowBtn.Name = "lowBtn";
            this.lowBtn.Size = new System.Drawing.Size(80, 60);
            this.lowBtn.TabIndex = 1;
            this.lowBtn.Text = "Stop";
            this.lowBtn.UseVisualStyleBackColor = false;
            this.lowBtn.Click += new System.EventHandler(this.lowBtn_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 89);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 349);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.circularGauge1.Location = new System.Drawing.Point(815, 181);
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.ResetValue = 0D;
            this.circularGauge1.ScaleFactor = 1D;
            this.circularGauge1.Size = new System.Drawing.Size(186, 188);
            this.circularGauge1.TabIndex = 3;
            this.circularGauge1.Title = "";
            this.circularGauge1.Unit = "mm";
            this.circularGauge1.UserDefinedColors.Base = themeColors1;
            this.circularGauge1.UserDefinedColors.Error = themeColors2;
            this.circularGauge1.UserDefinedColors.Warning = themeColors3;
            this.circularGauge1.Value = 0D;
            // 
            // linearGauge1
            // 
            this.linearGauge1.BottomBarHeight = 5;
            this.linearGauge1.Location = new System.Drawing.Point(801, 389);
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.ResetValue = 0D;
            this.linearGauge1.ScaleFactor = 1D;
            this.linearGauge1.SegmentGap = 1;
            this.linearGauge1.Size = new System.Drawing.Size(220, 49);
            this.linearGauge1.TabIndex = 4;
            this.linearGauge1.Title = "";
            this.linearGauge1.Unit = "mm";
            this.linearGauge1.Value = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 30F);
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "RealTime Graph";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linearGauge1);
            this.Controls.Add(this.circularGauge1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lowBtn);
            this.Controls.Add(this.highBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button highBtn;
        private System.Windows.Forms.Button lowBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private CodeArtEng.Gauge.CircularGauge circularGauge1;
        private CodeArtEng.Gauge.LinearGauge linearGauge1;
        private System.Windows.Forms.Label label1;
    }
}

