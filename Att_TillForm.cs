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
    public partial class Att_TillForm : Form
    {
        System.Timers.Timer t;
        int h, m, s;

        public Att_TillForm()
        {
            InitializeComponent();
        }

        private void Att_TillForm_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                Result.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2,'0'), m.ToString().PadLeft(2,'0'), s.ToString().PadLeft(2,'0'));
            }));
        }
        private void Open_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void Att_TillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }
    }
}
