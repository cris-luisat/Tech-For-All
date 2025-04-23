using DashBoard.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Menu menu = new Menu();
            menu.Dock = DockStyle.Fill;
            menu.BringToFront();
            panel2.Controls.Clear();
            panel2.Controls.Add(menu);
            menu.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
