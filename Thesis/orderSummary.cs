using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis
{
    public partial class orderSummary : Form
    {
        public orderSummary()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.FormClosed += (s, args) => this.Close();
            f3.Show();
            this.Hide();
        }
    }
}
