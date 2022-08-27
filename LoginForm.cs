using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryMgmtSoftware
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
        private void Login_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = UserPassword.Text;

            try
            {
                string query1 = "select * from users where UserName = '" + UserName.Text + "' AND UserPassword = '" + UserPassword.Text + "' AND UserRole = '" + Role.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query1, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0 && Role.Text == "Admin")
                {
                    username = UserName.Text;
                    password = UserPassword.Text;
                    ProductForm log = new ProductForm();
                    this.Hide();
                    log.Show();
                } else if (dtable.Rows.Count > 0 && Role.Text == "Attendant")
                {
                    username = UserName.Text;
                    password = UserPassword.Text;
                    ProductForm log = new ProductForm();
                    this.Hide();
                    log.Show();
                }
                {
                    MessageBox.Show("Invalid user credentials");
                    UserName.Text = "";
                    UserPassword.Text = "";
                }
            } catch
            {
                MessageBox.Show("Invalid user credentials");
            } finally
            {
                conn.Close();
            }
        }
    }
}
