using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class_0220
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("我被點擊了");
            Form form_Button = new Form_Button();
            form_Button.Show();
        }

        private void btn_Button_Leave(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form_TextBox = new Form_TextBox();
            form_TextBox.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form_TextBox1 = new MID0417();
            form_TextBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form form_TextBox1 = new Form_Add();
            form_TextBox1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form_TextBox1 = new FormTimer();
            form_TextBox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form_TextBox1 = new Form0509HW();
            form_TextBox1.Show();
        }
    }
}
