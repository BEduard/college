namespace CR_BANC_PAW
{
    partial class CreditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtRepaymentTerm = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnSaveCredit = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txtF3Name = new System.Windows.Forms.TextBox();
            this.txtF3ID = new System.Windows.Forms.TextBox();
            this.btnSaveCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interest Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repayment Term:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 490);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Active:";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(240, 278);
            this.txtLoanAmount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(254, 31);
            this.txtLoanAmount.TabIndex = 4;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(240, 355);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(254, 31);
            this.txtInterestRate.TabIndex = 5;
            // 
            // txtRepaymentTerm
            // 
            this.txtRepaymentTerm.Location = new System.Drawing.Point(240, 421);
            this.txtRepaymentTerm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtRepaymentTerm.Name = "txtRepaymentTerm";
            this.txtRepaymentTerm.Size = new System.Drawing.Size(254, 31);
            this.txtRepaymentTerm.TabIndex = 6;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(108, 490);
            this.chkActive.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(28, 27);
            this.chkActive.TabIndex = 7;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnSaveCredit
            // 
            this.btnSaveCredit.Location = new System.Drawing.Point(90, 578);
            this.btnSaveCredit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveCredit.Name = "btnSaveCredit";
            this.btnSaveCredit.Size = new System.Drawing.Size(200, 44);
            this.btnSaveCredit.TabIndex = 8;
            this.btnSaveCredit.Text = "Save Credit";
            this.btnSaveCredit.UseVisualStyleBackColor = true;
            this.btnSaveCredit.Click += new System.EventHandler(this.btnAddCredit_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(171, 15);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(329, 42);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "Credit Information";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(26, 145);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(135, 25);
            this.lblClientName.TabIndex = 10;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(370, 142);
            this.lblClientID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(99, 25);
            this.lblClientID.TabIndex = 11;
            this.lblClientID.Text = "Client ID:";
            // 
            // txtF3Name
            // 
            this.txtF3Name.Location = new System.Drawing.Point(171, 142);
            this.txtF3Name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF3Name.Name = "txtF3Name";
            this.txtF3Name.Size = new System.Drawing.Size(189, 31);
            this.txtF3Name.TabIndex = 12;
            this.txtF3Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtF3ID
            // 
            this.txtF3ID.Location = new System.Drawing.Point(479, 142);
            this.txtF3ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF3ID.Name = "txtF3ID";
            this.txtF3ID.Size = new System.Drawing.Size(177, 31);
            this.txtF3ID.TabIndex = 13;
            // 
            // btnSaveCancel
            // 
            this.btnSaveCancel.Location = new System.Drawing.Point(375, 578);
            this.btnSaveCancel.Name = "btnSaveCancel";
            this.btnSaveCancel.Size = new System.Drawing.Size(185, 44);
            this.btnSaveCancel.TabIndex = 14;
            this.btnSaveCancel.Text = " ";
            this.btnSaveCancel.UseVisualStyleBackColor = true;
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 732);
            this.Controls.Add(this.btnSaveCancel);
            this.Controls.Add(this.txtF3ID);
            this.Controls.Add(this.txtF3Name);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnSaveCredit);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtRepaymentTerm);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CreditForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHeader; // Added header label
        private System.Windows.Forms.Label lblClientName; // Added label for Client Name
        private System.Windows.Forms.Label lblClientID; // Added label for Client ID
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtLoanAmount;
        public System.Windows.Forms.TextBox txtInterestRate;
        public System.Windows.Forms.TextBox txtRepaymentTerm;
        public System.Windows.Forms.CheckBox chkActive;
        public System.Windows.Forms.Button btnSaveCredit;
        public System.Windows.Forms.TextBox txtF3Name;
        public System.Windows.Forms.TextBox txtF3ID;
        public System.Windows.Forms.Button btnSaveCancel;
    }
}
