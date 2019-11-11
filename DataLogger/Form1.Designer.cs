namespace DataLogger
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Connect = new System.Windows.Forms.ToolStripButton();
            this.DropDown_TimeToSaveData = new System.Windows.Forms.ToolStripDropDownButton();
            this.TwentySecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiveMinutesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TwentyMinutesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.HourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrtherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_chart1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.channel1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channel2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channel3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channel4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeAxisX = new System.Windows.Forms.ToolStripDropDownButton();
            this.chếĐộCuộnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chếĐộCốĐịnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_connect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Channel_display = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timenow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Data_Rate = new System.Windows.Forms.ToolStripStatusLabel();
            this.Time_now = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 44);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series1.Legend = "Legend1";
            series1.Name = "Kênh 1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Kênh 2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.Name = "Kênh 3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.Name = "Kênh 4";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(788, 371);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart1_MouseWheel);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connect,
            this.DropDown_TimeToSaveData,
            this.toolStripMenuItem_chart1,
            this.ModeAxisX});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(347, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Connect
            // 
            this.Connect.Image = ((System.Drawing.Image)(resources.GetObject("Connect.Image")));
            this.Connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(64, 22);
            this.Connect.Text = "Kết nối";
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // DropDown_TimeToSaveData
            // 
            this.DropDown_TimeToSaveData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TwentySecondsToolStripMenuItem,
            this.MinutesToolStripMenuItem,
            this.FiveMinutesToolStripMenuItem1,
            this.TwentyMinutesToolStripMenuItem2,
            this.HourToolStripMenuItem,
            this.OrtherToolStripMenuItem});
            this.DropDown_TimeToSaveData.Image = global::DataLogger.Properties.Resources.images;
            this.DropDown_TimeToSaveData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDown_TimeToSaveData.Name = "DropDown_TimeToSaveData";
            this.DropDown_TimeToSaveData.Size = new System.Drawing.Size(95, 22);
            this.DropDown_TimeToSaveData.Text = "Lưu dữ liệu";
            this.DropDown_TimeToSaveData.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.DropDown_TimeToSaveData_DropDownItemClicked);
            // 
            // TwentySecondsToolStripMenuItem
            // 
            this.TwentySecondsToolStripMenuItem.Name = "TwentySecondsToolStripMenuItem";
            this.TwentySecondsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.TwentySecondsToolStripMenuItem.Text = "30 giây";
            this.TwentySecondsToolStripMenuItem.Click += new System.EventHandler(this.TwentySecondsToolStripMenuItem_Click);
            // 
            // MinutesToolStripMenuItem
            // 
            this.MinutesToolStripMenuItem.Name = "MinutesToolStripMenuItem";
            this.MinutesToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.MinutesToolStripMenuItem.Text = "1 phút";
            this.MinutesToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.MinutesToolStripMenuItem_CheckStateChanged);
            // 
            // FiveMinutesToolStripMenuItem1
            // 
            this.FiveMinutesToolStripMenuItem1.Name = "FiveMinutesToolStripMenuItem1";
            this.FiveMinutesToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.FiveMinutesToolStripMenuItem1.Text = "5 phút";
            this.FiveMinutesToolStripMenuItem1.CheckStateChanged += new System.EventHandler(this.FiveMinutesToolStripMenuItem1_CheckStateChanged);
            // 
            // TwentyMinutesToolStripMenuItem2
            // 
            this.TwentyMinutesToolStripMenuItem2.Name = "TwentyMinutesToolStripMenuItem2";
            this.TwentyMinutesToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.TwentyMinutesToolStripMenuItem2.Text = "30 phút";
            this.TwentyMinutesToolStripMenuItem2.CheckStateChanged += new System.EventHandler(this.TwentyMinutesToolStripMenuItem2_CheckStateChanged);
            // 
            // HourToolStripMenuItem
            // 
            this.HourToolStripMenuItem.Name = "HourToolStripMenuItem";
            this.HourToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.HourToolStripMenuItem.Text = "1 giờ";
            this.HourToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.HourToolStripMenuItem_CheckStateChanged);
            // 
            // OrtherToolStripMenuItem
            // 
            this.OrtherToolStripMenuItem.Name = "OrtherToolStripMenuItem";
            this.OrtherToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.OrtherToolStripMenuItem.Text = "Khác";
            this.OrtherToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.OrtherToolStripMenuItem_CheckStateChanged);
            // 
            // toolStripMenuItem_chart1
            // 
            this.toolStripMenuItem_chart1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channel1ToolStripMenuItem,
            this.channel2ToolStripMenuItem,
            this.channel3ToolStripMenuItem,
            this.channel4ToolStripMenuItem,
            this.allToolStripMenuItem});
            this.toolStripMenuItem_chart1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_chart1.Image")));
            this.toolStripMenuItem_chart1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItem_chart1.Name = "toolStripMenuItem_chart1";
            this.toolStripMenuItem_chart1.Size = new System.Drawing.Size(68, 22);
            this.toolStripMenuItem_chart1.Text = "Đồ thị";
            // 
            // channel1ToolStripMenuItem
            // 
            this.channel1ToolStripMenuItem.CheckOnClick = true;
            this.channel1ToolStripMenuItem.Name = "channel1ToolStripMenuItem";
            this.channel1ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.channel1ToolStripMenuItem.Text = "Kênh 1";
            this.channel1ToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.channel1ToolStripMenuItem_CheckStateChanged);
            // 
            // channel2ToolStripMenuItem
            // 
            this.channel2ToolStripMenuItem.CheckOnClick = true;
            this.channel2ToolStripMenuItem.Name = "channel2ToolStripMenuItem";
            this.channel2ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.channel2ToolStripMenuItem.Text = "Kênh 2";
            this.channel2ToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.channel2ToolStripMenuItem_CheckStateChanged);
            // 
            // channel3ToolStripMenuItem
            // 
            this.channel3ToolStripMenuItem.CheckOnClick = true;
            this.channel3ToolStripMenuItem.Name = "channel3ToolStripMenuItem";
            this.channel3ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.channel3ToolStripMenuItem.Text = "Kênh 3";
            this.channel3ToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.channel3ToolStripMenuItem_CheckStateChanged);
            // 
            // channel4ToolStripMenuItem
            // 
            this.channel4ToolStripMenuItem.CheckOnClick = true;
            this.channel4ToolStripMenuItem.Name = "channel4ToolStripMenuItem";
            this.channel4ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.channel4ToolStripMenuItem.Text = "Kênh 4";
            this.channel4ToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.channel4ToolStripMenuItem_CheckStateChanged);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.CheckOnClick = true;
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.allToolStripMenuItem.Text = "Tất cả";
            this.allToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.allToolStripMenuItem_CheckStateChanged);
            // 
            // ModeAxisX
            // 
            this.ModeAxisX.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chếĐộCuộnToolStripMenuItem,
            this.chếĐộCốĐịnhToolStripMenuItem});
            this.ModeAxisX.Image = ((System.Drawing.Image)(resources.GetObject("ModeAxisX.Image")));
            this.ModeAxisX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModeAxisX.Name = "ModeAxisX";
            this.ModeAxisX.Size = new System.Drawing.Size(108, 22);
            this.ModeAxisX.Text = "Chế độ đồ thị";
            this.ModeAxisX.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ModeAxisX_DropDownItemClicked);
            // 
            // chếĐộCuộnToolStripMenuItem
            // 
            this.chếĐộCuộnToolStripMenuItem.Name = "chếĐộCuộnToolStripMenuItem";
            this.chếĐộCuộnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chếĐộCuộnToolStripMenuItem.Text = "Chế độ cuộn";
            this.chếĐộCuộnToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.chếĐộCuộnToolStripMenuItem_CheckStateChanged);
            // 
            // chếĐộCốĐịnhToolStripMenuItem
            // 
            this.chếĐộCốĐịnhToolStripMenuItem.Name = "chếĐộCốĐịnhToolStripMenuItem";
            this.chếĐộCốĐịnhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chếĐộCốĐịnhToolStripMenuItem.Text = "Chế độ cố định";
            this.chếĐộCốĐịnhToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.chếĐộCốĐịnhToolStripMenuItem_CheckStateChanged);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Status_connect,
            this.toolStripStatusLabel3,
            this.Channel_display,
            this.Timenow,
            this.toolStripStatusLabel2,
            this.Data_Rate,
            this.Time_now});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "Trạng thái:";
            // 
            // Status_connect
            // 
            this.Status_connect.Name = "Status_connect";
            this.Status_connect.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel3.Text = "Kênh hiển thị:";
            // 
            // Channel_display
            // 
            this.Channel_display.Name = "Channel_display";
            this.Channel_display.Size = new System.Drawing.Size(0, 17);
            // 
            // Timenow
            // 
            this.Timenow.Name = "Timenow";
            this.Timenow.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel2.Text = "Tốc độ lấy mẫu:";
            // 
            // Data_Rate
            // 
            this.Data_Rate.Name = "Data_Rate";
            this.Data_Rate.Size = new System.Drawing.Size(0, 17);
            // 
            // Time_now
            // 
            this.Time_now.Name = "Time_now";
            this.Time_now.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Logger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripButton Connect;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Status_connect;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel Time_now;
        private System.Windows.Forms.ToolStripStatusLabel Timenow;
        private System.Windows.Forms.ToolStripStatusLabel Channel_display;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel Data_Rate;
        private System.Windows.Forms.ToolStripDropDownButton toolStripMenuItem_chart1;
        private System.Windows.Forms.ToolStripMenuItem channel1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channel2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channel3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channel4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton DropDown_TimeToSaveData;
        private System.Windows.Forms.ToolStripMenuItem TwentySecondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FiveMinutesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TwentyMinutesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem HourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrtherToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ModeAxisX;
        private System.Windows.Forms.ToolStripMenuItem chếĐộCuộnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chếĐộCốĐịnhToolStripMenuItem;
    }
}

