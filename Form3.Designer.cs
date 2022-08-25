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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.Prod = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button11 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Controls.Add(this.dataGridView1);
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
            this.button10.Location = new System.Drawing.Point(881, 36);
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
            this.Prod.Location = new System.Drawing.Point(570, 36);
            this.Prod.Name = "Prod";
            this.Prod.Size = new System.Drawing.Size(305, 30);
            this.Prod.TabIndex = 21;
            this.Prod.Text = "Filter by category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(570, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 612);
            this.dataGridView1.TabIndex = 20;
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
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(66, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(66, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Products";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(66, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Categories";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(66, 649);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Users";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(66, 423);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "Stock";
            this.button5.UseVisualStyleBackColor = true;
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
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(68, 536);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(130, 40);
            this.button11.TabIndex = 14;
            this.button11.Text = "Report";
            this.button11.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ComboBox Prod;
    }
}