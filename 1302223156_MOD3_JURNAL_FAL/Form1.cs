using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1302223156_MOD3_JURNAL_FAL
{
    public partial class Form1 : Form
    {
        int angka1;
        int angka2;
        int hasil;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
            label1.Text = label1.Text+button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "2";
            label1.Text = label1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "3";
            label1.Text = label1.Text + button3.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            angka1=Convert.ToInt32(label1.Text);
            label1.Text = null;
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "7";
            label1.Text = label1.Text + button7.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            angka2=Convert.ToInt32(label1.Text);
            hasil = angka1 + angka2;
            label1.Text = Convert.ToString(hasil);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "4";
            label1.Text = label1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "5";
            label1.Text = label1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "6";
            label1.Text = label1.Text + button6.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "8";
            label1.Text = label1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "9";
            label1.Text = label1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "0";
            label1.Text = label1.Text + button10.Text;
        }
    }
}
