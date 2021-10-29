using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double first { get; set; }
        public double second { get; set; } = 0;
        public double last { get; set; } = 0;
        public string math { get; set; }
        public string equal { get; set; }
        public bool exit { get; set; } = true;
        public int increment { get; set; } = 0;
        public string memory { get; set; }
        public double memoryInt { get; set; }
        public double hpercent { get; set; }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void One_Click(object sender, EventArgs e)
        {
            var a = Convert.ToString(first);
            if (textBox2.Text == a) textBox2.Text = null;
            textBox2.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            var a = Convert.ToString(first);
            if (textBox2.Text == a) textBox2.Text = null;
            textBox2.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            var a = Convert.ToString(first);
            if (textBox2.Text == a) textBox2.Text = null;
            textBox2.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            var a = Convert.ToString(first);
            if (textBox2.Text == a) textBox2.Text = null;
            textBox2.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            var a = Convert.ToString(first);
            if (textBox2.Text == a) textBox2.Text = null;
            textBox2.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            var a = Convert.ToString(first);
            if (textBox2.Text == a) textBox2.Text = null;
            textBox2.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            var a = Convert.ToString(first);
            if (textBox2.Text == a) textBox2.Text = null;
            textBox2.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            var a = Convert.ToString(first);
            if (textBox2.Text == a) textBox2.Text = null;
            textBox2.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            var a = Convert.ToString(first);
            if (textBox2.Text == a) textBox2.Text = null;
            textBox2.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            var a = Convert.ToString(first);
            if (textBox2.Text == a) textBox2.Text = null;
            textBox2.Text += "0";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (math == "-" || math == "*" || math == "/") increment = 0;
            increment++;
            if (increment <= 1)
            {
                if (math == "*")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " +");
                    second = first * Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first * Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else if (math == "-")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " +");
                    second = first - Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first - Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else if (math == "/")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " +");
                    second = first / Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first / Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else
                {
                    textBox1.Text += (textBox2.Text + " +");
                    second = Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }

            }
            else
            {
                if (math == "*")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " +");
                    second = first * Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first * Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else if (math == "-")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " +");
                    second = first - Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first - Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                if (math == "/")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " +");
                    second = first / Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first / Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else
                {
                    textBox1.Text += (textBox2.Text + " +");
                    second = first + Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first + Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
            }
            math = "+";
        }

        private void reciproc_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"reciproc({textBox2.Text})";
            textBox2.Text = Convert.ToString(1 / Convert.ToDouble(textBox2.Text));
            
        }

        private void Equlity_Click(object sender, EventArgs e)
        {
            switch (math)
            {
                case "+":
                    textBox1.Text = null;
                    last = Convert.ToDouble(textBox2.Text);
                    equal = Convert.ToString(second + last);
                    textBox2.Text = equal;
                    first = 0;
                    break;
                case "-":
                    textBox1.Text = null;
                    last = Convert.ToDouble(textBox2.Text);
                    equal = Convert.ToString(second - last);
                    textBox2.Text = equal;
                    first = 0;
                    break;
                case "*":
                    textBox1.Text = null;
                    last = Convert.ToDouble(textBox2.Text);
                    equal = Convert.ToString(second * last);
                    textBox2.Text = equal;
                    first = 0;
                    break;
                default:
                    break;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (math == "+" || math == "*" || math == "/") increment = 0;
            increment++;
            if (increment <= 1)
            {
                if (math == "+")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " -");
                    second = first + Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first + Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else if (math == "*")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " -");
                    second = first * Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first * Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else if (math == "/")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " -");
                    second = first / Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first / Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else
                {
                    textBox1.Text += (textBox2.Text + " -");
                    second = Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }

            }
            else
            {
                if (math == "+")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " -");
                    second = first + Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first + Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else if (math == "*")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " -");
                    second = first * Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first * Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                if (math == "/")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " -");
                    second = first / Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first / Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else
                {
                    textBox1.Text += (textBox2.Text + " -");
                    second = first - Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first - Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
            }
            math = "-";

        }

        private void Multple_Click(object sender, EventArgs e)
        {
            if (math == "+" || math == "/" || math == "-") increment = 0;
            increment++;
            if (increment <= 1)
            {
                if (math == "+")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " *");
                    second = first + Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first + Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else if (math == "-")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " *");
                    second = first - Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first - Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else if (math == "/")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " *");
                    second = first / Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first / Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else
                {
                    textBox1.Text += (textBox2.Text + " *");
                    second = Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }

            }
            else
            {
                if (math == "+")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " *");
                    second = first + Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first + Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else if (math == "-")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " *");
                    second = first - Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first - Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                if (math == "/")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " *");
                    second = first / Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first / Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else
                {
                    textBox1.Text += (textBox2.Text + " *");
                    second = first * Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first * Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
            }
            math = "*";

        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (math == "+" || math == "*" || math == "-") increment = 0;
            increment++;
            if (increment <= 1)
            {
                if (math == "+")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " /");
                    second = first + Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first + Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else if (math == "-")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " /");
                    second = first - Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first - Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else if (math == "*")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " /");
                    second = first * Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first * Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else
                {
                    textBox1.Text += (textBox2.Text + " /");
                    second = Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }

            }
            else
            {
                if (math == "+")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " /");
                    second = first + Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first + Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else if (math == "-")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " /");
                    second = first - Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first - Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                if (math == "*")
                {
                    increment = 10;
                    textBox1.Text += (textBox2.Text + " /");
                    second = first * Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first * Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
                else
                {
                    textBox1.Text += (textBox2.Text + " /");
                    second = first / Convert.ToDouble(textBox2.Text);
                    textBox2.Text = Convert.ToString(first / Convert.ToDouble(textBox2.Text));
                    first = Convert.ToDouble(textBox2.Text);
                }
            }
            math = "*";
        }

        private void memoryPlus_Click(object sender, EventArgs e)
        {
            memoryInt = Convert.ToDouble(textBox2.Text) + memoryInt;
            memory = ((Convert.ToString(memoryInt)));
            labMemory.Text = "M";
            labMemory.BackColor = System.Drawing.Color.White;
        }

        private void memoryMinus_Click(object sender, EventArgs e)
        {
            memoryInt = Convert.ToDouble(textBox2.Text) + memoryInt;
            memory = ("-" + (Convert.ToString(memoryInt)));
            labMemory.Text = "M";
            labMemory.BackColor = System.Drawing.Color.White;
        }

        private void memoryRead_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(memory);
        }

        private void memoryClear_Click(object sender, EventArgs e)
        {
            labMemory.Text = "";
            memory = null;
        }

        private void memorySave_Click(object sender, EventArgs e)
        {
            memory = textBox2.Text;
            labMemory.Text = "M";
            labMemory.BackColor = System.Drawing.Color.White;
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            first = 0;
            second = 0;
            last = 0;
            increment = 0;
            equal = null;
        }

        private void clearLast_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
        }

        private void plusOrMinus_Click(object sender, EventArgs e)
        {
            var pm = textBox2.Text.ToArray();
            var fs = pm.First();
            var v = textBox2.Text;
            
            if (fs == '-')
            {
                textBox2.Text = textBox2.Text.Remove(0,1);
            }
            else
            {
                textBox2.Text = "";
                textBox2.Text += "-" + v;
            }
            
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Sqrt(sqrt));
            textBox1.Text += $"sqrt({sqrt})";
        }

        private void percent_Click(object sender, EventArgs e)
        {
            hpercent = Convert.ToDouble(textBox2.Text);
            double a1 = hpercent * first / 100;
            textBox2.Text = Convert.ToString(a1);
        }
    }
}
