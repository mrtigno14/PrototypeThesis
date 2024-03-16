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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;


        }

        public int pictureBoxClickCount = 0;


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBoxClickCount++;

            // Create and configure the label
            Label picture1 = new Label();
            picture1.Text = "Nihaha: " + pictureBoxClickCount.ToString();
            picture1.AutoSize = true;

            // Add the label to the panel at index 0
            panel1.Controls.Add(picture1);
            panel1.Controls.SetChildIndex(picture1, 0);
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            pictureBoxClickCount = 0;
        }
    }
}
