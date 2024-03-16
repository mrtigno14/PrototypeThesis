using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

            panel1.FontChanged += Panel1_FontChanged;
            panel1.Resize += Panel1_Resize;
        }

        // Event handler for font change in panel1
        private void Panel1_FontChanged(object sender, EventArgs e)
        {
            // Call the method to update label sizes when the font changes
            UpdateLabelSizes();
        }

        // Event handler for resizing panel1
        private void Panel1_Resize(object sender, EventArgs e)
        {
            // Call the method to update label sizes when the panel resizes
            UpdateLabelSizes();
        }

        // Method to update label sizes based on the current font
        private void UpdateLabelSizes()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is System.Windows.Forms.Label)
                {
                    System.Windows.Forms.Label label = (System.Windows.Forms.Label)control;

                    // Measure the size required for the label with the current font
                    Size preferredSize = TextRenderer.MeasureText(label.Text, label.Font);

                    // Set the size of the label
                    label.Size = preferredSize;
                }
            }
        }

        public void UpdateOrderSummary(Dictionary<string, int> orderItems)
        {
            int offsetY = 0; // Offset to position each label vertically
            int totalSum = 0; // Variable to hold the total sum

            foreach (var item in orderItems)
            {
                // Create label for each item
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Text = $"{item.Key}: ₱{item.Value}";
                label.Font = panel1.Font; // Set label font to match panel font

                // Measure the size required for the label
                Size preferredSize = TextRenderer.MeasureText(label.Text, label.Font);

                // Set the size and location of the label
                label.Size = preferredSize;
                label.Location = new Point(0, offsetY);

                // Add the label to the panel
                panel1.Controls.Add(label);

                // Increase the offset for the next label
                offsetY += label.Height;

                // Add the current item value to the total sum
                totalSum += item.Value;
            }

            // Create label for total sum
            System.Windows.Forms.Label totalLabel = new System.Windows.Forms.Label();
            totalLabel.Text = $"Total Amount: ₱{totalSum}";
            totalLabel.Font = panel1.Font; // Set label font to match panel font

            // Measure the size required for the total label
            Size totalSize = TextRenderer.MeasureText(totalLabel.Text, totalLabel.Font);

            // Set the size and location of the total label
            totalLabel.Size = totalSize;
            totalLabel.Location = new Point(0, offsetY); // Set the location below other labels
            panel1.Controls.Add(totalLabel); // Add the total label to the panel
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

        private void cashButton_Click(object sender, EventArgs e)
        {
            cash c = new cash();
            c.FormClosed += (s, args) => this.Close();
            c.Show();
            this.Hide();
        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
