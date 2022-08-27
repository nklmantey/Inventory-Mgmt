namespace InventoryMgmtSoftware
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.Prod = new System.Windows.Forms.ComboBox();
            this.ProdData = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ProdCategory = new System.Windows.Forms.ComboBox();
            this.ProdQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Report = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.Prod);
            this.panel1.Controls.Add(this.ProdData);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.ProdCategory);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProdID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(202, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 702);
            this.panel1.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button10.Location = new System.Drawing.Point(853, 34);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 30);
            this.button10.TabIndex = 22;
            this.button10.Text = "Refresh";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // Prod
            // 
            this.Prod.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Prod.FormattingEnabled = true;
            this.Prod.Items.AddRange(new object[] {
            "Meat",
            "Food & Beverage",
            "Health & Beauty",
            "Electronics",
            "Furniture"});
            this.Prod.Location = new System.Drawing.Point(542, 34);
            this.Prod.Name = "Prod";
            this.Prod.Size = new System.Drawing.Size(305, 30);
            this.Prod.TabIndex = 21;
            this.Prod.Text = "Filter by category";
            // 
            // ProdData
            // 
            this.ProdData.AllowUserToAddRows = false;
            this.ProdData.AllowUserToDeleteRows = false;
            this.ProdData.AllowUserToResizeColumns = false;
            this.ProdData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdData.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProdData.Location = new System.Drawing.Point(542, 69);
            this.ProdData.Name = "ProdData";
            this.ProdData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProdData.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ProdData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProdData.RowTemplate.Height = 24;
            this.ProdData.RowTemplate.ReadOnly = true;
            this.ProdData.Size = new System.Drawing.Size(691, 630);
            this.ProdData.TabIndex = 20;
            this.ProdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdData_CellContentClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button9.Location = new System.Drawing.Point(300, 582);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 40);
            this.button9.TabIndex = 19;
            this.button9.Text = "Update";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button8.Location = new System.Drawing.Point(436, 582);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 40);
            this.button8.TabIndex = 18;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button7.Location = new System.Drawing.Point(164, 582);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 40);
            this.button7.TabIndex = 17;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ProdCategory
            // 
            this.ProdCategory.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdCategory.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProdCategory.FormattingEnabled = true;
            this.ProdCategory.Items.AddRange(new object[] {
            "Meat",
            "Food & Beverage",
            "Health & Beauty",
            "Electronics",
            "Furniture"});
            this.ProdCategory.Location = new System.Drawing.Point(187, 510);
            this.ProdCategory.Name = "ProdCategory";
            this.ProdCategory.Size = new System.Drawing.Size(305, 30);
            this.ProdCategory.TabIndex = 16;
            this.ProdCategory.Text = "Select product category";
            // 
            // ProdQty
            // 
            this.ProdQty.BackColor = System.Drawing.Color.MidnightBlue;
            this.ProdQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdQty.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQty.ForeColor = System.Drawing.Color.White;
            this.ProdQty.HintForeColor = System.Drawing.Color.White;
            this.ProdQty.HintText = "";
            this.ProdQty.isPassword = false;
            this.ProdQty.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.ProdQty.LineIdleColor = System.Drawing.Color.White;
            this.ProdQty.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.ProdQty.LineThickness = 3;
            this.ProdQty.Location = new System.Drawing.Point(187, 410);
            this.ProdQty.Margin = new System.Windows.Forms.Padding(4);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(305, 46);
            this.ProdQty.TabIndex = 15;
            this.ProdQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantity";
            // 
            // ProdPrice
            // 
            this.ProdPrice.BackColor = System.Drawing.Color.MidnightBlue;
            this.ProdPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdPrice.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice.ForeColor = System.Drawing.Color.White;
            this.ProdPrice.HintForeColor = System.Drawing.Color.White;
            this.ProdPrice.HintText = "";
            this.ProdPrice.isPassword = false;
            this.ProdPrice.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.ProdPrice.LineIdleColor = System.Drawing.Color.White;
            this.ProdPrice.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.ProdPrice.LineThickness = 3;
            this.ProdPrice.Location = new System.Drawing.Point(187, 347);
            this.ProdPrice.Margin = new System.Windows.Forms.Padding(4);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(305, 46);
            this.ProdPrice.TabIndex = 13;
            this.ProdPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price";
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.MidnightBlue;
            this.ProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdName.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.ForeColor = System.Drawing.Color.White;
            this.ProdName.HintForeColor = System.Drawing.Color.White;
            this.ProdName.HintText = "";
            this.ProdName.isPassword = false;
            this.ProdName.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.ProdName.LineIdleColor = System.Drawing.Color.White;
            this.ProdName.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.ProdName.LineThickness = 3;
            this.ProdName.Location = new System.Drawing.Point(187, 284);
            this.ProdName.Margin = new System.Windows.Forms.Padding(4);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(305, 46);
            this.ProdName.TabIndex = 11;
            this.ProdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
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
            this.ProdID.Location = new System.Drawing.Point(187, 221);
            this.ProdID.Margin = new System.Windows.Forms.Padding(4);
            this.ProdID.Name = "ProdID";
            this.ProdID.Size = new System.Drawing.Size(305, 46);
            this.ProdID.TabIndex = 9;
            this.ProdID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::InventoryMgmtSoftware.Properties.Resources.dairy_products;
            this.pictureBox6.Location = new System.Drawing.Point(79, 72);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 66);
            this.label1.TabIndex = 6;
            this.label1.Text = "Products";
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
            // Dashboard
            // 
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Location = new System.Drawing.Point(66, 84);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(130, 40);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.MidnightBlue;
            this.Products.FlatAppearance.BorderSize = 0;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.Color.White;
            this.Products.Location = new System.Drawing.Point(66, 197);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(130, 40);
            this.Products.TabIndex = 1;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = false;
            // 
            // Categories
            // 
            this.Categories.FlatAppearance.BorderSize = 0;
            this.Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categories.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.Location = new System.Drawing.Point(66, 310);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(130, 40);
            this.Categories.TabIndex = 2;
            this.Categories.Text = "Categories";
            this.Categories.UseVisualStyleBackColor = true;
            this.Categories.Click += new System.EventHandler(this.button3_Click);
            // 
            // Users
            // 
            this.Users.FlatAppearance.BorderSize = 0;
            this.Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.Location = new System.Drawing.Point(66, 649);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(130, 40);
            this.Users.TabIndex = 3;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.button4_Click);
            // 
            // Stock
            // 
            this.Stock.FlatAppearance.BorderSize = 0;
            this.Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stock.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.Location = new System.Drawing.Point(66, 423);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(130, 40);
            this.Stock.TabIndex = 4;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::InventoryMgmtSoftware.Properties.Resources.user1;
            this.pictureBox5.Location = new System.Drawing.Point(12, 639);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::InventoryMgmtSoftware.Properties.Resources.in_stock;
            this.pictureBox4.Location = new System.Drawing.Point(12, 413);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InventoryMgmtSoftware.Properties.Resources.apps;
            this.pictureBox3.Location = new System.Drawing.Point(12, 300);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventoryMgmtSoftware.Properties.Resources.products;
            this.pictureBox2.Location = new System.Drawing.Point(12, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryMgmtSoftware.Properties.Resources.monitor;
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Report
            // 
            this.Report.FlatAppearance.BorderSize = 0;
            this.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.Location = new System.Drawing.Point(68, 536);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(130, 40);
            this.Report.TabIndex = 14;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::InventoryMgmtSoftware.Properties.Resources.report;
            this.pictureBox7.Location = new System.Drawing.Point(12, 526);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // Form3
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button Categories;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdQty;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdPrice;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdName;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdID;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox ProdCategory;
        private System.Windows.Forms.DataGridView ProdData;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ComboBox Prod;
    }
}