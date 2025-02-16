using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
       
        public Form1()
        {
            InitializeComponent();
        }
        Double result = 0;
        string operation = "";
        bool enter_value = false;

        private void button_click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (enter_value))
                display.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!display.Text.Contains("."))
                    display.Text = display.Text + num.Text;
            }
            else
            {
                display.Text = display.Text + num.Text;
            }
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnpn_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(display.Text) * (-1);
            display.Text = System.Convert.ToString(a);
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void functionClicks(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(display.Text);
            display.Text = "";
            lbldau.Text = System.Convert.ToString(result) + "" + operation;
        }

        private void equals_btn(object sender, EventArgs e)
        {
            lbldau.Text = "";
            switch (operation)
            {
                case "+":
                    display.Text = (result + Double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (result - Double.Parse(display.Text)).ToString();
                    break;
                case "*":
                    display.Text = (result * Double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    display.Text = (result / Double.Parse(display.Text)).ToString();
                    break;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1, 1);
            }
            if (display.Text == "")
            {
                display.Text = "0";
            }
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            lbldau.Text = "";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            lbldau.Text = "";
        }
    }
}
