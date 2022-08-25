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

        private void Form3_Load(object sender, EventArgs e)
        {

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
            string server = "localhost";
            string db = "ims_db";
            string port = "3307";
            string username = "root";
            string password = "";
            string dbRef = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + db + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn = new MySqlConnection(dbRef);
            conn.Open();
            string query = "INSERT INTO products(ProdName, ProdPrice, ProdQty, ProdCategory) VALUES (@name, @price, @qty, @category)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", ProdName.Text);
            cmd.Parameters.AddWithValue("@price", ProdPrice.Text);
            cmd.Parameters.AddWithValue("@qty", ProdQty.Text);
            cmd.Parameters.AddWithValue("@category", ProdCategory.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product added successfully");
        }
    }
}
