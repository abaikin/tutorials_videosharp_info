namespace Labirint2D
{
    partial class FormLevel3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLevel3));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_door = new System.Windows.Forms.Label();
            this.label_key = new System.Windows.Forms.Label();
            this.label_finish = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer_enemy_animation = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Green;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(632, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 449);
            this.label7.TabIndex = 14;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(311, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(447, 28);
            this.label6.TabIndex = 13;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Green;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(154, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 449);
            this.label5.TabIndex = 12;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(758, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 762);
            this.label4.TabIndex = 11;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-1, 783);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(785, 21);
            this.label3.TabIndex = 9;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-1, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 762);
            this.label2.TabIndex = 10;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 21);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // label_door
            // 
            this.label_door.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label_door.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_door.Location = new System.Drawing.Point(650, 334);
            this.label_door.Name = "label_door";
            this.label_door.Size = new System.Drawing.Size(108, 41);
            this.label_door.TabIndex = 15;
            this.label_door.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_door.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // label_key
            // 
            this.label_key.BackColor = System.Drawing.Color.Transparent;
            this.label_key.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_key.Image = ((System.Drawing.Image)(resources.GetObject("label_key.Image")));
            this.label_key.Location = new System.Drawing.Point(672, 38);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(57, 55);
            this.label_key.TabIndex = 16;
            this.label_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_key.MouseEnter += new System.EventHandler(this.label_key_MouseEnter);
            // 
            // label_finish
            // 
            this.label_finish.BackColor = System.Drawing.Color.Transparent;
            this.label_finish.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_finish.Image = global::Labirint2D.Properties.Resources.hole_finish;
            this.label_finish.Location = new System.Drawing.Point(652, 624);
            this.label_finish.Name = "label_finish";
            this.label_finish.Size = new System.Drawing.Size(106, 102);
            this.label_finish.TabIndex = 7;
            this.label_finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_finish.MouseEnter += new System.EventHandler(this.label_finish_MouseEnter);
            // 
            // label_start
            // 
            this.label_start.BackColor = System.Drawing.Color.Transparent;
            this.label_start.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start.Image = global::Labirint2D.Properties.Resources.hole_start;
            this.label_start.Location = new System.Drawing.Point(21, 21);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(106, 102);
            this.label_start.TabIndex = 6;
            this.label_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Green;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(-1, 762);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(784, 21);
            this.label8.TabIndex = 19;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            // 
            // timer_enemy_animation
            // 
            this.timer_enemy_animation.Enabled = true;
            this.timer_enemy_animation.Interval = 300;
            this.timer_enemy_animation.Tick += new System.EventHandler(this.timer_enemy_animation_Tick);
            // 
            // FormLevel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Labirint2D.Properties.Resources.rock_background_level_3;
            this.ClientSize = new System.Drawing.Size(782, 780);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_finish);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label_door);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLevel3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLevel2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_finish;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_door;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer_enemy_animation;


    }
}