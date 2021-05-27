using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAZAAARRRRR
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        static public string SaveBat;
        static public int N;
        static public bool Chek;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                N = 20;
                SaveBat = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                N = 20;
                SaveBat = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                N = 20;
                SaveBat = radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                N = 20;
                SaveBat = radioButton4.Text;
            }
            if (radioButton5.Checked)
            {
                N = 20;
                SaveBat = radioButton5.Text;
            }
            if (radioButton6.Checked)
            {
                N = 20;
                SaveBat = radioButton6.Text;
            }
            if (radioButton7.Checked)
            {
                N = 20;
                SaveBat = radioButton7.Text;
            }
            if (radioButton8.Checked)
            {
                SaveBat = radioButton8.Text;
                N = 140;
            }
            Form1 f1 = new Form1();
            f1.Show();
           

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton8.Enabled = true;
            Chek = false;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = true;
            radioButton8.Checked = true;
            Chek = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
