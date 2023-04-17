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
    public partial class Form_TextBox : Form
    {
        public Form_TextBox()
        {
            InitializeComponent();
        }

        private void Form_TextBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int input = Int32.Parse(str);
            lab_fainal.Text = (input + 10).ToString();
            //MessageBox.Show(str)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form_ff = new Form_ff();
            form_ff.Show();
        }
    }
}
