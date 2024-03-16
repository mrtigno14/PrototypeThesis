using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Thesis
{
    public partial class Form3 : Form
    {
        private int pictureBox1Quantity = 0;
        private int pictureBox2Quantity = 0;
        private const int paracetamolPricePerUnit = 10;
        private const int neozepPricePerUnit = 15;

        public Form3()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1Quantity++;
            UpdateLabel("Paracetamol", pictureBox1Quantity * paracetamolPricePerUnit);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2Quantity++;
            UpdateLabel("Neozep", pictureBox2Quantity * neozepPricePerUnit);
        }

        private void UpdateLabel(string productName, int totalPrice)
        {
            // Check if a label for the product already exists
            Label existingLabel = panel1.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == productName + "Label");

            if (existingLabel != null)
            {
                // Update the existing label with new information
                existingLabel.Text = $"{productName}: {GetQuantity(productName)} - Total Price: Php{totalPrice}";
            }
            else
            {
                // Create and configure the label
                Label newLabel = new Label();
                newLabel.Name = productName + "Label";
                newLabel.Text = $"{productName}: {GetQuantity(productName)} - Total Price: Php{totalPrice}";
                newLabel.AutoSize = true;

                // Calculate Y-position for the label
                int newY = panel1.Controls.Count * newLabel.Height;

                // Set the location of the label
                newLabel.Location = new System.Drawing.Point(0, newY);

                // Add the label to the panel
                panel1.Controls.Add(newLabel);
            }
        }

        private int GetQuantity(string productName)
        {
            switch (productName)
            {
                case "Paracetamol":
                    return pictureBox1Quantity;
                case "Neozep":
                    return pictureBox2Quantity;
                default:
                    return 0;
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            pictureBox1Quantity = 0;
            pictureBox2Quantity = 0;
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count == 0)
            {
                MessageBox.Show("Please add items to the order before checking out.");
                return;
            }

            orderSummary f4 = new orderSummary();
            f4.FormClosed += (s, args) => this.Close();
            f4.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.FormClosed += (s, args) => this.Close();
            f2.Show();
            this.Hide();
        }
    }
}