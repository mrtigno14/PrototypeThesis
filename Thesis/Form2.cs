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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 is closed
            f3.Show();
            this.Hide(); // Hide Form1
        }

        private void customButton2_Click(object sender, EventArgs e)
        {

        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 is closed
            lf.Show();
            this.Hide(); // Hide Form1
        }
    }
}
