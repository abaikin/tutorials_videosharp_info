namespace T4AutoClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.track_count = new System.Windows.Forms.TrackBar();
            this.track_time = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_info_count = new System.Windows.Forms.Label();
            this.label_info_time = new System.Windows.Forms.Label();
            this.label_show_count = new System.Windows.Forms.Label();
            this.label_show_time = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.track_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_time)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // track_count
            // 
            this.track_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_count.LargeChange = 10;
            this.track_count.Location = new System.Drawing.Point(177, 3);
            this.track_count.Maximum = 100;
            this.track_count.Minimum = 1;
            this.track_count.Name = "track_count";
            this.track_count.Size = new System.Drawing.Size(168, 34);
            this.track_count.TabIndex = 0;
            this.track_count.TickFrequency = 10;
            this.track_count.Value = 1;
            this.track_count.Scroll += new System.EventHandler(this.track_count_Scroll);
            // 
            // track_time
            // 
            this.track_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_time.LargeChange = 10;
            this.track_time.Location = new System.Drawing.Point(177, 43);
            this.track_time.Maximum = 1000;
            this.track_time.Minimum = 1;
            this.track_time.Name = "track_time";
            this.track_time.Size = new System.Drawing.Size(168, 34);
            this.track_time.TabIndex = 1;
            this.track_time.TickFrequency = 100;
            this.track_time.Value = 1;
            this.track_time.Scroll += new System.EventHandler(this.track_time_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.track_count, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.track_time, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_info_count, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_info_time, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_show_count, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_show_time, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_start, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.trackBar1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 122);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label_info_count
            // 
            this.label_info_count.AutoSize = true;
            this.label_info_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info_count.Location = new System.Drawing.Point(3, 0);
            this.label_info_count.Name = "label_info_count";
            this.label_info_count.Size = new System.Drawing.Size(168, 40);
            this.label_info_count.TabIndex = 2;
            this.label_info_count.Text = "Количество кликов";
            this.label_info_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_info_time
            // 
            this.label_info_time.AutoSize = true;
            this.label_info_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info_time.Location = new System.Drawing.Point(3, 40);
            this.label_info_time.Name = "label_info_time";
            this.label_info_time.Size = new System.Drawing.Size(168, 40);
            this.label_info_time.TabIndex = 3;
            this.label_info_time.Text = "Задержка между кликами";
            this.label_info_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_show_count
            // 
            this.label_show_count.AutoSize = true;
            this.label_show_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_show_count.Location = new System.Drawing.Point(351, 0);
            this.label_show_count.Name = "label_show_count";
            this.label_show_count.Size = new System.Drawing.Size(170, 40);
            this.label_show_count.TabIndex = 4;
            this.label_show_count.Text = "-";
            this.label_show_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_show_time
            // 
            this.label_show_time.AutoSize = true;
            this.label_show_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_show_time.Location = new System.Drawing.Point(351, 40);
            this.label_show_time.Name = "label_show_time";
            this.label_show_time.Size = new System.Drawing.Size(170, 40);
            this.label_show_time.TabIndex = 5;
            this.label_show_time.Text = "-";
            this.label_show_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_start
            // 
            this.button_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_start.Location = new System.Drawing.Point(177, 83);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(168, 36);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "Начать кликать";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 83);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(8, 36);
            this.trackBar1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(351, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerStart
            // 
            this.timerStart.Interval = 1;
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 122);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автокликер";
            ((System.ComponentModel.ISupportInitialize)(this.track_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_time)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TrackBar track_count;
        private TrackBar track_time;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label_info_count;
        private Label label_info_time;
        private Label label_show_count;
        private Label label_show_time;
        private Button button_start;
        private System.Windows.Forms.Timer timer;
        private TrackBar trackBar1;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timerStart;
    }
}