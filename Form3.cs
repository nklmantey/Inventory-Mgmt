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
    public partial class Form3 : Form
    {
        public Form3()
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

        }

        private void button3_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Product added successfuly");
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
        private void Form3_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void ProdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }
    }
}
