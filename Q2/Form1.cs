using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Q2
{
    public partial class Form1 : Form
    {
        //輸入日期是否不大於今天
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //得到今天的日期
            var today = DateTime.Now;
            //得到日期
            DateTime date = Convert.ToDateTime(textBox1.Text);
            //找出不一樣
            int result = DateTime.Compare(today, date);
           
            if (result > 0)
                MessageBox.Show("日期早于今天");
            
            else if (result < 0)
                MessageBox.Show("日期晚于今天");

        }
    }
}
