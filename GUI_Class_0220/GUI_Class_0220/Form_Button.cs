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
    public partial class Form_Button : Form
    {
        public Form_Button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "請按我一下")
                button1.Text = "我已經被按過了";
            else if (button1.Text == "我已經被按過了")
                button1.Text = "請按我一下";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (label1.Text == "天氣真好")
                label1.Text = "天氣真差";
            else if (label1.Text == "天氣真差")
                label1.Text = "天氣真好";
            else label1.Text = "天氣真好";
                
                

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string temp = label2.Text;
            int count = 0;
            try
            {
                count = Int32.Parse(temp) + 1;
            }catch(Exception e1)
            {

            }
            label2.Text = count.ToString();
           
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            short sizeNum = 10;
            button4.Size = new Size(button4.Width + sizeNum, button4.Height + sizeNum);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            string temq = label3.Text;
            int count = 0;
            try
            {
                count = Int32.Parse(temq) + 1;
            }
            catch (Exception e1)
            {

            }
            label3.Text = count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string temq = label3.Text;
            int count = 0;
            try
            {
                count = Int32.Parse(temq) - 1;
            }
            catch (Exception e1)
            {

            }
            label3.Text = count.ToString();
        }
    }
}
