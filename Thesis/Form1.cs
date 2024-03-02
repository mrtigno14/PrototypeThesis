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
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            InitializeForm();

            WindowState = FormWindowState.Maximized;
        }

        private void InitializeForm()
        {
            

            label1.AutoSize = true;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            customButton1.AutoSize = true;
            customButton1.Anchor = AnchorStyles.None;
            


            Controls.Add(label1);
            Controls.Add(customButton1);

            
            this.Resize += MainForm_Resize;
            MainForm_Resize(this, EventArgs.Empty);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 69; // Adjust the top margin as needed

            int topMargin = 100; // Adjust the top margin value as needed
            customButton1.Left = (this.ClientSize.Width - customButton1.Width) / 2;
            customButton1.Top = (this.ClientSize.Height - customButton1.Height) / 2 + topMargin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Home";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 is closed
            f2.Show();
            this.Hide(); // Hide Form1
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
