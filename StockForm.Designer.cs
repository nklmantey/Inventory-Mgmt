namespace InventoryMgmtSoftware
{
    partial class StockForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StockData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ProdID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ReorderLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.StockData);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.ProdID);
            this.panel1.Controls.Add(this.ReorderLevel);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(202, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 702);
            this.panel1.TabIndex = 1;
            // 
            // StockData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.StockData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StockData.ColumnHeadersHeight = 30;
            this.StockData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockData.DefaultCellStyle = dataGridViewCellStyle3;
            this.StockData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StockData.Location = new System.Drawing.Point(542, 70);
            this.StockData.Name = "StockData";
            this.StockData.RowHeadersVisible = false;
            this.StockData.RowHeadersWidth = 51;
            this.StockData.RowTemplate.Height = 30;
            this.StockData.Size = new System.Drawing.Size(691, 629);
            this.StockData.TabIndex = 23;
            this.StockData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StockData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StockData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StockData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StockData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StockData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StockData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StockData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StockData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StockData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StockData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StockData.ThemeStyle.HeaderStyle.Height = 30;
            this.StockData.ThemeStyle.ReadOnly = false;
            this.StockData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StockData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StockData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StockData.ThemeStyle.RowsStyle.Height = 30;
            this.StockData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StockData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StockData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockData_CellContentClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button10.Location = new System.Drawing.Point(542, 33);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 30);
            this.button10.TabIndex = 22;
            this.button10.Text = "Refresh";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button7.Location = new System.Drawing.Point(98, 348);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 40);
            this.button7.TabIndex = 17;
            this.button7.Text = "Set";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // ProdID
            // 
            this.ProdID.BackColor = System.Drawing.Color.MidnightBlue;
            this.ProdID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdID.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdID.ForeColor = System.Drawing.Color.White;
            this.ProdID.HintForeColor = System.Drawing.Color.White;
            this.ProdID.HintText = "";
            this.ProdID.isPassword = false;
            this.ProdID.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.ProdID.LineIdleColor = System.Drawing.Color.White;
            this.ProdID.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.ProdID.LineThickness = 3;
            this.ProdID.Location = new System.Drawing.Point(37, 271);
            this.ProdID.Margin = new System.Windows.Forms.Padding(4);
            this.ProdID.Name = "ProdID";
            this.ProdID.Size = new System.Drawing.Size(305, 46);
            this.ProdID.TabIndex = 9;
            this.ProdID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.AutoSize = true;
            this.ReorderLevel.Font = new System.Drawing.Font("JetBrains Mono", 14F, System.Drawing.FontStyle.Bold);
            this.ReorderLevel.ForeColor = System.Drawing.Color.White;
            this.ReorderLevel.Location = new System.Drawing.Point(31, 236);
            this.ReorderLevel.Name = "ReorderLevel";
            this.ReorderLevel.Size = new System.Drawing.Size(196, 31);
            this.ReorderLevel.TabIndex = 8;
            this.ReorderLevel.Text = "Reorder Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 66);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stock ";
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
            this.button6.TabIndex = 5;
            this.button6.Text = "x";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Report
            // 
            this.Report.FlatAppearance.BorderSize = 0;
            this.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.Location = new System.Drawing.Point(68, 483);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(130, 40);
            this.Report.TabIndex = 24;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Stock
            // 
            this.Stock.BackColor = System.Drawing.Color.MidnightBlue;
            this.Stock.FlatAppearance.BorderSize = 0;
            this.Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stock.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.ForeColor = System.Drawing.Color.White;
            this.Stock.Location = new System.Drawing.Point(66, 370);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(130, 40);
            this.Stock.TabIndex = 18;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = false;
            // 
            // Users
            // 
            this.Users.FlatAppearance.BorderSize = 0;
            this.Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.Location = new System.Drawing.Point(66, 596);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(130, 40);
            this.Users.TabIndex = 17;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // Categories
            // 
            this.Categories.FlatAppearance.BorderSize = 0;
            this.Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categories.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.Location = new System.Drawing.Point(66, 257);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(130, 40);
            this.Categories.TabIndex = 16;
            this.Categories.Text = "Categories";
            this.Categories.UseVisualStyleBackColor = true;
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.White;
            this.Products.FlatAppearance.BorderSize = 0;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.Color.Black;
            this.Products.Location = new System.Drawing.Point(66, 144);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(130, 40);
            this.Products.TabIndex = 15;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = false;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::InventoryMgmtSoftware.Properties.Resources.report;
            this.pictureBox7.Location = new System.Drawing.Point(12, 473);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::InventoryMgmtSoftware.Properties.Resources.user1;
            this.pictureBox5.Location = new System.Drawing.Point(12, 586);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::InventoryMgmtSoftware.Properties.Resources.in_stock;
            this.pictureBox4.Location = new System.Drawing.Point(12, 360);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InventoryMgmtSoftware.Properties.Resources.apps;
            this.pictureBox3.Location = new System.Drawing.Point(12, 247);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventoryMgmtSoftware.Properties.Resources.products;
            this.pictureBox2.Location = new System.Drawing.Point(12, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::InventoryMgmtSoftware.Properties.Resources.packages;
            this.pictureBox6.Location = new System.Drawing.Point(37, 72);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1450, 730);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockForm";
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView StockData;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdID;
        private System.Windows.Forms.Label ReorderLevel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button Categories;
        private System.Windows.Forms.Button Products;
    }
}