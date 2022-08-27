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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
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

        private void Report_Click(object sender, EventArgs e)
        {

        }

        private void Users_Click(object sender, EventArgs e)
        {
            UserForm log = new UserForm();
            this.Hide();
            log.Show();
        }

        private void getData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select ProdQty, ProdName from products";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            StockData.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void StockData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
