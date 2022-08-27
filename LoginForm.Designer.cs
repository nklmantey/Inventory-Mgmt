namespace InventoryMgmtSoftware
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.ComboBox();
            this.UserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button6 = new System.Windows.Forms.Button();
            this.Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Signup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(565, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log In";
            // 
            // Role
            // 
            this.Role.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "Admin",
            "Attendant"});
            this.Role.Location = new System.Drawing.Point(576, 116);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(257, 34);
            this.Role.TabIndex = 2;
            this.Role.Text = "Choose your role";
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.MidnightBlue;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.HintForeColor = System.Drawing.Color.White;
            this.UserName.HintText = "";
            this.UserName.isPassword = false;
            this.UserName.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.UserName.LineIdleColor = System.Drawing.Color.White;
            this.UserName.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.UserName.LineThickness = 3;
            this.UserName.Location = new System.Drawing.Point(582, 198);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(305, 46);
            this.UserName.TabIndex = 5;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UserPassword
            // 
            this.UserPassword.BackColor = System.Drawing.Color.MidnightBlue;
            this.UserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPassword.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPassword.ForeColor = System.Drawing.Color.White;
            this.UserPassword.HintForeColor = System.Drawing.Color.White;
            this.UserPassword.HintText = "";
            this.UserPassword.isPassword = true;
            this.UserPassword.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.UserPassword.LineIdleColor = System.Drawing.Color.White;
            this.UserPassword.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.UserPassword.LineThickness = 3;
            this.UserPassword.Location = new System.Drawing.Point(582, 346);
            this.UserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(305, 46);
            this.UserPassword.TabIndex = 6;
            this.UserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(859, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "x";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Login
            // 
            this.Login.ActiveBorderThickness = 1;
            this.Login.ActiveCornerRadius = 20;
            this.Login.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.Login.ActiveForecolor = System.Drawing.Color.White;
            this.Login.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.Login.BackColor = System.Drawing.Color.MidnightBlue;
            this.Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login.BackgroundImage")));
            this.Login.ButtonText = "Login";
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.IdleBorderThickness = 1;
            this.Login.IdleCornerRadius = 20;
            this.Login.IdleFillColor = System.Drawing.Color.White;
            this.Login.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.Login.IdleLineColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(576, 434);
            this.Login.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(150, 66);
            this.Login.TabIndex = 8;
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InventoryMgmtSoftware.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(525, 346);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventoryMgmtSoftware.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(525, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Signup
            // 
            this.Signup.ActiveBorderThickness = 1;
            this.Signup.ActiveCornerRadius = 20;
            this.Signup.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.Signup.ActiveForecolor = System.Drawing.Color.White;
            this.Signup.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.Signup.BackColor = System.Drawing.Color.MidnightBlue;
            this.Signup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Signup.BackgroundImage")));
            this.Signup.ButtonText = "Signup";
            this.Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.ForeColor = System.Drawing.Color.White;
            this.Signup.IdleBorderThickness = 1;
            this.Signup.IdleCornerRadius = 20;
            this.Signup.IdleFillColor = System.Drawing.Color.White;
            this.Signup.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.Signup.IdleLineColor = System.Drawing.Color.White;
            this.Signup.Location = new System.Drawing.Point(737, 434);
            this.Signup.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(150, 66);
            this.Signup.TabIndex = 9;
            this.Signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryMgmtSoftware.Properties.Resources._20946011;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Role;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserPassword;
        private System.Windows.Forms.Button button6;
        private Bunifu.Framework.UI.BunifuThinButton2 Login;
        private Bunifu.Framework.UI.BunifuThinButton2 Signup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}