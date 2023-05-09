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
    public partial class Form0509HW : Form
    {
        public Form0509HW()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            int add1 = 0;
            int add2 = 0;
            try
            {
                add1 = Int32.Parse(textBoxA1.Text);
                add2 = Int32.Parse(textBoxA2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("發生錯誤");
            }
            labelA.Text = (add1 + add2).ToString();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            int bdd1 = 0;
            int bdd2 = 0;
            try
            {
                bdd1 = Int32.Parse(textBoxB1.Text);
                bdd2 = Int32.Parse(textBoxB2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("發生錯誤");
            }
            labelB.Text = (bdd1 - bdd2).ToString();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            int cdd1 = 0;
            int cdd2 = 0;
            try
            {
                cdd1 = Int32.Parse(textBoxC1.Text);
                cdd2 = Int32.Parse(textBoxC2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("發生錯誤");
            }
            labelC.Text = (cdd1 * cdd2).ToString();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            int ddd1 = 0;
            int ddd2 = 0;
            try
            {
                ddd1 = Int32.Parse(textBoxD1.Text);
                ddd2 = Int32.Parse(textBoxD2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("發生錯誤");
            }
            labelD.Text = (ddd1 / ddd2).ToString();
        }
    }
}
