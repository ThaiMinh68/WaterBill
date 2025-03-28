namespace WaterBill
{
    partial class AddInvoiceUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            CustomerIDInput = new TextBox();
            CustomerNameInput = new TextBox();
            label3 = new Label();
            ThisMonthInput = new TextBox();
            label4 = new Label();
            label5 = new Label();
            LastMonthInput = new TextBox();
            label6 = new Label();
            NumberOfPeopleInput = new TextBox();
            label7 = new Label();
            button1 = new Button();
            TypeOfCustomerInput = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            resultSubtotal = new Label();
            resultVATFee = new Label();
            resultEnvFee = new Label();
            resultTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(235, 35);
            label1.TabIndex = 0;
            label1.Text = "Add An Invoice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 82);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 1;
            label2.Text = "CustomerID";
            // 
            // CustomerIDInput
            // 
            CustomerIDInput.Location = new Point(3, 113);
            CustomerIDInput.Name = "CustomerIDInput";
            CustomerIDInput.Size = new Size(115, 27);
            CustomerIDInput.TabIndex = 2;
            // 
            // CustomerNameInput
            // 
            CustomerNameInput.Location = new Point(282, 113);
            CustomerNameInput.Name = "CustomerNameInput";
            CustomerNameInput.Size = new Size(115, 27);
            CustomerNameInput.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 82);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 3;
            label3.Text = "Customer Name";
            // 
            // ThisMonthInput
            // 
            ThisMonthInput.Location = new Point(3, 192);
            ThisMonthInput.Name = "ThisMonthInput";
            ThisMonthInput.Size = new Size(115, 27);
            ThisMonthInput.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 161);
            label4.Name = "label4";
            label4.Size = new Size(183, 25);
            label4.TabIndex = 5;
            label4.Text = "This Month Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 253);
            label5.Name = "label5";
            label5.Size = new Size(162, 25);
            label5.TabIndex = 7;
            label5.Text = "Type of Customer";
            // 
            // LastMonthInput
            // 
            LastMonthInput.Location = new Point(282, 192);
            LastMonthInput.Name = "LastMonthInput";
            LastMonthInput.Size = new Size(115, 27);
            LastMonthInput.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(282, 161);
            label6.Name = "label6";
            label6.Size = new Size(182, 25);
            label6.TabIndex = 9;
            label6.Text = "Last Month Number";
            // 
            // NumberOfPeopleInput
            // 
            NumberOfPeopleInput.Location = new Point(282, 284);
            NumberOfPeopleInput.Name = "NumberOfPeopleInput";
            NumberOfPeopleInput.Size = new Size(115, 27);
            NumberOfPeopleInput.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(282, 253);
            label7.Name = "label7";
            label7.Size = new Size(166, 25);
            label7.TabIndex = 11;
            label7.Text = "Number of People";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(282, 335);
            button1.Name = "button1";
            button1.Size = new Size(120, 41);
            button1.TabIndex = 13;
            button1.Text = "Calculate";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TypeOfCustomerInput
            // 
            TypeOfCustomerInput.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeOfCustomerInput.FormattingEnabled = true;
            TypeOfCustomerInput.Items.AddRange(new object[] { "Household Customer", "Administrative Agency, Public Services", "Production Units", "Business Services", "" });
            TypeOfCustomerInput.Location = new Point(0, 284);
            TypeOfCustomerInput.Name = "TypeOfCustomerInput";
            TypeOfCustomerInput.Size = new Size(205, 28);
            TypeOfCustomerInput.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 335);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 15;
            label8.Text = "Subtotal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 367);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 16;
            label9.Text = "Env Fee";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 398);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 17;
            label10.Text = "VAT Fee";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(282, 398);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 18;
            label11.Text = "Total: ";
            // 
            // resultSubtotal
            // 
            resultSubtotal.AutoSize = true;
            resultSubtotal.Location = new Point(107, 335);
            resultSubtotal.Name = "resultSubtotal";
            resultSubtotal.Size = new Size(0, 20);
            resultSubtotal.TabIndex = 19;
            // 
            // resultVATFee
            // 
            resultVATFee.AutoSize = true;
            resultVATFee.Location = new Point(107, 398);
            resultVATFee.Name = "resultVATFee";
            resultVATFee.Size = new Size(0, 20);
            resultVATFee.TabIndex = 20;
            // 
            // resultEnvFee
            // 
            resultEnvFee.AutoSize = true;
            resultEnvFee.Location = new Point(107, 367);
            resultEnvFee.Name = "resultEnvFee";
            resultEnvFee.Size = new Size(0, 20);
            resultEnvFee.TabIndex = 20;
            // 
            // resultTotal
            // 
            resultTotal.AutoSize = true;
            resultTotal.Location = new Point(344, 398);
            resultTotal.Name = "resultTotal";
            resultTotal.Size = new Size(0, 20);
            resultTotal.TabIndex = 21;
            // 
            // AddInvoiceUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(resultTotal);
            Controls.Add(resultEnvFee);
            Controls.Add(resultVATFee);
            Controls.Add(resultSubtotal);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TypeOfCustomerInput);
            Controls.Add(button1);
            Controls.Add(NumberOfPeopleInput);
            Controls.Add(label7);
            Controls.Add(LastMonthInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ThisMonthInput);
            Controls.Add(label4);
            Controls.Add(CustomerNameInput);
            Controls.Add(label3);
            Controls.Add(CustomerIDInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddInvoiceUserControl";
            Size = new Size(485, 447);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CustomerIDInput;
        private TextBox CustomerNameInput;
        private Label label3;
        private TextBox ThisMonthInput;
        private Label label4;
        private Label label5;
        private TextBox LastMonthInput;
        private Label label6;
        private TextBox NumberOfPeopleInput;
        private Label label7;
        private Button button1;
        private ComboBox TypeOfCustomerInput;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label resultSubtotal;
        private Label resultVATFee;
        private Label resultEnvFee;
        private Label resultTotal;
    }
}
