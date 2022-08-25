namespace InventoryMgmtSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CircleLoad = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "StockX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory Management Software";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 149);
            this.label3.MaximumSize = new System.Drawing.Size(300, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 119);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryMgmtSoftware.Properties.Resources.InventoryManagement;
            this.pictureBox1.Location = new System.Drawing.Point(488, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CircleLoad
            // 
            this.CircleLoad.animated = false;
            this.CircleLoad.animationIterval = 5;
            this.CircleLoad.animationSpeed = 900;
            this.CircleLoad.BackColor = System.Drawing.Color.MidnightBlue;
            this.CircleLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleLoad.BackgroundImage")));
            this.CircleLoad.Font = new System.Drawing.Font("JetBrains Mono", 12F);
            this.CircleLoad.ForeColor = System.Drawing.Color.White;
            this.CircleLoad.LabelVisible = true;
            this.CircleLoad.LineProgressThickness = 8;
            this.CircleLoad.LineThickness = 5;
            this.CircleLoad.Location = new System.Drawing.Point(104, 335);
            this.CircleLoad.Margin = new System.Windows.Forms.Padding(10);
            this.CircleLoad.MaxValue = 100;
            this.CircleLoad.Name = "CircleLoad";
            this.CircleLoad.ProgressBackColor = System.Drawing.Color.MidnightBlue;
            this.CircleLoad.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.CircleLoad.Size = new System.Drawing.Size(100, 100);
            this.CircleLoad.TabIndex = 4;
            this.CircleLoad.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(456, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Copyright 2022, Mantey Solutions, All Rights Reserved";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CircleLoad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CircleLoad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}

