using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CR_BANC_PAW
{
    public partial class ClientCreditsForm : Form
    {
        private Clienti selectedClient;

        public ClientCreditsForm(Clienti client)
        {
            InitializeComponent();
            selectedClient = client;
            textBoxClientInfo.Text = $"Client: {client.Nume}";
            InitializeListView();
        }

        private void InitializeListView()
        {

            listViewCredits.Items.Clear();
            foreach (var credit in selectedClient.ListaCredite)
            {
                ListViewItem item = new ListViewItem(credit.ID.ToString());
                item.SubItems.Add(credit.SumaImprumutata.ToString());
                item.SubItems.Add(credit.Dobanda.ToString());
                item.SubItems.Add(credit.TermenRambursare.ToString());
                item.SubItems.Add(credit.EsteActiv.ToString());
                listViewCredits.Items.Add(item);
            } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
        }

        private void deleteCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewCredits.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCredits.SelectedItems[0];
                int creditId = int.Parse(selectedItem.SubItems[0].Text);
                Credite credit = selectedClient.ListaCredite.First(c => c.ID == creditId);
                selectedClient.StergeCredit(credit);

                listViewCredits.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Please select a credit to delete.");
            }
        }

        private void addCreditToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            CreditForm creditForm = new CreditForm(selectedClient);
            DialogResult result = creditForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Credite credit = new Credite
                {
                    SumaImprumutata = float.Parse(creditForm.txtLoanAmount.Text),
                    Dobanda = float.Parse(creditForm.txtInterestRate.Text),
                    TermenRambursare = int.Parse(creditForm.txtRepaymentTerm.Text),
                    EsteActiv = creditForm.chkActive.Checked
                };

                selectedClient.AdaugaCredit(credit);

                ListViewItem item = new ListViewItem(credit.ID.ToString());
                item.SubItems.Add(credit.SumaImprumutata.ToString());
                item.SubItems.Add(credit.Dobanda.ToString());
                item.SubItems.Add(credit.TermenRambursare.ToString());
                item.SubItems.Add(credit.EsteActiv.ToString());
                listViewCredits.Items.Add(item);
            }
        }

        private void deleteCreditToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listViewCredits.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCredits.SelectedItems[0];
                int creditId = int.Parse(selectedItem.SubItems[0].Text);
                Credite credit = selectedClient.ListaCredite.First(c => c.ID == creditId);
                selectedClient.StergeCredit(credit);

                listViewCredits.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Please select a credit to delete.");
            }
        }
    }
}