using MySql.Data.MySqlClient;
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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into category values(" + CatID.Text + ", '" + CatName.Text + "', '" + CatDesc.Text + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Category added successfuly");
                conn.Close();
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void getData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select * from category";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            CatData.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            getData(); 
        }

        private void Products_Click(object sender, EventArgs e)
        {
            ProductForm log = new ProductForm();
            this.Hide();
            log.Show();
        }

        private void CatData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatID.Text = CatData.SelectedRows[0].Cells[0].Value.ToString();
            CatName.Text = CatData.SelectedRows[0].Cells[1].Value.ToString();
            CatDesc.Text = CatData.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatID.Text == "")
                {
                    MessageBox.Show("Select a category to delete");
                } else
                {
                    conn.Open();
                    string query = "delete from category where CatID=" + CatID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category successfully deleted");
                    conn.Close();
                    getData();
                }
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatID.Text == "" || CatName.Text == "" || CatDesc.Text == "")
                {
                    MessageBox.Show("Please fill all required fields");
                } else
                {
                    conn.Open();
                    string query = "update category set CatName='" + CatName.Text + "', CatDesc='" + CatDesc.Text + "' where CatID=" + CatID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category successfully updated, refresh to see changes");
                    conn.Close();
                }
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Users_Click(object sender, EventArgs e)
        {
            UserForm log = new UserForm();
            this.Hide();
            log.Show();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            StockForm log = new StockForm();
            this.Hide();
            log.Show();
        }
    }
}
