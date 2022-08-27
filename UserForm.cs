using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventoryMgmtSoftware
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into users values('" + UserName.Text + "', '" + UserPassword.Text + "', '" + UserRole.Text + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("User added successfully by admin");
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserName.Text == "" || UserPassword.Text == "" || UserRole.Text == "")
                {
                    MessageBox.Show("Please fill all required fields");
                }
                else
                {
                    conn.Open();
                    string query = "update users set UserName='" + UserName.Text + "', UserPassword='" + UserPassword.Text + "', UserRole='" + UserRole.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully, refresh to see changes");
                    conn.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void getData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select * from users";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            UserData.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserName.Text == "")
                {
                    MessageBox.Show("Select a user to delete");
                }
                else
                {
                    conn.Open();
                    string query = "delete from users where UserName=" + UserName.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted successfully by admin");
                    conn.Close();
                    getData();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            ProductForm log = new ProductForm();
            this.Hide();
            log.Show();
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            CategoriesForm log = new CategoriesForm();
            this.Hide();
            log.Show();
        }

        private void UserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserName.Text = UserData.SelectedRows[0].Cells[0].Value.ToString();
            UserPassword.Text = UserData.SelectedRows[0].Cells[1].Value.ToString();
            UserRole.Text = UserData.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            StockForm log = new StockForm();
            this.Hide();
            log.Show();
        }
    }
}
