namespace FastClick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_counter = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.button_about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_counter
            // 
            this.label_counter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_counter.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_counter.Location = new System.Drawing.Point(12, 68);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(193, 141);
            this.label_counter.TabIndex = 0;
            this.label_counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_counter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_counter_MouseDown);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(12, 4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(193, 43);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Начать игру";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_result
            // 
            this.label_result.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(12, 229);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(193, 23);
            this.label_result.TabIndex = 2;
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_about
            // 
            this.button_about.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_about.Location = new System.Drawing.Point(12, 255);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(193, 48);
            this.button_about.TabIndex = 3;
            this.button_about.Text = "О программе";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 315);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_counter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Быстрощёлк";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_counter;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_about;
    }
}

