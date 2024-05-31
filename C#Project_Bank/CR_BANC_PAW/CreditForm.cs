using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CR_BANC_PAW
{
    internal partial class CreditForm : Form
    {
        private Clienti newClient; // Field to store the NewClient object

        public CreditForm(Clienti newClient)
        {
            InitializeComponent();
            this.newClient = newClient; // Assign the newClient parameter to the newClient field
            SetClientInfo(newClient.Nume, newClient.ID); // Set client info in the form
        }

        public void SetClientInfo(string name, int id)
        {
            txtF3Name.Text = name;
            txtF3ID.Text = id.ToString();
        }

            private void btnAddCredit_Click(object sender, EventArgs e)
            {
                try
                {
                    // Check if newClient is null
                    if (newClient == null)
                    {
                        MessageBox.Show("Error: Client information not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validate input fields
                    if (string.IsNullOrWhiteSpace(txtLoanAmount.Text) ||
                        string.IsNullOrWhiteSpace(txtInterestRate.Text) ||
                        string.IsNullOrWhiteSpace(txtRepaymentTerm.Text))
                    {
                        MessageBox.Show("Please enter values for all credit details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validate numeric input
                    if (!float.TryParse(txtLoanAmount.Text, out float loanAmount) ||
                        !float.TryParse(txtInterestRate.Text, out float interestRate) ||
                        !int.TryParse(txtRepaymentTerm.Text, out int repaymentTerm))
                    {
                        MessageBox.Show("Please enter valid numeric values for loan amount, interest rate, and repayment term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validate numeric ranges
                    if (loanAmount <= 0 || interestRate <= 0 || repaymentTerm <= 0)
                    {
                        MessageBox.Show("Please enter positive values for loan amount, interest rate, and repayment term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Create a new credit instance
                    Credite credit = new Credite(loanAmount, interestRate, repaymentTerm);
                    credit.ActiveazaCredit(); // Set the active status

                    // Check if ListaCredite is null
                    if (newClient.ListaCredite == null)
                    {
                        newClient.ListaCredite = new List<Credite>(); // Initialize ListaCredite if null
                    }

                    // Add the credit to the client's credit list
                    newClient.ListaCredite.Add(credit);

                    // Optionally, you can notify the user that the credit has been added
                    MessageBox.Show("Credit added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numeric values for loan amount, interest rate, and repayment term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveCredit_Click(object sender, EventArgs e)
        {
            // Add your code here to handle the Save Credit button click event
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Not used, can be removed if not needed
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Not used, can be removed if not needed
        }
    }
}
