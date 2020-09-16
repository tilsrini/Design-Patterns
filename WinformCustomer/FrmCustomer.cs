﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiddleLayer;
using FactoryCustomer;

namespace WinformCustomer
{
    public partial class FrmCustomer : Form
    {

        private CustomerBase cust = null;

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void SetCustomer()
        {
            cust.CustomerName = txtCustomerName.Text;
            cust.PhoneNumber = txtPhoneNumber.Text;
            cust.BillDate = Convert.ToDateTime(txtBillDate.Text);
            cust.BillAmount = Convert.ToDecimal(txtBillAmount.Text);
            cust.Address = txtAddress.Text;

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                SetCustomer();
                cust.Validate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cust = Factory.Create(cmbCustomerType.Text);
        }
    }
}
