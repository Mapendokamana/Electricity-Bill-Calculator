
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_Bill_Calculator
{
    public partial class Form1 : Form
    {
        private List<Customer> customers = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

       
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            int accountNo = 0;
            bool validAccountNo = int.TryParse(accountNoTextBox.Text, out accountNo);

            if (!validAccountNo || customers.Any(c => c.AccountNo == accountNo))
            {
               
                MessageBox.Show("Please enter a unique integer value for the account number.");
                return;
            }
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            decimal kWhUsed = 0.0m;
            bool validKWhUsed = decimal.TryParse(kWhUsedTextBox.Text, out kWhUsed);

            if (!validKWhUsed || kWhUsed < 0)
            {
                MessageBox.Show("Please enter a non-negative decimal value for kWh used.");
                return;
            }

            Customer customer = new Customer(accountNo, firstName, lastName, kWhUsed);
            customers.Add(customer);
            int numCustomers = customers.Count;
            decimal totalKWhUsed = customers.Sum(c => c.KWhUsed);
            decimal avgBillAmount = customers.Average(c => c.BillAmount);

            numCustomersLabel.Text = numCustomers.ToString();
            totalKWhUsedLabel.Text = totalKWhUsed.ToString();
            avgBillAmountLabel.Text = avgBillAmount.ToString("C2");
            UpdateCustomerList_Click_1();
            ClearInputFields_Click();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void UpdateCustomerList_Click_1()
        {
            customersListBox.Items.Clear();

            foreach (Customer customer in customers)
            {
                customersListBox.Items.Add(customer.ToString());
            }
        }

        private void ClearInputFields_Click()
        {
            accountNoTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            kWhUsedTextBox.Clear();
        
    }

       
    }
}