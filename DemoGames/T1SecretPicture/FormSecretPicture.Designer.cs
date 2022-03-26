namespace SecretPicture
{
    partial class FormSecretPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecretPicture));
            this.ButtonShow1 = new System.Windows.Forms.Button();
            this.ButtonShow2 = new System.Windows.Forms.Button();
            this.ButtonShow3 = new System.Windows.Forms.Button();
            this.ButtonShow4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonShow1
            // 
            this.ButtonShow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShow1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonShow1.Location = new System.Drawing.Point(12, 25);
            this.ButtonShow1.Name = "ButtonShow1";
            this.ButtonShow1.Size = new System.Drawing.Size(163, 53);
            this.ButtonShow1.TabIndex = 0;
            this.ButtonShow1.Text = "Осень";
            this.ButtonShow1.UseVisualStyleBackColor = true;
            this.ButtonShow1.Click += new System.EventHandler(this.ButtonShow1_Click);
            // 
            // ButtonShow2
            // 
            this.ButtonShow2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonShow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShow2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonShow2.Location = new System.Drawing.Point(209, 25);
            this.ButtonShow2.Name = "ButtonShow2";
            this.ButtonShow2.Size = new System.Drawing.Size(163, 53);
            this.ButtonShow2.TabIndex = 0;
            this.ButtonShow2.Text = "Берег ";
            this.ButtonShow2.UseVisualStyleBackColor = true;
            this.ButtonShow2.Click += new System.EventHandler(this.ButtonShow2_Click);
            // 
            // ButtonShow3
            // 
            this.ButtonShow3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonShow3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShow3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonShow3.Location = new System.Drawing.Point(12, 197);
            this.ButtonShow3.Name = "ButtonShow3";
            this.ButtonShow3.Size = new System.Drawing.Size(163, 53);
            this.ButtonShow3.TabIndex = 0;
            this.ButtonShow3.Text = "Рельсы";
            this.ButtonShow3.UseVisualStyleBackColor = true;
            this.ButtonShow3.Click += new System.EventHandler(this.ButtonShow3_Click);
            // 
            // ButtonShow4
            // 
            this.ButtonShow4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonShow4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShow4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonShow4.Location = new System.Drawing.Point(209, 197);
            this.ButtonShow4.Name = "ButtonShow4";
            this.ButtonShow4.Size = new System.Drawing.Size(163, 53);
            this.ButtonShow4.TabIndex = 0;
            this.ButtonShow4.Text = "Дорога";
            this.ButtonShow4.UseVisualStyleBackColor = true;
            this.ButtonShow4.Click += new System.EventHandler(this.ButtonShow4_Click);
            // 
            // FormSecretPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.ButtonShow4);
            this.Controls.Add(this.ButtonShow2);
            this.Controls.Add(this.ButtonShow3);
            this.Controls.Add(this.ButtonShow1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormSecretPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Картинка с секретом";
            this.Load += new System.EventHandler(this.FormSecretPicture_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormSecretPicture_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormSecretPicture_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonShow1;
        private System.Windows.Forms.Button ButtonShow2;
        private System.Windows.Forms.Button ButtonShow3;
        private System.Windows.Forms.Button ButtonShow4;
    }
}

