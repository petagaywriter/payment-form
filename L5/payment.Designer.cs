namespace L5
{
    partial class payment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBillCustomer = new System.Windows.Forms.RadioButton();
            this.rdbCreditCard = new System.Windows.Forms.RadioButton();
            this.lblCreditCardType = new System.Windows.Forms.Label();
            this.lstCreditCardType = new System.Windows.Forms.ListBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.ckbDefault = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBillCustomer);
            this.groupBox1.Controls.Add(this.rdbCreditCard);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // rdbBillCustomer
            // 
            this.rdbBillCustomer.AutoSize = true;
            this.rdbBillCustomer.Location = new System.Drawing.Point(288, 20);
            this.rdbBillCustomer.Name = "rdbBillCustomer";
            this.rdbBillCustomer.Size = new System.Drawing.Size(85, 17);
            this.rdbBillCustomer.TabIndex = 1;
            this.rdbBillCustomer.TabStop = true;
            this.rdbBillCustomer.Text = "Bill Customer";
            this.rdbBillCustomer.UseVisualStyleBackColor = true;
            this.rdbBillCustomer.CheckedChanged += new System.EventHandler(this.rdbBillCustomer_CheckedChanged);
            // 
            // rdbCreditCard
            // 
            this.rdbCreditCard.AutoSize = true;
            this.rdbCreditCard.Checked = true;
            this.rdbCreditCard.Location = new System.Drawing.Point(47, 20);
            this.rdbCreditCard.Name = "rdbCreditCard";
            this.rdbCreditCard.Size = new System.Drawing.Size(77, 17);
            this.rdbCreditCard.TabIndex = 0;
            this.rdbCreditCard.TabStop = true;
            this.rdbCreditCard.Text = "Credit Card";
            this.rdbCreditCard.UseVisualStyleBackColor = true;
            // 
            // lblCreditCardType
            // 
            this.lblCreditCardType.AutoSize = true;
            this.lblCreditCardType.Location = new System.Drawing.Point(26, 106);
            this.lblCreditCardType.Name = "lblCreditCardType";
            this.lblCreditCardType.Size = new System.Drawing.Size(86, 13);
            this.lblCreditCardType.TabIndex = 2;
            this.lblCreditCardType.Text = "Credit Card Type";
            // 
            // lstCreditCardType
            // 
            this.lstCreditCardType.FormattingEnabled = true;
            this.lstCreditCardType.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "American Express",
            "Discover"});
            this.lstCreditCardType.Location = new System.Drawing.Point(198, 106);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.Size = new System.Drawing.Size(243, 69);
            this.lstCreditCardType.TabIndex = 3;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(26, 204);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(69, 13);
            this.lblCardNumber.TabIndex = 4;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(28, 275);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(79, 13);
            this.lblExpirationDate.TabIndex = 6;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January ",
            "February ",
            "March",
            "April",
            "May ",
            "June ",
            "July ",
            "August",
            "September",
            "October",
            "November ",
            "December "});
            this.cmbMonth.Location = new System.Drawing.Point(198, 267);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(107, 21);
            this.cmbMonth.TabIndex = 7;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cmbYear.Location = new System.Drawing.Point(334, 267);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(107, 21);
            this.cmbYear.TabIndex = 8;
            // 
            // ckbDefault
            // 
            this.ckbDefault.AutoSize = true;
            this.ckbDefault.Location = new System.Drawing.Point(29, 316);
            this.ckbDefault.Name = "ckbDefault";
            this.ckbDefault.Size = new System.Drawing.Size(158, 17);
            this.ckbDefault.TabIndex = 9;
            this.ckbDefault.Text = "Set as default billing method";
            this.ckbDefault.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(198, 343);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 26);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(341, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 26);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(198, 204);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(243, 20);
            this.txtCreditCard.TabIndex = 12;
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 404);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ckbDefault);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lstCreditCardType);
            this.Controls.Add(this.lblCreditCardType);
            this.Controls.Add(this.groupBox1);
            this.Name = "payment";
            this.Text = "Payment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbBillCustomer;
        private System.Windows.Forms.RadioButton rdbCreditCard;
        private System.Windows.Forms.Label lblCreditCardType;
        private System.Windows.Forms.ListBox lstCreditCardType;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.CheckBox ckbDefault;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCreditCard;
    }
}