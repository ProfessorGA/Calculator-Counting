using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator___Counting
{
    public partial class Calculator : Form
    {
        double FirstNumber, SecondNumber;
        string Operation, Result;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            if(txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "1";
            }
            else
            {
                txtResult.Text = txtResult.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "2";
            }
            else
            {
                txtResult.Text = txtResult.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "3";
            }
            else
            {
                txtResult.Text = txtResult.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "4";
            }
            else
            {
                txtResult.Text = txtResult.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "5";
            }
            else
            {
                txtResult.Text = txtResult.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "6";
            }
            else
            {
                txtResult.Text = txtResult.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "7";
            }
            else
            {
                txtResult.Text = txtResult.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "8";
            }
            else
            {
                txtResult.Text = txtResult.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "9";
            }
            else
            {
                txtResult.Text = txtResult.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "0";
            }
            else
            {
                txtResult.Text = txtResult.Text + "0";
            }
        }

        private void nDot_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + ".";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void addition_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "+";
        }

        private void substraction_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "-";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "*";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void division_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            Operation = "/";
        }

        private void equals_Click(object sender, EventArgs e)
        {

            SecondNumber = Convert.ToDouble(txtResult.Text);

            switch(Operation)
            {
                case "+":
                    Result = Convert.ToString(FirstNumber + SecondNumber);
                    txtResult.Text = Result;
                    break;

                case "-":
                    Result = Convert.ToString(FirstNumber - SecondNumber);
                    txtResult.Text = Result;
                    break;

                case "*":
                    Result = Convert.ToString(FirstNumber * SecondNumber);
                    txtResult.Text = Result;
                    break;

                case "/":
                    Result = Convert.ToString(FirstNumber / SecondNumber);
                    txtResult.Text = Result;
                    break;

                default:
                    Result = "No Result";
                    break;
            }
        }
    }
}
