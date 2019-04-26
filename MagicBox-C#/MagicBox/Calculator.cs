using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result;


        public Calculator()
        {
            InitializeComponent();
        }

        private void dig1(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        
        private void dig2(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void dig3(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void dig4(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void dig5(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void dig6(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void dig7(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void dig8(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void dig9(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void dig0(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

       

        private void multiplOper(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            this.textBox1.Text += operation;
            input = string.Empty;
        }

        private void divOper(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            this.textBox1.Text += operation;
            input = string.Empty;

        }

        private void plusOper(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            this.textBox1.Text += operation;
            input = string.Empty;
        }


        private void minusOper(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            this.textBox1.Text += operation;
            input = string.Empty;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void equalsOper(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
                this.input = string.Empty;

            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
                this.input = string.Empty;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
                this.input = string.Empty;
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                    this.input = string.Empty;
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                    this.input = string.Empty;
                }

            }
        }


        private void cleanDisp(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }


        private void decimPoint(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Bitmap bitmap2 = new Bitmap(WindowsFormsApplication1.Properties.Resources.math_symbols_2900902); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            this.BackgroundImage = bitmap2;

            {
                textBox1.Text = "Operations with 2 digits only...\nAlways flush your result...".Replace("\n", Environment.NewLine);

            }


        }


    }
}
