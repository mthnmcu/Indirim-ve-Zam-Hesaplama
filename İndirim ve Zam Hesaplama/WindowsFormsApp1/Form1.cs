using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double urunFiyati=double.Parse(textBox1.Text); double kdvOrani = 0;
            if (checkBox1.Checked)
            {
                kdvOrani = 0.05; ;
            }
            else if(checkBox2.Checked)
            {
                kdvOrani = 0.06;
            }
            else if(checkBox3.Checked)
            {
                kdvOrani = 0.12;
            }
            double toplamTutar=urunFiyati*(1+kdvOrani);
            textBox3.Text = toplamTutar.ToString("F2");
        }
    }
}
