﻿namespace InventoryMgmtSoftware
{
    partial class AttendantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendantForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Till = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Open = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Close = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.Open);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.Result);
            this.panel1.Location = new System.Drawing.Point(216, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 702);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1193, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 20;
            this.button6.Text = "x";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Black;
            this.Result.Location = new System.Drawing.Point(373, 251);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(311, 30);
            this.Result.TabIndex = 19;
            this.Result.Text = " 00:00:00";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Till
            // 
            this.Till.BackColor = System.Drawing.Color.MidnightBlue;
            this.Till.FlatAppearance.BorderSize = 0;
            this.Till.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Till.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Till.ForeColor = System.Drawing.Color.White;
            this.Till.Location = new System.Drawing.Point(66, 103);
            this.Till.Name = "Till";
            this.Till.Size = new System.Drawing.Size(130, 40);
            this.Till.TabIndex = 11;
            this.Till.Text = "Till";
            this.Till.UseVisualStyleBackColor = false;
            this.Till.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(68, 570);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(68, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(66, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 40);
            this.button4.TabIndex = 14;
            this.button4.Text = "Transactions";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::InventoryMgmtSoftware.Properties.Resources.report;
            this.pictureBox4.Location = new System.Drawing.Point(12, 561);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InventoryMgmtSoftware.Properties.Resources.money_transfer;
            this.pictureBox3.Location = new System.Drawing.Point(12, 251);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventoryMgmtSoftware.Properties.Resources.in_stock;
            this.pictureBox2.Location = new System.Drawing.Point(12, 406);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryMgmtSoftware.Properties.Resources.till;
            this.pictureBox1.Location = new System.Drawing.Point(12, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Open
            // 
            this.Open.ActiveBorderThickness = 1;
            this.Open.ActiveCornerRadius = 20;
            this.Open.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.Open.ActiveForecolor = System.Drawing.Color.White;
            this.Open.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.Open.BackColor = System.Drawing.Color.MidnightBlue;
            this.Open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Open.BackgroundImage")));
            this.Open.ButtonText = "Open Till";
            this.Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Open.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.ForeColor = System.Drawing.Color.White;
            this.Open.IdleBorderThickness = 1;
            this.Open.IdleCornerRadius = 20;
            this.Open.IdleFillColor = System.Drawing.Color.White;
            this.Open.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.Open.IdleLineColor = System.Drawing.Color.White;
            this.Open.Location = new System.Drawing.Point(373, 353);
            this.Open.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(150, 66);
            this.Open.TabIndex = 21;
            this.Open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Open.Click += new System.EventHandler(this.Open_Click_1);
            // 
            // Close
            // 
            this.Close.ActiveBorderThickness = 1;
            this.Close.ActiveCornerRadius = 20;
            this.Close.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.Close.ActiveForecolor = System.Drawing.Color.White;
            this.Close.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.Close.BackColor = System.Drawing.Color.MidnightBlue;
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.ButtonText = "Close Till";
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.IdleBorderThickness = 1;
            this.Close.IdleCornerRadius = 20;
            this.Close.IdleFillColor = System.Drawing.Color.White;
            this.Close.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.Close.IdleLineColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(534, 353);
            this.Close.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(150, 66);
            this.Close.TabIndex = 22;
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // AttendantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1450, 730);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Till);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Till;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox Result;
        private Bunifu.Framework.UI.BunifuThinButton2 Open;
        private Bunifu.Framework.UI.BunifuThinButton2 Close;
    }
}