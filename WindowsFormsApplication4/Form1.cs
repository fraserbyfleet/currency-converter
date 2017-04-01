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
        public string userinput;
        public double userinputvalue;
        public string output = "empty";

        public Form1()
        {
            InitializeComponent();
        }

        

        

        private void CURRENCYFROM_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DISPLAYCONVERSION_TextChanged(object sender, EventArgs e)
        {

        }

        private void CONVERT_Click(object sender, EventArgs e)
        {
            CURRENCYFROM.Text = userinput;
            output = userinputvalue.ToString();
            DISPLAYCONVERSION.Text = output;
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            userinput = null;
            userinputvalue = 0;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //usd2
        }

        private void USERINPUT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            userinput = USERINPUT.Text;
            double.TryParse(userinput, out userinputvalue);
        }







        private void NZD1_CheckedChanged(object sender, EventArgs e)
        {
            userinputvalue = userinputvalue / 1.36;
        }

        private void EUR1_CheckedChanged(object sender, EventArgs e)
        {
            userinputvalue = userinputvalue / .95;
        }

        private void GBP1_CheckedChanged(object sender, EventArgs e)
        {
            userinputvalue = userinputvalue / .68;
        }

        private void AUD1_CheckedChanged(object sender, EventArgs e)
        {
            userinputvalue = userinputvalue / 1.31;
        }

        private void CAD1_CheckedChanged(object sender, EventArgs e)
        {
            userinputvalue = userinputvalue / 1.28;
        }

        private void USD1_CheckedChanged(object sender, EventArgs e)
        {

        }







        private void NZD2_CheckedChanged(object sender, EventArgs e)
        {
            userinputvalue = userinputvalue * 1.36;
        }

        private void EUR2_CheckedChanged(object sender, EventArgs e)
        {
            userinputvalue = userinputvalue * .95;
        }

        private void GBP2_CheckedChanged(object sender, EventArgs e)
        {
            userinputvalue = userinputvalue * .68;
        }

        private void AUD2_CheckedChanged(object sender, EventArgs e)
        {
            userinputvalue = userinputvalue * 1.31;
        }

        private void CAD2_CheckedChanged(object sender, EventArgs e)
        {
            userinputvalue = userinputvalue * 1.28;
        }
    }
}
