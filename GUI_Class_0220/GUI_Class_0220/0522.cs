using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_Class_0220
{
    public partial class _0522 : Form
    {
        public _0522()
        {
            InitializeComponent();
            /*File.WriteAllText("Temp.txt", "today0605\n");
            File.AppendAllText("Temp.txt", "Monday Class");
            String input = File.ReadAllText("Temp.txt");
            MessageBox.Show(input);*/

            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,配餐\n", Encoding.UTF8);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void _0522_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mainfood = "";
            string sidefood = "";
            foreach(Control c in panel1.Controls)
            {
                if(c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        mainfood += c.Text + " ";
                    }
                }
            }

            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        sidefood += c.Text + " ";
                    }
                }
            }

            DateTime currentDateTime = DateTime.Now;
            string formateDateTime = currentDateTime.ToString("yyyy/MM/dd HH:mm:ss");
            File.AppendAllText("OrderData.csv", formateDateTime + "," + mainfood + "," + sidefood + "\n");
            MessageBox.Show("點餐成功!");
            //Environment.NewLine換行
            //MessageBox.Show("主食:" + mainfood + "\r\n" + "配菜:" + sidefood);
        }
    }
}
