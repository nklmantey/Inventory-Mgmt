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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int startTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startTime += 1;
            CircleLoad.Value = startTime;
            if (CircleLoad.Value == 100)
            {
                CircleLoad.Value = 0;
                timer1.Stop();
                LoginForm  log = new LoginForm();
                this.Hide();
                log.Show();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
