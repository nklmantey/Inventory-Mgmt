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
    public partial class TransactionsForm : Form
    {
        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProdPrice_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void TransactionsForm_Load(object sender, EventArgs e)
        {
        }
        private void Till_Click(object sender, EventArgs e)
        {
            AttendantForm attendantForm = new AttendantForm();
            this.Hide();
            attendantForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Date.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        int OverallSum = 0;
        private void button7_Click(object sender, EventArgs e)
        {            
            if (ProdID.Text == "" || ProdName.Text == "" || ProdPrice.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Fill in all fields");
            }
            else
            {
                int ProdTotal = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderData);
                newRow.Cells[0].Value = ProdID.Text;
                newRow.Cells[1].Value = ProdName.Text;
                newRow.Cells[2].Value = ProdPrice.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                OrderData.Rows.Add(newRow);
                OverallSum = OverallSum + ProdTotal;

                Amount.Text = "GHS " + OverallSum;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if (ProdID.Text == "" || Attendant.Text == "" || Date.Text == "" || Amount.Text == "")
            {
                MessageBox.Show("Please fill in all required information");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nklmantey\Documents\ims_db.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();
                    string query = "insert into receipts values(" + ProdID.Text + ", '" + Attendant.Text + "', '" + Date.Text + "', '" + OverallSum + "')";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Receipt recorded successfully");
                    conn.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void Amount_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StockForm st = new StockForm();
            this.Hide();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            this.Hide();
            rf.Show();
        }
    }
}
