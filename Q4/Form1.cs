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

namespace Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumberofCar, Numberofpeople;
            //取得被選取的數值
            Numberofpeople = GetNumberofpeople();
            NumberofCar = GetNumberofCar();
            //numPeople = Convert.ToInt32(txtPeople.Text);
            //numCar = Convert.ToInt32(txtCar.Text);

            //計算方式
            Numberofpeople = Numberofpeople * 60;

            NumberofCar = NumberofCar * 200;


            // 計算答案
            string result = "人：" + Numberofpeople + "車：" + NumberofCar + "共：" +(Numberofpeople + NumberofCar );

            ////呈現結果
            resultTextBox.Text = result.ToString();
        }

        private void FirstNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }


        private int GetNumberofpeople()
        => Convert.ToInt32(FirstNumberTextBox.Text);

        private int GetNumberofCar()
       => Convert.ToInt32(SecondNumberTextBox.Text);
    }
}
