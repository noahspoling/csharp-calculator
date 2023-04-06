using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS317_Project
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private int total = 0;
        private string target = "0";
        private char operation = ' ';
        
        private void plusButton_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                total = Int32.Parse(target);
                operation = '+';
                target = "0";
                outputBox.Text = target;
            }
            else {
                switch (operation)
                {
                    case '+':
                        total = total + Int32.Parse(target);
                        break;
                    case '-':
                        total = total - Int32.Parse(target);
                        break;
                    case '/':
                        total = total / Int32.Parse(target);
                        break;
                    case '*':
                        total = total * Int32.Parse(target);
                        break;
                }
                target = "0";
                outputBox.Text = target;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            total = 0;
            target = "0";
            outputBox.Text = target;
        }
        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (target.CompareTo("0") == 0)
            {
                target = "0";
            }
            else
            {
                target += "0";
            }
            outputBox.Text = target;
        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            if (target.CompareTo("0") == 0)
            {
                target = "0.";
            }
            else
            {
                target += ".";
            }
            outputBox.Text = target;
        }

        private void posNegButton_Click(object sender, EventArgs e)
        {
            if (target.Trim().StartsWith("-"))
            {
                target.Remove(0, 1);
            }
            else
            {
                target = "-" + target;
            }
            outputBox.Text = target;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (target.CompareTo("0") == 0)
            {
                target = "1";
            }
            else
            {
                target += "1";
            }
            outputBox.Text = target;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (target.CompareTo("0") == 0)
            {
                target = "2";
            }
            else
            {
                target += "2";
            }
            outputBox.Text = target;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (target.CompareTo("0") == 0)
            {
                target = "3";
            }
            else
            {
                target += "3";
            }
            outputBox.Text = target;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (target.CompareTo("0") == 0)
            {
                target = "4";
            }
            else
            {
                target += "4";
            }
            outputBox.Text = target;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (target.CompareTo("0") == 0)
            {
                target = "5";
            }
            else
            {
                target += "5";
            }
            outputBox.Text = target;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (target.CompareTo("0") == 0)
            {
                target = "6";
            }
            else
            {
                target += "6";
            }
            outputBox.Text = target;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (target.CompareTo("0") == 0)
            {
                target = "7";
            }
            else
            {
                target += "7";
            }
            outputBox.Text = target;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (target.CompareTo("0") == 0)
            {
                target = "8";
            }
            else
            {
                target += "8";
            }
            outputBox.Text = target;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (target.CompareTo("0") == 0)
            {
                target = "9";
            }
            else
            {
                target += "9";
            }
            outputBox.Text = target;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            {
                if (total == 0)
                {
                    total = Int32.Parse(target);
                    operation = '-';
                    target = "0";
                    outputBox.Text = target;
                }
                else
                {
                    switch (operation)
                    {
                        case '+':
                            total = total + Int32.Parse(target);
                            break;
                        case '-':
                            total = total - Int32.Parse(target);
                            break;
                        case '/':
                            total = total / Int32.Parse(target);
                            break;
                        case '*':
                            total = total * Int32.Parse(target);
                            break;
                    }
                    target = "0";
                    outputBox.Text = target;
                }
            }
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            {
                if (total == 0)
                {
                    total = Int32.Parse(target);
                    operation = '*';
                    target = "0";
                    outputBox.Text = target;
                }
                else
                {
                    switch (operation)
                    {
                        case '+':
                            total = total + Int32.Parse(target);
                            break;
                        case '-':
                            total = total - Int32.Parse(target);
                            break;
                        case '/':
                            total = total / Int32.Parse(target);
                            break;
                        case '*':
                            total = total * Int32.Parse(target);
                            break;
                    }
                    target = "0";
                    outputBox.Text = target;
                }
            }
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            {
                if (total == 0)
                {
                    total = Int32.Parse(target);
                    operation = '/';
                    target = "0";
                    outputBox.Text = target;
                }
                else
                {
                    switch (operation)
                    {
                        case '+':
                            total = total + Int32.Parse(target);
                            break;
                        case '-':
                            total = total - Int32.Parse(target);
                            break;
                        case '/':
                            total = total / Int32.Parse(target);
                            break;
                        case '*':
                            total = total * Int32.Parse(target);
                            break;
                    }
                    target = "0";
                    outputBox.Text = target;
                }
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case '+':
                    total = total + Int32.Parse(target);
                    break;
                case '-':
                    total = total - Int32.Parse(target);
                    break;
                case '/':
                    total = total / Int32.Parse(target);
                    break;
                case '*':
                    total = total * Int32.Parse(target);
                    break;
            }
            target = "0";
            outputBox.Text = total.ToString();
        }
    }
}
