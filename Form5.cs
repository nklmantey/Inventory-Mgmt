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
    public partial class Form5 : Form
    {
        public Form5()
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
    }
}
