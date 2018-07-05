using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L5
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

            // open the input file
            using (var reader = File.OpenText("CustomerName.txt"))
            {
                // read the entire text file
                var contents = reader.ReadToEnd();
                // split the string by line breaks and add them to the ComboBox
                cmbCustomerName.Items.AddRange(contents.Split(new String[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectPayment_Click(object sender, EventArgs e)
        {
            if (cmbCustomerName.SelectedItem != null)
            {
                // instantiate payment form passing the ShowPaymentInfo method
                var paymentForm = new payment(ShowPaymentInfo);
                var result = paymentForm.ShowDialog(); // show the payment form

                if (result == DialogResult.OK && !String.IsNullOrWhiteSpace(txtPaymentInfo.Text))
                {
                    // if the payment form was successful then enable save button
                    btnSave.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No customer was selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPaymentInfo(String paymentInfo)
        {
            txtPaymentInfo.Text = paymentInfo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // create the output file
            using (var writer = new StreamWriter(File.OpenWrite("PaymentData.txt")))
            {
                writer.WriteLine("Customer Name: {0}", cmbCustomerName.SelectedItem);
                writer.WriteLine();
                writer.WriteLine(txtPaymentInfo.Text);
            }

            // reset form
            cmbCustomerName.SelectedItem = null;
            txtPaymentInfo.Text = null;
            btnSave.Enabled = false;
        }
    }
}
