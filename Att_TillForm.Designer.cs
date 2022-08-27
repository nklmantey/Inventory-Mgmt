namespace InventoryMgmtSoftware
{
    partial class Att_TillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Att_TillForm));
            this.Close = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Open = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.Close.Location = new System.Drawing.Point(456, 242);
            this.Close.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(150, 66);
            this.Close.TabIndex = 11;
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close.Click += new System.EventHandler(this.Close_Click);
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
            this.Open.Location = new System.Drawing.Point(295, 242);
            this.Open.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(150, 66);
            this.Open.TabIndex = 10;
            this.Open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Black;
            this.Result.Location = new System.Drawing.Point(295, 130);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(311, 30);
            this.Result.TabIndex = 12;
            this.Result.Text = " 00:00:00";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Att_TillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Att_TillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "00:00:00";
            this.Load += new System.EventHandler(this.Att_TillForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 Close;
        private Bunifu.Framework.UI.BunifuThinButton2 Open;
        private System.Windows.Forms.TextBox Result;
    }
}