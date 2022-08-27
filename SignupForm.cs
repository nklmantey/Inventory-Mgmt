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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void Signup_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into users values('" + UserName.Text + "', '" + UserPassword.Text + "', '" + Role.Text + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("User added successfuly");
                conn.Close();
                LoginForm log = new LoginForm();
                this.Hide();
                log.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
