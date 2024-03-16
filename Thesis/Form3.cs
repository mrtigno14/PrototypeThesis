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
        private SerialPort serialPort;
        public Form3()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            serialPort = new SerialPort();
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 9600;
            serialPort.DataReceived += SerialPort_DataReceived; // Subscribe to the DataReceived event
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read data from the serial port
            string data = serialPort.ReadLine();

            // Update UI in a thread-safe manner
            this.Invoke(new Action(() =>
            {
                // Process the received data here
                // For example, you can update PictureBox1ClickCount based on received data
                pictureBox1ClickCount = Convert.ToInt32(data);
            }));
        }

        public int pictureBox1ClickCount = 0;
        public int pictureBox2ClickCount = 0;


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Method to determine the price based on PictureBox click
        private int paracetamolPrice(int pictureBox1ClickCount)
        {

            // Define a dictionary to map PictureBox click counts to prices
            Dictionary<int, int> priceMap = new Dictionary<int, int>()
            {
                { 1, 10 },   // First click costs $10
                { 2, 15 },   // Second click costs $15
                { 3, 20 },   // Third click costs $20


            };

            // Check if the click count exists in the price map
            if (priceMap.ContainsKey(pictureBox1ClickCount))
            {
                // Return the corresponding price
                return priceMap[pictureBox1ClickCount];
            }
            else
            {
                // Return a default price if the click count does not exist in the map
                return 25;  // Default price for clicks beyond the third click
            }

            // Implement logic to associate each PictureBox click with a specific price
            // For example, you can use a switch statement or a lookup table
            // For demonstration purposes, let's assume each click adds $10 to the price
            return pictureBox1ClickCount * 10;
        }

        private int neozepPrice(int pictureBox2ClickCount)
        {

            // Define a dictionary to map PictureBox click counts to prices
            Dictionary<int, int> priceMap = new Dictionary<int, int>()
            {
                { 1, 10 },   // First click costs $10
                { 2, 15 },   // Second click costs $15
                { 3, 20 },   // Third click costs $20


            };

            // Check if the click count exists in the price map
            if (priceMap.ContainsKey(pictureBox2ClickCount))
            {
                // Return the corresponding price
                return priceMap[pictureBox2ClickCount];
            }
            else
            {
                // Return a default price if the click count does not exist in the map
                return 25;  // Default price for clicks beyond the third click
            }

            // Implement logic to associate each PictureBox click with a specific price
            // For example, you can use a switch statement or a lookup table
            // For demonstration purposes, let's assume each click adds $10 to the price
            return pictureBox2ClickCount * 10;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1ClickCount++;

            // Determine the price based on the PictureBox clicked
            int price = paracetamolPrice(pictureBox1ClickCount); // Implement this method to associate price with PictureBox

            // Check if a label for Paracetamol already exists
            Label existingLabel = panel1.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == "ParacetamolLabel");
            if (existingLabel != null)
            {
                // Update the existing label with new information
                existingLabel.Text = "Paracetamol: " + pictureBox1ClickCount.ToString() + " - Price: Php" + price.ToString();
            }
            else
            {
                // Create and configure the label
                Label picture1 = new Label();
                picture1.Name = "ParacetamolLabel";
                picture1.Text = "Paracetamol: " + pictureBox1ClickCount.ToString() + " - Price: Php" + price.ToString();
                picture1.AutoSize = true;

                // Calculate Y-position for the label
                int newY = panel1.Controls.Count * picture1.Height;

                // Set the location of the label
                picture1.Location = new Point(0, newY);

                // Add the label to the panel
                panel1.Controls.Add(picture1);
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            pictureBox1ClickCount = 0;
            pictureBox2ClickCount = 0;

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2ClickCount++;

            // Determine the price based on the PictureBox clicked
            int price = neozepPrice(pictureBox2ClickCount); // Implement this method to associate price with PictureBox

            // Check if a label for Neozep already exists
            Label existingLabel = panel1.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == "NeozepLabel");
            if (existingLabel != null)
            {
                // Update the existing label with new information
                existingLabel.Text = "Neozep: " + pictureBox2ClickCount.ToString() + " - Price: Php" + price.ToString();
            }
            else
            {
                // Create and configure the label
                Label picture2 = new Label();
                picture2.Name = "NeozepLabel";
                picture2.Text = "Neozep: " + pictureBox2ClickCount.ToString() + " - Price: Php" + price.ToString();
                picture2.AutoSize = true;

                // Calculate Y-position for the label
                int newY = panel1.Controls.Count * picture2.Height;

                // Set the location of the label
                picture2.Location = new Point(0, newY);

                // Add the label to the panel
                panel1.Controls.Add(picture2);
            }
        }
    }
}