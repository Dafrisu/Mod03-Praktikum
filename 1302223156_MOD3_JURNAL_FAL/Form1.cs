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
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            label1.Text = button1.Text;
            label1.Text = button2.Text;
            label1.Text = button3.Text;
            label1.Text = button4.Text;
            label1.Text = button5.Text;
            label1.Text = button6.Text;
            label1.Text = button7.Text;
            label1.Text = button8.Text;
            label1.Text = button9.Text;
            label1.Text = button10.Text;
            label1.Text = button11.Text;
            label1.Text = button12.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
