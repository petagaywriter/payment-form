namespace L5
{
    partial class main
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.btnSelectPayment = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPaymentInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(27, 50);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name ";
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(189, 50);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(166, 21);
            this.cmbCustomerName.TabIndex = 1;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(26, 112);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPaymentMethod.Size = new System.Drawing.Size(86, 13);
            this.lblPaymentMethod.TabIndex = 2;
            this.lblPaymentMethod.Text = "Payment method";
            // 
            // btnSelectPayment
            // 
            this.btnSelectPayment.Location = new System.Drawing.Point(286, 169);
            this.btnSelectPayment.Name = "btnSelectPayment";
            this.btnSelectPayment.Size = new System.Drawing.Size(147, 23);
            this.btnSelectPayment.TabIndex = 4;
            this.btnSelectPayment.Text = "Select Payment";
            this.btnSelectPayment.UseVisualStyleBackColor = true;
            this.btnSelectPayment.Click += new System.EventHandler(this.btnSelectPayment_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(94, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 25);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(286, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 25);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPaymentInfo
            // 
            this.txtPaymentInfo.Location = new System.Drawing.Point(26, 169);
            this.txtPaymentInfo.Multiline = true;
            this.txtPaymentInfo.Name = "txtPaymentInfo";
            this.txtPaymentInfo.ReadOnly = true;
            this.txtPaymentInfo.Size = new System.Drawing.Size(234, 120);
            this.txtPaymentInfo.TabIndex = 7;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 404);
            this.Controls.Add(this.txtPaymentInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectPayment);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.cmbCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "main";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Button btnSelectPayment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPaymentInfo;
    }
}

