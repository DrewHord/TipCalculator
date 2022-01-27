using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator {
    public partial class TipCalculatorForm : Form {
        public TipCalculatorForm() {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e) {
            Close(); 
        }

        private void btnCalculateTIp_Click(object sender, EventArgs e) {
            var billTotal = Convert.ToDecimal(txtTotal.Text);

            var tipPercent = 0.2m;

            var TipAmount = billTotal * tipPercent;

            txtTipPercent.Text = tipPercent.ToString("p0");
            txtTipAmount.Text= TipAmount.ToString("c");
            txtTotal.Focus(); 

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
