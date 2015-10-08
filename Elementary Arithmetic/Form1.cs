using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elementary_Arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int right = 0;
        public static int wrong = 0;
        private void RandomNum()
        {
            Random ran = new Random();
            int n1, n2;
            n1 = ran.Next(1, 11);
            n2 = ran.Next(1, 11);
            textBox1.Text = n1.ToString();
            textBox2.Text = n2.ToString();
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "×";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "÷";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int math;
            if (label4.Text == "+")
                math = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            else if (label4.Text == "-")
                math = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            else if (label4.Text == "×")
                math = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            else math = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
            if (textBox3.Text == math.ToString())
                right++;
            else wrong++;
            RandomNum();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomNum();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                label4.Text = "+";
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                label4.Text = "-";
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                label4.Text = "×";
            }
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                label4.Text = "÷";
            }
        }
    }
}
