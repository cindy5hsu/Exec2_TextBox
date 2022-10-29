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

namespace Q3
{
    public partial class Form1 : Form
    {
        //經由輸入生日判斷是否已滿 13 歲
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 得到今天日期 */
            var today = DateTime.Now;
            DateTime date1 = Convert.ToDateTime(textBox1.Text);
            
            var year = (today - date1).Days / 365;
            if (year > 13)
            {
                MessageBox.Show("年紀大於13嵗");
            }
            else if (year < 13)
            {
                MessageBox.Show("年紀小於13嵗");
            }
            else
            {
                MessageBox.Show("今年年紀13嵗");
            }
        }
    }
}
