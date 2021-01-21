using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T19_Ex4
{
    public partial class MiniCalculadora : Form
    {
        public MiniCalculadora()
        {
            InitializeComponent();
        }

        public static double num1 = 0;
        public static double num2 = 0;
        public static string op = "";
        public static string display = "";
        public static Boolean opSet = false;

        private void MiniCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //7
            if (display == "0")
            {
                display = "";
            }

            display = display + "7";
            textBox2.Text = display;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //8
            if (display == "0")
            {
                display = "";
            }
            display = display + "8";
            textBox2.Text = display;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //9
            if (display == "0")
            {
                display = "";
            }
            display = display + "9";
            textBox2.Text = display;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //4
            if (display == "0")
            {
                display = "";
            }
            display = display + "4";
            textBox2.Text = display;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5
            if (display == "0")
            {
                display = "";
            }
            display = display + "5";
            textBox2.Text = display;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //6
            if (display == "0")
            {
                display = "";
            }
            display = display + "6";
            textBox2.Text = display;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //1
            if (display == "0")
            {
                display = "";
            }
            display = display + "1";
            textBox2.Text = display;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //2
            if (display == "0")
            {
                display = "";
            }
            display = display + "2";
            textBox2.Text = display;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //3
            if (display == "0")
            {
                display = "";
            }
            display = display + "3";
            textBox2.Text = display;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //0
            if (display == "0")
            {
                display = "";
            }
            display = display + "0";
            textBox2.Text = display;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //C
            display = "";
            op = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            num1 = 0;
            num2 = 0;
            opSet = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //=
            if (opSet == true)
            {
                switch (op)
                {
                    case "+":
                        num2 = num1 + Convert.ToDouble(display);
                        break;
                    case "-":
                        num2 = num1 - Convert.ToDouble(display);
                        break;
                    case "*":
                        num2 = num1 * Convert.ToDouble(display);
                        break;
                    case "/":
                        num2 = num1 / Convert.ToDouble(display);
                        break;
                    default:
                        break;
                }
                textBox3.Text = Convert.ToString(num2);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //+
            op = "+";
            if (display == "")
            {
                display = "0";
                textBox2.Text = display;
            }
            if (display == "-")
            {
                display = "-";
            }
            else
            {
                if (opSet == false)
                {
                    opSet = true;
                    textBox2.Text = "";
                    num1 = Convert.ToDouble(display);
                    textBox1.Text = display + " " + op;
                    display = "";
                }
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //-
            op = "-";
            if(textBox2.Text == "")
            {
                display = display + "-";
                textBox2.Text = display;
            }
            else
            {
                if (display == "-")
                {
                    display = "-";
                }
                else
                {
                    if (opSet == false)
                    {
                        opSet = true;
                        textBox2.Text = "";
                        num1 = Convert.ToDouble(display);
                        textBox1.Text = display + " " + op;
                        display = "";
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //X
            op = "*";
            
            if (display == "")
            {
                display = "0";
                textBox2.Text = display;
            }
            if (display == "-")
            {
                display = "-";
            }
            else
            {
                if (opSet == false)
                {
                    opSet = true;
                    textBox2.Text = "";
                    num1 = Convert.ToDouble(display);
                    textBox1.Text = display + " " + op;
                    display = "";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //÷
            op = "/";
            if (display == "")
            {
                display = "0";
                textBox2.Text = display;
            }
            if (display == "-")
            {
                display = "-";
            }
            else
            {
                if (opSet == false)
                {
                    opSet = true;
                    textBox2.Text = "";
                    num1 = Convert.ToDouble(display);
                    textBox1.Text = display + " " + op;
                    display = "";
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // ·
            if (display == "")
            {
                display = "0.";
                textBox2.Text = display;
            }
            if (display != "-" && (display.IndexOf(".") < 0))
            {
                display = display + ".";
                textBox2.Text = display;
            }

        }
    }
}
