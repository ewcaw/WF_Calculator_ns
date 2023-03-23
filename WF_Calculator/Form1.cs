using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WF_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // this.label1.Text = "";
            this.main_num_label1.ResetText();
            this.first_num_label.ResetText();
            this.operator_label.ResetText();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text += "8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text += "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            SoundPlayer meow= new SoundPlayer(@"C:\Users\ewoln\OneDrive\Dokumenty\Visual Studio 2022\WF_Calculator_ns\WF_Calculator\cat_meow.wav");
            meow.Play();
                        



            double fn;
            double sn;
            double result = 0;
            double.TryParse(this.first_num_label.Text, out fn);
            double.TryParse(this.main_num_label1.Text, out sn);
            
            // -------------------------------------------------
            if (this.operator_label.Text == "+")
            {
                result = fn + sn;
            }
            // -------------------------------------------------
            if (this.operator_label.Text == "-")
            {
                result = fn - sn;
            }
            // -------------------------------------------------
            if (this.operator_label.Text == "x")
            {
                result = fn * sn;
            }
            // -------------------------------------------------
            if (this.operator_label.Text == "÷")
            {
                result = fn / sn;
            }
            // -------------------------------------------------

            this.main_num_label1.Text = result.ToString();
            this.first_num_label.ResetText();
            this.operator_label.ResetText();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";
            if (this.main_num_label1.Text != "")
            {
                this.first_num_label.Text = this.main_num_label1.Text;
            }
            this.main_num_label1.ResetText();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-";
            if (this.main_num_label1.Text != "")
            {
                this.first_num_label.Text = this.main_num_label1.Text;
            }
            this.main_num_label1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "x";
            if (this.main_num_label1.Text != "")
            {
                this.first_num_label.Text = this.main_num_label1.Text;
            }
            this.main_num_label1.ResetText();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "÷";
            if (this.main_num_label1.Text != "")
            {
                this.first_num_label.Text = this.main_num_label1.Text;
            }
            this.main_num_label1.ResetText();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.main_num_label1.Text += ".";
        }
    }
}
