using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double num = 0;
        double res = 0;
        bool flag = false;
        enum eOperation { add = 1, Sub = 2, Multi = 3, Div = 4 };
        eOperation operation; 


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        eOperation convertStringToOperation(string input)
        {
            switch (input)
            {
                case "+":
                    return eOperation.add;
                case "-":
                    return eOperation.Sub;
                case "÷":
                    return eOperation.Div;
                default:
                    return eOperation.Multi;
            }
        }

        bool isValidDenominator(double denominator)
        {
            return denominator != 0;
        }

        double safeDivision(double num, double num2) 
        {
            if (isValidDenominator(num2))
                return num / num2;
            else
                MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return 0;
        }

        double calculate(double num, eOperation operation)
        {
            double num2 = Convert.ToDouble(lblScreen.Text);
            switch (operation)
            {
                case eOperation.add:
                    return num + num2;
                case eOperation.Sub:
                    return num - num2;
                case eOperation.Div:
                    return safeDivision(num, num2);
                default:
                    return num * num2;
            }
        }

        private void readNumberToScreen(string number)
        {
            if (flag)
            {
                lblScreen.Text = number;
                flag = false;
            }
            else
                lblScreen.Text += number;
        }

        void showResult()
        {
            res = calculate(num, operation); 
            num = res;
            lblScreen.Text = res.ToString();
        }

        bool isValidNumber(string number)
        {
            return number != "";
        }

        void readOperation(string op) 
        {
            flag = true;
            if (isValidNumber(lblScreen.Text))
            {
                num = Convert.ToDouble(lblScreen.Text);
            }
            operation = convertStringToOperation(op); 
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            readNumberToScreen(btn0.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            readNumberToScreen(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            readNumberToScreen(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            readNumberToScreen(btn3.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            readOperation(btnAdd.Text); 
        }

        private void btnEquall_Click(object sender, EventArgs e)
        {
            showResult();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            readOperation(btnMul.Text); 
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            readOperation(btnDiv.Text); 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblScreen.Text = "";
             num = 0;
             res = 0;
             flag = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            readNumberToScreen(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            readNumberToScreen(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            readNumberToScreen(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            readNumberToScreen(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            readNumberToScreen(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            readNumberToScreen(btn9.Text);
        }
    }
}