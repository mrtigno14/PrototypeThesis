namespace Thesis
{
    partial class orderSummary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ecashButton = new CustomControls.RJControls.CustomButton1();
            this.cashButton = new CustomControls.RJControls.CustomButton1();
            this.backButton = new CustomControls.RJControls.CustomButton1();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(604, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ecashButton
            // 
            this.ecashButton.BackColor = System.Drawing.Color.Gold;
            this.ecashButton.BackgroundColor = System.Drawing.Color.Gold;
            this.ecashButton.BorderColor = System.Drawing.Color.Transparent;
            this.ecashButton.BorderRadius = 0;
            this.ecashButton.BorderSize = 0;
            this.ecashButton.FlatAppearance.BorderSize = 0;
            this.ecashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ecashButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecashButton.ForeColor = System.Drawing.Color.Black;
            this.ecashButton.Location = new System.Drawing.Point(1003, 854);
            this.ecashButton.Margin = new System.Windows.Forms.Padding(4);
            this.ecashButton.Name = "ecashButton";
            this.ecashButton.Size = new System.Drawing.Size(492, 85);
            this.ecashButton.TabIndex = 10;
            this.ecashButton.Text = "Pay via eCash";
            this.ecashButton.TextColor = System.Drawing.Color.Black;
            this.ecashButton.UseVisualStyleBackColor = false;
            // 
            // cashButton
            // 
            this.cashButton.BackColor = System.Drawing.Color.Gold;
            this.cashButton.BackgroundColor = System.Drawing.Color.Gold;
            this.cashButton.BorderColor = System.Drawing.Color.Transparent;
            this.cashButton.BorderRadius = 0;
            this.cashButton.BorderSize = 0;
            this.cashButton.FlatAppearance.BorderSize = 0;
            this.cashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashButton.ForeColor = System.Drawing.Color.Black;
            this.cashButton.Location = new System.Drawing.Point(260, 854);
            this.cashButton.Margin = new System.Windows.Forms.Padding(4);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(492, 85);
            this.cashButton.TabIndex = 9;
            this.cashButton.Text = "Pay via Cash";
            this.cashButton.TextColor = System.Drawing.Color.Black;
            this.cashButton.UseVisualStyleBackColor = false;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.BackgroundColor = System.Drawing.Color.Gold;
            this.backButton.BorderColor = System.Drawing.Color.Transparent;
            this.backButton.BorderRadius = 0;
            this.backButton.BorderSize = 0;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(60, 42);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(492, 85);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.TextColor = System.Drawing.Color.Black;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // orderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(1540, 1040);
            this.Controls.Add(this.ecashButton);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "orderSummary";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.CustomButton1 backButton;
        private CustomControls.RJControls.CustomButton1 cashButton;
        private CustomControls.RJControls.CustomButton1 ecashButton;
    }
}