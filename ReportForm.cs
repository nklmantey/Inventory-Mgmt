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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void getData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select * from receipts";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            SalesData.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                    conn.Open();
                    string query = "delete from receipts where ReceiptID=" + SalesData.SelectedRows[0].Cells[0].Value.ToString() + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receipt successfully deleted");
                    conn.Close();
                    getData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Till_Click(object sender, EventArgs e)
        {
            AttendantForm attendantForm = new AttendantForm();
            this.Hide();
            attendantForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TransactionsForm tf = new TransactionsForm();
            this.Hide();
            tf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StockForm stockForm = new StockForm();
            this.Hide();
            stockForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Shoprite Inventory System", new Font("JetBrains Mono", 25, FontStyle.Bold), Brushes.Red, new Point(Top));
            e.Graphics.DrawString("Receipt ID: " + SalesData.SelectedRows[0].Cells[0].Value.ToString(), new Font("JetBrains Mono", 15, FontStyle.Bold), Brushes.Black, new Point(30, 70));
            e.Graphics.DrawString("Attendant Name: " + SalesData.SelectedRows[0].Cells[1].Value.ToString(), new Font("JetBrains Mono", 15, FontStyle.Bold), Brushes.Black, new Point(30, 100));
            e.Graphics.DrawString("Date: " + SalesData.SelectedRows[0].Cells[2].Value.ToString(), new Font("JetBrains Mono", 15, FontStyle.Bold), Brushes.Black, new Point(30, 130));
            e.Graphics.DrawString("Total: " + SalesData.SelectedRows[0].Cells[3].Value.ToString() + " cedis", new Font("JetBrains Mono", 15, FontStyle.Bold), Brushes.Black, new Point(30, 160));
        }
    }
}
