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
            Form2 f2 = new Form2();
            f2.FormClosed += (s, args) => this.Close(); 
            f2.Show();
            this.Hide(); // Hide Form1
        }
    }
}
