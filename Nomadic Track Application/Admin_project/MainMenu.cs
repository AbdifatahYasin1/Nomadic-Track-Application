using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAsset frm = new FrmAsset();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmlocation frm = new Frmlocation();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmRelative frm = new FrmRelative();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
