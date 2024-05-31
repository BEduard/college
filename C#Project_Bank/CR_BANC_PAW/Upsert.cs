using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CR_BANC_PAW
{
    public partial class Upsert : Form
    {
        // Property to indicate whether a new client was added
        public bool ClientAdded = false;

        // Property to store the newly created client
        internal Clienti NewClient = new Clienti();

        public Upsert()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input before saving
            if (ValidateInput())
            {
                // Create a new client object with the entered details
                string name = txtName.Text;
                string email = txtEmail.Text;
                bool maritalStatus = chkMarried.Checked;
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                float income = float.Parse(txtIncome.Text);

                // Create the new client
                NewClient = new Clienti(name, email, maritalStatus, address, phone, income);
                 CreditForm form3 = new CreditForm(NewClient);
                 form3.SetClientInfo(name, NewClient.ID);
                 form3.ShowDialog();
             
              

                // Close the form
                Close();
            }
        }

        // Method to validate input
        public bool ValidateInput()
        {
            // Check if name field is empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if email field is empty
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter an email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if email format is valid
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if address field is empty
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter an address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if phone field is empty
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter a phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if income field is empty
            if (string.IsNullOrWhiteSpace(txtIncome.Text))
            {
                MessageBox.Show("Please enter the income.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if income value is a valid float
            if (!float.TryParse(txtIncome.Text, out _))
            {
                MessageBox.Show("Please enter a valid numerical value for income.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // All input is valid
            return true;
        }

        // Method to validate email format
        private bool IsValidEmail(string email)
        {
            // Implement your email validation logic here
            // You can use regular expressions or other methods to validate email format
            // For simplicity, this example checks if email contains "@" and "."
            return email.Contains("@") && email.Contains(".");
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
