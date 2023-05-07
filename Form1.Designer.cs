namespace Electricity_Bill_Calculator
{
    partial class Form1
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
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.accountNoTextBox = new System.Windows.Forms.TextBox();
            this.kWhUsedTextBox = new System.Windows.Forms.TextBox();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.Label();
            this.accountNo = new System.Windows.Forms.Label();
            this.kWhUsed = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.numCustomers = new System.Windows.Forms.Label();
            this.totalKWhUsed = new System.Windows.Forms.Label();
            this.avgBillAmount = new System.Windows.Forms.Label();
            this.numCustomersLabel = new System.Windows.Forms.TextBox();
            this.totalKWhUsedLabel = new System.Windows.Forms.TextBox();
            this.avgBillAmountLabel = new System.Windows.Forms.TextBox();
            this.UpdateCustomerList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(115, 114);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(115, 81);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // accountNoTextBox
            // 
            this.accountNoTextBox.Location = new System.Drawing.Point(115, 53);
            this.accountNoTextBox.Name = "accountNoTextBox";
            this.accountNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountNoTextBox.TabIndex = 2;
            // 
            // kWhUsedTextBox
            // 
            this.kWhUsedTextBox.Location = new System.Drawing.Point(115, 146);
            this.kWhUsedTextBox.Name = "kWhUsedTextBox";
            this.kWhUsedTextBox.Size = new System.Drawing.Size(100, 20);
            this.kWhUsedTextBox.TabIndex = 3;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(37, 12);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(91, 25);
            this.AddCustomerButton.TabIndex = 4;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(12, 81);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(51, 13);
            this.firstName.TabIndex = 5;
            this.firstName.Text = "firstName";
            // 
            // accountNo
            // 
            this.accountNo.AutoSize = true;
            this.accountNo.Location = new System.Drawing.Point(13, 53);
            this.accountNo.Name = "accountNo";
            this.accountNo.Size = new System.Drawing.Size(61, 13);
            this.accountNo.TabIndex = 6;
            this.accountNo.Text = "AccountNo";
            // 
            // kWhUsed
            // 
            this.kWhUsed.AutoSize = true;
            this.kWhUsed.Location = new System.Drawing.Point(19, 146);
            this.kWhUsed.Name = "kWhUsed";
            this.kWhUsed.Size = new System.Drawing.Size(55, 13);
            this.kWhUsed.TabIndex = 7;
            this.kWhUsed.Text = "kWhUsed";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(13, 114);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(51, 13);
            this.lastName.TabIndex = 8;
            this.lastName.Text = "lastName";
            // 
            // customersListBox
            // 
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.Location = new System.Drawing.Point(37, 272);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(388, 160);
            this.customersListBox.TabIndex = 9;
            // 
            // numCustomers
            // 
            this.numCustomers.AutoSize = true;
            this.numCustomers.Location = new System.Drawing.Point(284, 56);
            this.numCustomers.Name = "numCustomers";
            this.numCustomers.Size = new System.Drawing.Size(105, 13);
            this.numCustomers.TabIndex = 11;
            this.numCustomers.Text = "number of customers";
            // 
            // totalKWhUsed
            // 
            this.totalKWhUsed.AutoSize = true;
            this.totalKWhUsed.Location = new System.Drawing.Point(284, 88);
            this.totalKWhUsed.Name = "totalKWhUsed";
            this.totalKWhUsed.Size = new System.Drawing.Size(79, 13);
            this.totalKWhUsed.TabIndex = 12;
            this.totalKWhUsed.Text = "totalKWhUsed ";
            // 
            // avgBillAmount
            // 
            this.avgBillAmount.AutoSize = true;
            this.avgBillAmount.Location = new System.Drawing.Point(284, 128);
            this.avgBillAmount.Name = "avgBillAmount";
            this.avgBillAmount.Size = new System.Drawing.Size(99, 13);
            this.avgBillAmount.TabIndex = 13;
            this.avgBillAmount.Text = "average bill amount";
            // 
            // numCustomersLabel
            // 
            this.numCustomersLabel.Location = new System.Drawing.Point(431, 53);
            this.numCustomersLabel.Name = "numCustomersLabel";
            this.numCustomersLabel.Size = new System.Drawing.Size(100, 20);
            this.numCustomersLabel.TabIndex = 16;
            // 
            // totalKWhUsedLabel
            // 
            this.totalKWhUsedLabel.Location = new System.Drawing.Point(431, 88);
            this.totalKWhUsedLabel.Name = "totalKWhUsedLabel";
            this.totalKWhUsedLabel.Size = new System.Drawing.Size(100, 20);
            this.totalKWhUsedLabel.TabIndex = 17;
            // 
            // avgBillAmountLabel
            // 
            this.avgBillAmountLabel.Location = new System.Drawing.Point(431, 128);
            this.avgBillAmountLabel.Name = "avgBillAmountLabel";
            this.avgBillAmountLabel.Size = new System.Drawing.Size(100, 20);
            this.avgBillAmountLabel.TabIndex = 18;
            // 
            // UpdateCustomerList
            // 
            this.UpdateCustomerList.AutoSize = true;
            this.UpdateCustomerList.Location = new System.Drawing.Point(34, 247);
            this.UpdateCustomerList.Name = "UpdateCustomerList";
            this.UpdateCustomerList.Size = new System.Drawing.Size(114, 13);
            this.UpdateCustomerList.TabIndex = 21;
            this.UpdateCustomerList.Text = "Updated Customer List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateCustomerList);
            this.Controls.Add(this.avgBillAmountLabel);
            this.Controls.Add(this.totalKWhUsedLabel);
            this.Controls.Add(this.numCustomersLabel);
            this.Controls.Add(this.avgBillAmount);
            this.Controls.Add(this.totalKWhUsed);
            this.Controls.Add(this.numCustomers);
            this.Controls.Add(this.customersListBox);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.kWhUsed);
            this.Controls.Add(this.accountNo);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.kWhUsedTextBox);
            this.Controls.Add(this.accountNoTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Name = "Form1";
            this.Text = "Electricity Bill";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox accountNoTextBox;
        private System.Windows.Forms.TextBox kWhUsedTextBox;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label accountNo;
        private System.Windows.Forms.Label kWhUsed;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.Label numCustomers;
        private System.Windows.Forms.Label totalKWhUsed;
        private System.Windows.Forms.Label avgBillAmount;
        private System.Windows.Forms.TextBox numCustomersLabel;
        private System.Windows.Forms.TextBox totalKWhUsedLabel;
        private System.Windows.Forms.TextBox avgBillAmountLabel;
        private System.Windows.Forms.Label UpdateCustomerList;
    }
}

