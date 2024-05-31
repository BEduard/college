namespace CR_BANC_PAW
{
    partial class ClientCreditsForm
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
            this.textBoxClientInfo = new System.Windows.Forms.TextBox();
            this.listViewCredits = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxClientInfo
            // 
            this.textBoxClientInfo.Location = new System.Drawing.Point(589, 12);
            this.textBoxClientInfo.Multiline = true;
            this.textBoxClientInfo.Name = "textBoxClientInfo";
            this.textBoxClientInfo.Size = new System.Drawing.Size(474, 40);
            this.textBoxClientInfo.TabIndex = 1;
            this.textBoxClientInfo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listViewCredits
            // 
            this.listViewCredits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewCredits.HideSelection = false;
            this.listViewCredits.Location = new System.Drawing.Point(12, 90);
            this.listViewCredits.Name = "listViewCredits";
            this.listViewCredits.Size = new System.Drawing.Size(1549, 465);
            this.listViewCredits.TabIndex = 2;
            this.listViewCredits.UseCompatibleStateImageBehavior = false;
            this.listViewCredits.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CreditID :";
            this.columnHeader1.Width = 515;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Suma";
            this.columnHeader2.Width = 282;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dobanda";
            this.columnHeader3.Width = 372;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Termen (luni)";
            this.columnHeader4.Width = 186;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Activ?";
            this.columnHeader5.Width = 223;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCreditToolStripMenuItem,
            this.deleteCreditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1645, 42);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            //this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // addCreditToolStripMenuItem
            // 
            this.addCreditToolStripMenuItem.Name = "addCreditToolStripMenuItem";
            this.addCreditToolStripMenuItem.Size = new System.Drawing.Size(144, 38);
            this.addCreditToolStripMenuItem.Text = "Add credit";
            this.addCreditToolStripMenuItem.Click += new System.EventHandler(this.addCreditToolStripMenuItem_Click_1);
            // 
            // deleteCreditToolStripMenuItem
            // 
            this.deleteCreditToolStripMenuItem.Name = "deleteCreditToolStripMenuItem";
            this.deleteCreditToolStripMenuItem.Size = new System.Drawing.Size(175, 38);
            this.deleteCreditToolStripMenuItem.Text = "Delete Credit";
            this.deleteCreditToolStripMenuItem.Click += new System.EventHandler(this.deleteCreditToolStripMenuItem_Click_1);
            // 
            // ClientCreditsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 610);
            this.Controls.Add(this.listViewCredits);
            this.Controls.Add(this.textBoxClientInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientCreditsForm";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxClientInfo;
        private System.Windows.Forms.ListView listViewCredits;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCreditToolStripMenuItem;
    }
}