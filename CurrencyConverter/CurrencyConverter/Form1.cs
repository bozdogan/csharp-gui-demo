using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        private float exchangeRate;
        private bool nonDigitEntered;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currencyInfoLb.Text = "";

            // NOTE(bora): This set to true in order to process key inputs even when
            // a child control has the focus.
            this.KeyPreview = true;

            ChangeSelectedCurrency("USD", "TRY");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"KeyUp code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}");

            switch(e.KeyCode)
            {
                case Keys.Escape: { this.Close(); } return;
                case Keys.Q: ChangeSelectedCurrency("USD", "TRY"); break;
                case Keys.A: ChangeSelectedCurrency("TRY", "USD"); break;
                case Keys.W: ChangeSelectedCurrency("EUR", "USD"); break;
                case Keys.S: ChangeSelectedCurrency("USD", "EUR"); break;
                case Keys.E: ChangeSelectedCurrency("EUR", "TRY"); break;
                case Keys.D: ChangeSelectedCurrency("TRY", "EUR"); break;
            }
        }

        private void convertBt_Click(object sender, EventArgs e)
        {
            DoConversion();
        }

        private void inputTx_TextChanged(object sender, EventArgs e)
        {
            DoConversion();
        }

        private void inputTx_KeyDown(object sender, KeyEventArgs e)
        {
            this.nonDigitEntered = false;

            if(!IsKeyCodeANumberKey(e.KeyCode) && e.KeyCode != Keys.Back 
                && e.KeyCode != Keys.OemPeriod)
            {
                this.nonDigitEntered = true;
            }

            // NOTE(bora): If shift key was pressed, it is not a number.
            if(Control.ModifierKeys == Keys.Shift)
            {
                this.nonDigitEntered = true;
            }
        }

        private void inputTx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(this.nonDigitEntered == true)
            {
                // NOTE(bora): This cancels the character input.
                e.Handled = true;
            }
        }

        private void DoConversion()
        {
            try
            { 
                resultTx.Text = (float.Parse(inputTx.Text) * exchangeRate).ToString();
            }
            catch(FormatException)
            {
                resultTx.Text = "---";
            }
        }

        private void ChangeSelectedCurrency(string currency1, string currency2)
        {
            string tableKey = $"{currency1}_{currency2}";
            this.exchangeRate = Currency.exchangeRates[tableKey];

            this.currency1SymLb.Text = Currency.symbols[currency1].ToString();
            this.currency2SymLb.Text = Currency.symbols[currency2].ToString();
            this.currencyInfoLb.Text = $"{Currency.longNames[currency1]}\nto\n{Currency.longNames[currency2]}";

            // NOTE(bora): Convert the price with new exchange rate.
            DoConversion();
        }

        private static bool IsKeyCodeANumberKey(Keys keyCode)
        {
            if(keyCode < Keys.D0 || keyCode > Keys.D9)  // NOTE(bora): Key code is outside of top number row
            {
                if(keyCode < Keys.NumPad0 || keyCode > Keys.NumPad9)  // NOTE(bora): Outside of numpad
                {
                    return false;
                }
            }
            
            return true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void currency2SymLb_Click(object sender, EventArgs e)
        {

        }

        private void currency1SymLb_Click(object sender, EventArgs e)
        {

        }

        private void currencyInfoLb_Click(object sender, EventArgs e)
        {

        }

        private void infoLb_Click(object sender, EventArgs e)
        {

        }

        private void resultTx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
