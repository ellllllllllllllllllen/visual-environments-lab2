using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double q = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked)
            {
                if (Math.Abs(x * q) > 10)
                {
                    double k = Math.Log10((Math.Abs((Math.Exp(x) + Math.Exp(-x)) / 2)) + Math.Abs(q));
                    textBox4.AppendText("k = " + k + Environment.NewLine);
                }
                if (Math.Abs(x * q) < 10)
                {
                    double k = Math.Exp(((Math.Exp(x) + Math.Exp(-x)) / 2) + q);
                    textBox4.AppendText("k = " + k + Environment.NewLine);
                }
                if (Math.Abs(x * q) == 10)
                {
                    double k = ((Math.Exp(x) + Math.Exp(-x)) / 2) + q;
                    textBox4.AppendText("k = " + k + Environment.NewLine);
                }
            }
            if (radioButton2.Checked)
            {
                if (Math.Abs(x * q) > 10)
                {
                    double k = Math.Log10(Math.Abs(Math.Pow(x, 2)) + Math.Abs(q));
                    textBox4.AppendText("k = " + k + Environment.NewLine);
                }
                if (Math.Abs(x * q) < 10)
                {
                    double k = Math.Exp(Math.Pow(x, 2) + q);
                    textBox4.AppendText("k = " + k + Environment.NewLine);
                }
                if (Math.Abs(x * q) == 10)
                {
                    double k = Math.Pow(x, 2) + q;
                    textBox4.AppendText("k = " + k + Environment.NewLine);
                }
            }
            if (radioButton3.Checked)
            {
                if (Math.Abs(x * q) > 10)
                {
                    double k = Math.Log10((Math.Abs(Math.Exp(x))) + Math.Abs(q));
                    textBox4.AppendText("k = " + k + Environment.NewLine);
                }
                if (Math.Abs(x * q) < 10)
                {
                    double k = Math.Exp(Math.Exp(x) + q);
                    textBox4.AppendText("k = " + k + Environment.NewLine);
                }
                if (Math.Abs(x * q) == 10)
                {
                    double k = Math.Exp(x) + q;
                    textBox4.AppendText("k = " + k + Environment.NewLine);
                }
            }
            //else
            //{
            //    textBox4.AppendText("Select function value." + Environment.NewLine);
            //}

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //double x = Convert.ToDouble(textBox1.Text);
            //double q = Convert.ToDouble(textBox2.Text);
            //RadioButton radioButton = (RadioButton)sender;
            //if (radioButton.Checked)
            //{
            //    if(Math.Abs(x * q) > 10)
            //    {
            //        double k = Math.Log10((Math.Abs((Math.Exp(x) + Math.Exp(-x)) / 2)) + Math.Abs(q));
            //        textBox4.AppendText("k = " + k + Environment.NewLine);
            //    }
            //    if(Math.Abs(x * q) < 10)
            //    {
            //        double k = Math.Exp(((Math.Exp(x) + Math.Exp(-x)) / 2) + q);
            //        textBox4.AppendText("k = " + k + Environment.NewLine);
            //    }
            //    if (Math.Abs(x * q) == 10)
            //    {
            //        double k = ((Math.Exp(x) + Math.Exp(-x)) / 2) + q;
            //        textBox4.AppendText("k = " + k + Environment.NewLine);
            //    }
            //}
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //double x = Convert.ToDouble(textBox1.Text);
            //double q = Convert.ToDouble(textBox2.Text);
            //RadioButton radioButton = (RadioButton)sender;
            //if (radioButton.Checked)
            //{
            //    if (Math.Abs(x * q) > 10)
            //    {
            //        double k = Math.Log10(Math.Abs(Math.Pow(x, 2)) + Math.Abs(q));
            //        textBox4.AppendText("k = " + k + Environment.NewLine);
            //    }
            //    if (Math.Abs(x * q) < 10)
            //    {
            //        double k = Math.Exp(Math.Pow(x, 2) + q);
            //        textBox4.AppendText("k = " + k + Environment.NewLine);
            //    }
            //    if (Math.Abs(x * q) == 10)
            //    {
            //        double k = Math.Pow(x, 2) + q;
            //        textBox4.AppendText("k = " + k + Environment.NewLine);
            //    }
            //}
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //double x = Convert.ToDouble(textBox1.Text);
            //double q = Convert.ToDouble(textBox2.Text);
            //RadioButton radioButton = (RadioButton)sender;
            //if (radioButton.Checked)
            //{
            //    if (Math.Abs(x * q) > 10)
            //    {
            //        double k = Math.Log10((Math.Abs(Math.Exp(x))) + Math.Abs(q));
            //        textBox4.AppendText("k = " + k);
            //    }
            //    if (Math.Abs(x * q) < 10)
            //    {
            //        double k = Math.Exp(Math.Exp(x) + q);
            //        textBox4.AppendText("k = " + k);
            //    }
            //    if (Math.Abs(x * q) == 10)
            //    {
            //        double k = Math.Exp(x) + q;
            //        textBox4.AppendText("k = " + k);
            //    }
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.AppendText("Lab №1, student of 10702118 group, Zavadskaya E.V." + Environment.NewLine);
        }
    }
}
