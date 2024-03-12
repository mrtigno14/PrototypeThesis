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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.FormClosed += (s, args) => this.Close(); 
            f1.Show();
            this.Hide(); // Hide Form1
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
