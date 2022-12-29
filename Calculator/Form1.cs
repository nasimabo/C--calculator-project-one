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
        double resultvalue = 0;
        string oparformance = "";
        bool isoparformance = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {

            
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
           

        }

        private void button14_Click(object sender, EventArgs e)
        {

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void n_click(object sender, EventArgs e)
        {
            if((textBox1.Text == "0") || (isoparformance))
                textBox1.Clear();
            
            Button n=(Button) sender;
            if(n.Text==".")
            {
                if(!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + n.Text;
            }else
            textBox1.Text = textBox1.Text + n.Text;
            isoparformance = false;
        }

        private void op_click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if(resultvalue !=0)
            {
                button15.PerformClick();
                oparformance = n.Text;
                
                karent.Text = resultvalue + " " + oparformance;
                isoparformance = true;
            }
            else
            {
                oparformance = n.Text;
                resultvalue = double.Parse(textBox1.Text);
                karent.Text = resultvalue + " " + oparformance;
                isoparformance = true;

            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultvalue = 0;
        }

        private void equale_click(object sender, EventArgs e)
        {
            switch(oparformance)
                {
                case "+":
                    textBox1.Text = (resultvalue + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultvalue - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultvalue * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultvalue / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultvalue = double.Parse(textBox1.Text);
            karent.Text = "";

        }
    }
}
