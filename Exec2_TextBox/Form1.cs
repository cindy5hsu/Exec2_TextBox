using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox
{
    //輸入數值是否在[1,99]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) >= 1 && int.Parse(textBox1.Text) <= 99)
            {
                MessageBox.Show("Value is [1,99]");
            }
            else if (int.Parse(textBox1.Text) <= 1 || int.Parse(textBox1.Text) >= 99)
            {
                MessageBox.Show("Value is not in range [1,99]");
            }
        }
    }
}
