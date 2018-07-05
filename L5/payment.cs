using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L5
{
    public partial class payment : Form
    {
        private Action<String> _callback;

        public payment(Action<String> callback)
        {
            InitializeComponent();
            _callback = callback;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String cardOrBill;
       
        private void btnOk_Click(object sender, EventArgs e)
        {
            bool valid = rdbBillCustomer.Checked ||
                (IsCreditCardValid() &&
                lstCreditCardType.SelectedItem != null &&
                cmbMonth.SelectedItem != null &&
                cmbYear.SelectedItem != null);

            if (valid)
            {
                var sb = new StringBuilder();

                if (rdbBillCustomer.Checked)
                {
                    sb.AppendLine("Customer will be billed later.");
                    sb.AppendLine();
                    sb.AppendFormat("Default billing: {0}", ckbDefault.Checked);
                }
                else
                {
                    sb.Append("Card type: ");
                    sb.AppendLine(lstCreditCardType.SelectedItem.ToString());
                    sb.Append("Card number: ");
                    sb.AppendLine(txtCreditCard.Text);
                    sb.Append("Expiration date: ");
                    sb.AppendFormat("{0}/", cmbMonth.SelectedItem.ToString().Trim());
                    sb.AppendLine(cmbYear.SelectedItem.ToString());
                    sb.AppendFormat("Default billing: {0}", ckbDefault.Checked);
                }
                
                _callback(sb.ToString());
                this.DialogResult = DialogResult.OK; // successful result
                this.Close();
            }
            else
            {
                MessageBox.Show("Credit Card Form is Invalid. Please Check Information.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbBillCustomer_CheckedChanged(object sender, EventArgs e)
        {
            lstCreditCardType.Enabled = !rdbBillCustomer.Checked;
            txtCreditCard.Enabled = !rdbBillCustomer.Checked;
            cmbMonth.Enabled = !rdbBillCustomer.Checked;
            cmbYear.Enabled = !rdbBillCustomer.Checked;
        }

        private bool IsCreditCardValid()
        {
            long num;

            if (txtCreditCard.Text != null && txtCreditCard.Text.Length == 16 && long.TryParse(txtCreditCard.Text, out num))
            {
                // if credit card number is present, has 16 digits and is a valid number
                return true;
            }

            return false;
        }

       
    }
}
