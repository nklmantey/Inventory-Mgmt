using MySql.Data.MySqlClient;
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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserForm log = new UserForm();
            this.Hide();
            log.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CategoriesForm log = new CategoriesForm();
            this.Hide();
            log.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                string query = "insert into products values(" + ProdID.Text + ", '" + ProdName.Text + "', '" + ProdPrice.Text + "', '" + ProdQty.Text + "', '" + ProdCategory.Text + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
                conn.Close();
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
            string query = "select * from products";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            ProdData.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void dropDownOps()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select CatName from category";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(reader);
            ProdCategory.ValueMember = "CatName";
            ProdCategory.DataSource = dt;
            conn.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            getData();
            dropDownOps();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                if (ProdID.Text == "")
                {
                    MessageBox.Show("Select a product to delete");
                }
                else
                {
                    conn.Open();
                    string query = "delete from products where ProdID=" + ProdID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product successfully deleted");
                    conn.Close();
                    getData();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ProdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdID.Text = ProdData.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdData.SelectedRows[0].Cells[1].Value.ToString();
            ProdPrice.Text = ProdData.SelectedRows[0].Cells[2].Value.ToString();
            ProdQty.Text = ProdData.SelectedRows[0].Cells[3].Value.ToString();
            ProdCategory.Text = ProdData.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                if (ProdID.Text == "" || ProdName.Text == "" || ProdPrice.Text == "" || ProdQty.Text == "" || ProdCategory.Text == "")
                {
                    MessageBox.Show("Please fill all required fields");
                }
                else
                {
                    conn.Open();
                    string query = "update products set ProdName='" + ProdName.Text + "', ProdPrice='" + ProdPrice.Text + "', ProdQty='" + ProdQty.Text + "', ProdCategory='" + ProdCategory.Text + "' where ProdID=" + ProdID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product successfully updated, refresh to see changes");
                    conn.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            StockForm log = new StockForm();
            this.Hide();
            log.Show();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            ReportForm log = new ReportForm();
            this.Hide();
            log.Show();
        }

        private void ProdCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
