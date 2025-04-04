﻿namespace WaterBill
{
    partial class WaterBill
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterBill));
            panel1 = new Panel();
            ExitMenuButton = new Button();
            pictureBox1 = new PictureBox();
            ManageInvoicesMenuButton = new Button();
            AddInvoiceMenuButton = new Button();
            addInvoiceUserControl = new AddInvoiceUserControl();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ExitMenuButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ManageInvoicesMenuButton);
            panel1.Controls.Add(AddInvoiceMenuButton);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 560);
            panel1.TabIndex = 0;
            // 
            // ExitMenuButton
            // 
            ExitMenuButton.Location = new Point(0, 499);
            ExitMenuButton.Name = "ExitMenuButton";
            ExitMenuButton.Size = new Size(207, 61);
            ExitMenuButton.TabIndex = 3;
            ExitMenuButton.Text = "Exit";
            ExitMenuButton.UseVisualStyleBackColor = true;
            ExitMenuButton.Click += ExitMenuButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 119);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ManageInvoicesMenuButton
            // 
            ManageInvoicesMenuButton.Location = new Point(0, 209);
            ManageInvoicesMenuButton.Name = "ManageInvoicesMenuButton";
            ManageInvoicesMenuButton.Size = new Size(207, 61);
            ManageInvoicesMenuButton.TabIndex = 1;
            ManageInvoicesMenuButton.Text = "Manage Invoices";
            ManageInvoicesMenuButton.UseVisualStyleBackColor = true;
            // 
            // AddInvoiceMenuButton
            // 
            AddInvoiceMenuButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddInvoiceMenuButton.Location = new Point(0, 142);
            AddInvoiceMenuButton.Name = "AddInvoiceMenuButton";
            AddInvoiceMenuButton.Size = new Size(207, 61);
            AddInvoiceMenuButton.TabIndex = 0;
            AddInvoiceMenuButton.Text = "Add Invoice";
            AddInvoiceMenuButton.UseVisualStyleBackColor = true;
            AddInvoiceMenuButton.Click += AddInvoiceMenuButton_Click;
            // 
            // addInvoiceUserControl
            // 
            addInvoiceUserControl.Location = new Point(213, 1);
            addInvoiceUserControl.Name = "addInvoiceUserControl";
            addInvoiceUserControl.Size = new Size(606, 559);
            addInvoiceUserControl.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(77, 337);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // WaterBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(817, 563);
            Controls.Add(addInvoiceUserControl);
            Controls.Add(panel1);
            Name = "WaterBill";
            StartPosition = FormStartPosition.CenterParent;
            Text = "WaterBill";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddInvoiceMenuButton;
        private Button ManageInvoicesMenuButton;
        private PictureBox pictureBox1;
        private Button ExitMenuButton;
        private AddInvoiceUserControl addInvoiceUserControl1;
        private AddInvoiceUserControl addInvoiceUserControl;
        private Button button1;
    }
}
