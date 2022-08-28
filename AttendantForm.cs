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
    public partial class AttendantForm : Form
    {
        System.Timers.Timer timer;
        int hours, mins, secs;
        public AttendantForm()
        {
            InitializeComponent();
        }

        private void AttendantForm_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent; 
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                secs += 1;
                if (secs == 60)
                {
                    secs = 0;
                    mins += 1;
                }
                if (mins == 60)
                {
                    mins = 0;
                    hours += 1;
                }
                Result.Text = string.Format("{0}:{1}:{2}", hours.ToString().PadLeft(2, '0'), mins.ToString().PadLeft(2, '0'), secs.ToString().PadLeft(2, '0'));
            }
            ));
        }

        private void Open_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TransactionsForm tf = new TransactionsForm();
            this.Hide();
            tf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StockForm tf = new StockForm();
            this.Hide();
            tf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportForm tf = new ReportForm();
            this.Hide();
            tf.Show();
        }

        private void AttendantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            Application.DoEvents();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
