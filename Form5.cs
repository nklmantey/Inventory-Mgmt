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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            string query = "INSERT INTO categories(CatName, CatDesc) VALUES (@name, @desc)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", CatName.Text);
            cmd.Parameters.AddWithValue("@desc", CatDesc.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Category added successfully");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
