namespace SMC_SLOT
{
    partial class Prize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prize));
            this.listView1 = new System.Windows.Forms.ListView();
            this.prizeNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fukidashiPanel2 = new System.Windows.Forms.Panel();
            this.backLabel = new System.Windows.Forms.Label();
            this.fukidashiBox1 = new System.Windows.Forms.PictureBox();
            this.fukidashiPanel1 = new System.Windows.Forms.Panel();
            this.noLabel = new System.Windows.Forms.Label();
            this.yesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.fukidashiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fukidashiBox1)).BeginInit();
            this.fukidashiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(273, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1350, 750);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // prizeNameLabel
            // 
            this.prizeNameLabel.AutoSize = true;
            this.prizeNameLabel.Font = new System.Drawing.Font("BIZ UDPゴシック", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeNameLabel.ForeColor = System.Drawing.Color.White;
            this.prizeNameLabel.Location = new System.Drawing.Point(642, 887);
            this.prizeNameLabel.Name = "prizeNameLabel";
            this.prizeNameLabel.Size = new System.Drawing.Size(0, 43);
            this.prizeNameLabel.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMC_SLOT.Properties.Resources.exchange;
            this.pictureBox1.Location = new System.Drawing.Point(273, 822);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // fukidashiPanel2
            // 
            this.fukidashiPanel2.BackgroundImage = global::SMC_SLOT.Properties.Resources.back;
            this.fukidashiPanel2.Controls.Add(this.backLabel);
            this.fukidashiPanel2.Location = new System.Drawing.Point(1424, 952);
            this.fukidashiPanel2.Name = "fukidashiPanel2";
            this.fukidashiPanel2.Size = new System.Drawing.Size(200, 70);
            this.fukidashiPanel2.TabIndex = 35;
            this.fukidashiPanel2.Visible = false;
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.BackColor = System.Drawing.Color.Transparent;
            this.backLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backLabel.ForeColor = System.Drawing.Color.Transparent;
            this.backLabel.Location = new System.Drawing.Point(44, 12);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(116, 48);
            this.backLabel.TabIndex = 29;
            this.backLabel.Text = "　　　";
            this.backLabel.Visible = false;
            this.backLabel.Click += new System.EventHandler(this.Back_Click);
            // 
            // fukidashiBox1
            // 
            this.fukidashiBox1.BackgroundImage = global::SMC_SLOT.Properties.Resources.fukidashi_initial;
            this.fukidashiBox1.Location = new System.Drawing.Point(589, 822);
            this.fukidashiBox1.Name = "fukidashiBox1";
            this.fukidashiBox1.Size = new System.Drawing.Size(774, 200);
            this.fukidashiBox1.TabIndex = 36;
            this.fukidashiBox1.TabStop = false;
            // 
            // fukidashiPanel1
            // 
            this.fukidashiPanel1.BackgroundImage = global::SMC_SLOT.Properties.Resources.yes_or_no;
            this.fukidashiPanel1.Controls.Add(this.noLabel);
            this.fukidashiPanel1.Controls.Add(this.yesLabel);
            this.fukidashiPanel1.Location = new System.Drawing.Point(1424, 822);
            this.fukidashiPanel1.Name = "fukidashiPanel1";
            this.fukidashiPanel1.Size = new System.Drawing.Size(200, 120);
            this.fukidashiPanel1.TabIndex = 34;
            this.fukidashiPanel1.Visible = false;
            // 
            // noLabel
            // 
            this.noLabel.AutoSize = true;
            this.noLabel.BackColor = System.Drawing.Color.Transparent;
            this.noLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.noLabel.ForeColor = System.Drawing.Color.Transparent;
            this.noLabel.Location = new System.Drawing.Point(44, 60);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(116, 48);
            this.noLabel.TabIndex = 28;
            this.noLabel.Text = "　　　";
            this.noLabel.Visible = false;
            this.noLabel.Click += new System.EventHandler(this.No_Click);
            // 
            // yesLabel
            // 
            this.yesLabel.AutoSize = true;
            this.yesLabel.BackColor = System.Drawing.Color.Transparent;
            this.yesLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yesLabel.ForeColor = System.Drawing.Color.Transparent;
            this.yesLabel.Location = new System.Drawing.Point(33, 12);
            this.yesLabel.Name = "yesLabel";
            this.yesLabel.Size = new System.Drawing.Size(116, 48);
            this.yesLabel.TabIndex = 27;
            this.yesLabel.Text = "　　　";
            this.yesLabel.Visible = false;
            this.yesLabel.Click += new System.EventHandler(this.Yes_Click);
            // 
            // Prize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.prizeNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.fukidashiPanel2);
            this.Controls.Add(this.fukidashiPanel1);
            this.Controls.Add(this.fukidashiBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prize";
            this.Text = "Prize";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.fukidashiPanel2.ResumeLayout(false);
            this.fukidashiPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fukidashiBox1)).EndInit();
            this.fukidashiPanel1.ResumeLayout(false);
            this.fukidashiPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label yesLabel;
        private System.Windows.Forms.Label noLabel;
        private System.Windows.Forms.Label backLabel;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel fukidashiPanel1;
        private System.Windows.Forms.Panel fukidashiPanel2;
        private System.Windows.Forms.PictureBox fukidashiBox1;
        private System.Windows.Forms.Label prizeNameLabel;
    }
}