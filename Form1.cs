using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operation_pressed))
            {
                textBox1.Clear();
            }
                operation_pressed = false;
                Button b = (Button)sender;
                textBox1.Text = textBox1.Text + b.Text;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value =double.Parse (textBox1.Text);
            operation_pressed = true;
            label1.Text = label1.Text+ value + "" +  operation;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
