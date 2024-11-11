using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПЗ__7_8_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b;
        bool znak;
        int count;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+ 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
            }
            catch
            {
                label1.Text = ("Error!");
            }

            
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
            }
            catch
            {
                label1.Text = ("Error!");
            }
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
            }
            catch
            {
                label1.Text = ("Error!");
            }
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
            }
            catch
            {
                label1.Text = ("Error!");
            }
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void calculate()
        {   
            switch(count)
            {
                
            
                case 1:
                    try 
                    {
                        b = a + double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                        catch 
                        {
                            textBox1.Text = ("Error!");
                        }
                    break;
                case 2:
                    try
                    {
                        b = a - double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch
                    {
                        textBox1.Text = ("Error!");
                    }
                    break;
                case 3:
                    try
                    {
                        b = a * double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch
                    {
                        textBox1.Text = ("Error!");
                    }
                    break;
                case 4:
                    try
                    {
                        b = a / double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch
                    {
                        textBox1.Text = ("Error!");
                    }
                    break;
                default:
                    break;
                
            }
        }
    }
}
