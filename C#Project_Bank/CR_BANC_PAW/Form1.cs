using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CR_BANC_PAW
{
    public partial class Form1 : Form
    {
        private List<Control> addClientControls;
        private List<Clienti> lstClienti = new List<Clienti>();
        private ErrorProvider errorProvider1 = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();
            addClientControls = new List<Control>
            {
                // Add the actual controls you want to manage visibility for
                // e.g., textBox1, textBox2, etc.
            };

            foreach (Control control in addClientControls)
            {
                control.Visible = false;
            }

            chartCredits.Series.Clear();
            chartCredits.Series.Add("CreditSum");
            chartCredits.Series["CreditSum"].ChartType = SeriesChartType.Column;
            chartCredits.ChartAreas[0].AxisX.Title = "Client ID";
            chartCredits.ChartAreas[0].AxisY.Title = "Total Credit Amount";

            // Add data to the chart
            UpdateChart();

            textBox2.Text += "Pentru a vizualiza creditele, faceti dublu click pe un client!   \n";
            textBox2.Text += "\nPentru a reordona clientii in lista, utilizati drag and drop!\n";

        }

        private void chkMaritalStatus_CheckedChanged(object sender, EventArgs e)
        {
            // Add specific functionality here if needed
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save button functionality here
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewClients.ItemDrag += new ItemDragEventHandler(listViewClients_ItemDrag);
            listViewClients.DragEnter += new DragEventHandler(listViewClients_DragEnter);
            listViewClients.DragDrop += new DragEventHandler(listViewClients_DragDrop);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // File menu click functionality here
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Text changed functionality here
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upsert upsert = new Upsert();
            DialogResult result = upsert.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    Clienti client = new Clienti
                    {
                        Nume = upsert.txtName.Text,
                        Email = upsert.txtEmail.Text,
                        Telefon = upsert.txtPhone.Text,
                        Adresa = upsert.txtAddress.Text,
                        Venit = float.Parse(upsert.txtIncome.Text),
                        StareCivila = upsert.chkMarried.Checked
                    };

                    // Open CreditForm to add credit details
                    CreditForm creditForm = new CreditForm(client);
                    DialogResult creditResult = creditForm.ShowDialog();

                    if (creditResult == DialogResult.OK)
                    {
                        try
                        {
                            Credite credit = new Credite
                            {
                                SumaImprumutata = float.Parse(creditForm.txtLoanAmount.Text),
                                Dobanda = float.Parse(creditForm.txtInterestRate.Text),
                                TermenRambursare = int.Parse(creditForm.txtRepaymentTerm.Text),
                                EsteActiv = creditForm.chkActive.Checked
                            };

                            client.AdaugaCredit(credit); // Assuming you have a method to add credit to the client
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Invalid credit input format: " + ex.Message);
                            return;
                        }
                    }

                    lstClienti.Add(client);

                    ListViewItem itm = new ListViewItem(client.ID.ToString());
                    itm.SubItems.Add(client.Nume);
                    itm.SubItems.Add(client.Email);
                    itm.SubItems.Add(client.Telefon);
                    itm.SubItems.Add(client.Adresa);
                    itm.SubItems.Add(client.Venit.ToString());
                    itm.SubItems.Add(client.StareCivila ? "Married" : "Single");
                    itm.SubItems.Add(client.CalculeazaSumaTotalaCredite().ToString());

                    // Assuming you have a ListView control named listViewClients
                    listViewClients.Items.Add(itm);

                    // Update the chart with the new data
                    UpdateChart();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Invalid input format: " + ex.Message);
                }
            }
        }

        private void updateClientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewClients.SelectedItems[0];
                int clientId = int.Parse(selectedItem.Text);
                Clienti client = lstClienti.First(c => c.ID == clientId);

                Upsert upsert = new Upsert
                {
                    txtName = { Text = client.Nume },
                    txtEmail = { Text = client.Email },
                    txtPhone = { Text = client.Telefon },
                    txtAddress = { Text = client.Adresa },
                    txtIncome = { Text = client.Venit.ToString() },
                    chkMarried = { Checked = client.StareCivila }
                };

                DialogResult result = upsert.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        client.Nume = upsert.txtName.Text;
                        client.Email = upsert.txtEmail.Text;
                        client.Telefon = upsert.txtPhone.Text;
                        client.Adresa = upsert.txtAddress.Text;
                        client.Venit = float.Parse(upsert.txtIncome.Text);
                        client.StareCivila = upsert.chkMarried.Checked;

                        selectedItem.SubItems[1].Text = client.Nume;
                        selectedItem.SubItems[2].Text = client.Email;
                        selectedItem.SubItems[3].Text = client.Telefon;
                        selectedItem.SubItems[4].Text = client.Adresa;
                        selectedItem.SubItems[5].Text = client.Venit.ToString();
                        selectedItem.SubItems[6].Text = client.StareCivila ? "Married" : "Single";
                        selectedItem.SubItems[7].Text = client.CalculeazaSumaTotalaCredite().ToString();

                        // Update the chart with the new data
                        UpdateChart();
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Invalid input format: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a client to update.");
            }
        }

        private void removeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewClients.SelectedItems[0];
                int clientId = int.Parse(selectedItem.Text);
                Clienti client = lstClienti.First(c => c.ID == clientId);

                lstClienti.Remove(client);
                listViewClients.Items.Remove(selectedItem);

                // Update the chart with the new data
                UpdateChart();
            }
            else
            {
                MessageBox.Show("Please select a client to delete.");
            }
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewClients_DoubleClick(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewClients.SelectedItems[0];
                int clientId = int.Parse(selectedItem.Text);
                Clienti client = lstClienti.First(c => c.ID == clientId);

                ClientCreditsForm clientCreditsForm = new ClientCreditsForm(client);
                clientCreditsForm.ShowDialog();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the file path to save the data
            string filePath = "clienti_credite_data.bin";

            try
            {
                // Create a BinaryFormatter object for serialization
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    //  and write the list of clients
                    formatter.Serialize(stream, lstClienti);
                }

                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = "clienti_credite_data.bin";

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                if (File.Exists(filePath))
                {
                    using (FileStream stream = new FileStream(filePath, FileMode.Open))
                    {
                        lstClienti = (List<Clienti>)formatter.Deserialize(stream);
                    }

                    MessageBox.Show("Data restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the ListView and the chart with the restored data
                    RefreshListView();
                    UpdateChart();
                }
                else
                {
                    MessageBox.Show("No data file found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while restoring data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void exiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            int yPos = 100;
            foreach (Clienti client in lstClienti)
            {
                string clientInfo = $"ID: {client.ID}, Name: {client.Nume}, Total Credit: {client.CalculeazaSumaTotalaCredite()}";
                e.Graphics.DrawString(clientInfo, new Font("Arial", 12), Brushes.Black, new PointF(100, yPos));
                yPos += 30;
            }
        }

        private void UpdateChart()
        {
            chartCredits.Series["CreditSum"].Points.Clear();

            foreach (Clienti client in lstClienti)
            {
                float totalCredit = client.CalculeazaSumaTotalaCredite();
                chartCredits.Series["CreditSum"].Points.AddXY(client.ID, totalCredit);
            }
        }

        private void RefreshListView()
        {
            listViewClients.Items.Clear();
            foreach (Clienti client in lstClienti)
            {
                ListViewItem itm = new ListViewItem(client.ID.ToString());
                itm.SubItems.Add(client.Nume);
                itm.SubItems.Add(client.Email);
                itm.SubItems.Add(client.Telefon);
                itm.SubItems.Add(client.Adresa);
                itm.SubItems.Add(client.Venit.ToString());
                itm.SubItems.Add(client.StareCivila ? "Married" : "Single");
                itm.SubItems.Add(client.CalculeazaSumaTotalaCredite().ToString());

                listViewClients.Items.Add(itm);
            }
        }

    

        private void listViewClients_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewClients_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listViewClients_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                Point cp = listViewClients.PointToClient(new Point(e.X, e.Y));
                ListViewItem dragToItem = listViewClients.GetItemAt(cp.X, cp.Y);
                if (dragToItem == null)
                {
                    return;
                }

                ListViewItem dragItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                int dragIndex = dragItem.Index;
                int dropIndex = dragToItem.Index;

                // Remove the item and reinsert it at the new location
                listViewClients.Items.RemoveAt(dragIndex);
                listViewClients.Items.Insert(dropIndex, dragItem);
            }
        }
    }
}
