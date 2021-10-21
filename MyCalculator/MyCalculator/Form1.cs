using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        string leftOperand;
        string rightOperand;
        char operator_;

        private bool lastPressedKeyIsAnOperator;
        private bool clearCalculationOnNextNumberPress;

        public Form1()
        {
            InitializeComponent();
            ClearCalculation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            statusLb.Text = "";
            debugStringLb.Visible = false;
        }

        void Calculate(bool triggeredByEquals)
        {
            if(leftOperand == "" && rightOperand != "")
            {
                // NOTE(bora): Calculation just after first term entered
                if(!triggeredByEquals)
                {
                    leftOperand = rightOperand;
                    rightOperand = "";
                }
            }
            else if(leftOperand != "" && rightOperand != "")
            {
                // NOTE(bora): Calculation with both terms present
                // (left term may be the cumulative result of previous calculations)
                try
                {
                    // NOTE(bora): CultureInfo is provided to make Parse method behave consistently
                    // across locales. (Decimal place is comma instead of period in Turkish locale.)
                    decimal left = decimal.Parse(leftOperand, CultureInfo.InvariantCulture.NumberFormat);
                    decimal right = decimal.Parse(rightOperand, CultureInfo.InvariantCulture.NumberFormat);

                    decimal result = 0;

                    switch(operator_)
                    {
                        case '+': { result = left + right; } break;
                        case '-': { result = left - right; } break;
                        case '*': { result = left * right; } break;
                        case '/': { result = left / right; } break;
                    }

                    if(triggeredByEquals)
                    {
                        leftOperand = "";
                        rightOperand = result.ToString(CultureInfo.InvariantCulture);

                        panelTx.Text = result.ToString();
                        clearCalculationOnNextNumberPress = true;
                    }
                    else
                    {
                        leftOperand = result.ToString(CultureInfo.InvariantCulture);
                        rightOperand = "";

                        panelTx.Text = result.ToString();
                    }
                }
                catch(FormatException)
                {
                    statusLb.Text = "ERROR";
                }
            }
            else if(leftOperand != "" && rightOperand == "")
            {
                // NOTE(bora): Something must have gone wrong, this is unlikely
                statusLb.Text = "ERROR";
            }
        }

        void NumberPressed(char number)
        {
            if(char.IsDigit(number) || number == '.')
            {
                if(clearCalculationOnNextNumberPress)
                {
                    ClearCalculation();
                    clearCalculationOnNextNumberPress = false;
                }

                if(lastPressedKeyIsAnOperator)
                {
                    panelTx.Clear();
                    lastPressedKeyIsAnOperator = false;
                }

                if(rightOperand == "" && number != '.')
                {
                    rightOperand = number.ToString();
                    panelTx.Text = number.ToString();
                }
                else
                {
                    rightOperand += number;
                    panelTx.Text += number;
                }
            }
        }

        void OperatorPressed(char op)
        {
            if( op == '+' || op == '-' ||
                op == '*' || op == '/')
            {

                Calculate(false);

                operator_ = op;
                panelTx.Text = $"{leftOperand} {op}";
                clearCalculationOnNextNumberPress = false;
                lastPressedKeyIsAnOperator = true;
            }
        }

        private void ClearCalculation()
        {
            leftOperand = "";
            rightOperand = "";
            operator_ = '\0';

            panelTx.Text = "0";
        }

        private void clearBt_Click(object sender, EventArgs e)
        {
            ClearCalculation();
        }

        private void panelTx_TextChanged(object sender, EventArgs e)
        {
            statusLb.Text = "";
        }

        private void equalsBt_Click(object sender, EventArgs e)
        {
            Calculate(true);
        }

        private void addBt_Click(object sender, EventArgs e) { OperatorPressed('+'); }
        private void subtractBt_Click(object sender, EventArgs e) { OperatorPressed('-'); }
        private void multiplyBt_Click(object sender, EventArgs e) { OperatorPressed('*'); }
        private void divideBt_Click(object sender, EventArgs e) { OperatorPressed('/'); }

        private void decimalBt_Click(object sender, EventArgs e) { NumberPressed('.'); }
        private void num0Bt_Click(object sender, EventArgs e) { NumberPressed('0'); }
        private void num1Bt_Click(object sender, EventArgs e) { NumberPressed('1'); }
        private void num2Bt_Click(object sender, EventArgs e) { NumberPressed('2'); }
        private void num3Bt_Click(object sender, EventArgs e) { NumberPressed('3'); }
        private void num4Bt_Click(object sender, EventArgs e) { NumberPressed('4'); }
        private void num5Bt_Click(object sender, EventArgs e) { NumberPressed('5'); }
        private void num6Bt_Click(object sender, EventArgs e) { NumberPressed('6'); }
        private void num7Bt_Click(object sender, EventArgs e) { NumberPressed('7'); }
        private void num8Bt_Click(object sender, EventArgs e) { NumberPressed('8'); }
        private void num9Bt_Click(object sender, EventArgs e) { NumberPressed('9'); }

        private void timer1_Tick(object sender, EventArgs e)
        {
            debugStringLb.Text = $"leftOperand={leftOperand}; rightOperand={rightOperand}; operator_={operator_}";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case '=': { Calculate(true); } break;
                case '+': { OperatorPressed('+'); } break;
                case '-': { OperatorPressed('-'); } break;
                case '*': { OperatorPressed('*'); } break;
                case '/': { OperatorPressed('/'); } break;

                case ',':
                case '.': { NumberPressed('.'); } break;
                case '0': { NumberPressed('0'); } break;
                case '1': { NumberPressed('1'); } break;
                case '2': { NumberPressed('2'); } break;
                case '3': { NumberPressed('3'); } break;
                case '4': { NumberPressed('4'); } break;
                case '5': { NumberPressed('5'); } break;
                case '6': { NumberPressed('6'); } break;
                case '7': { NumberPressed('7'); } break;
                case '8': { NumberPressed('8'); } break;
                case '9': { NumberPressed('9'); } break;
            }
        }
    }
}
