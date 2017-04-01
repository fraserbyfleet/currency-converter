using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public string strUserInput;
        public decimal originalAmount;

        public Form1()
        {
            InitializeComponent();
        }

        protected void log(String text)
        {
            System.Diagnostics.Debug.WriteLine(text);
        }
        
        public decimal getExchangeRateForCurrencyCode(string strCurrencyCode)
        {
            switch (strCurrencyCode)
            {
                case "NZD": return 1.36m;
                case "AUD": return 1.31m;
                case "EUR": return 0.95m;
                case "CAD": return 1.28m;
                case "GBP": return 0.68m;
                case "USD": return 1m;
                default: return 1;
            }
        }

        private void CURRENCYFROM_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DISPLAYCONVERSION_TextChanged(object sender, EventArgs e)
        {

        }

        private void CONVERT_Click(object sender, EventArgs e)
        {
            // Get the value of the amount to convert and store it in strUserInput
            strUserInput = USERINPUT.Text;
            log("The value of strUserInput is " + strUserInput);

            // Display a notice if the value of strUserInput is empty or otherwise invalid
            if (!Decimal.TryParse(strUserInput, out originalAmount))
            {
                MessageBox.Show("The value specified is empty or invalid");
                return;
            }

            // TODO: Ensure that valid currency to/from is specified

            /**
             * Calculate the appropriate exchange rate.
             * We will perform 2 exchanges. First convert from originating currency to USD then calculate from USD to desired currency. 
             **/ 
            decimal firstRate = getExchangeRateForCurrencyCode(cbCurrencyFrom.Text);
            decimal amountOfUSD = originalAmount / firstRate;
            decimal secondRate = getExchangeRateForCurrencyCode(cbCurrencyTo.Text);
            decimal amountOfTargetCurrency = amountOfUSD * secondRate;


            CURRENCYFROM.Text = strUserInput;
            DISPLAYCONVERSION.Text = amountOfTargetCurrency.ToString("C2");
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            strUserInput = null;
            originalAmount = 0;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //usd2
        }

        private void USERINPUT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            strUserInput = USERINPUT.Text;
        }

        private void amount_Click(object sender, EventArgs e)
        {

        }
    }
}
