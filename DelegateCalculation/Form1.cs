using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateCalculation
{
    public delegate float MyCalculation(float x, float y);
    public partial class Form1 : Form
    {
        //private MyClass obj;
        public Form1()
        {
            InitializeComponent();
            //obj = new MyClass();
            //obj.CalculationChange += Calculation;
        }

        /// <summary>
        /// 加法運算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private float Add(float x,float y)
        {
            return x + y;
        }

        /// <summary>
        /// 減法運算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private float Sub(float x, float y)
        {
            return x - y;
        }

        /// <summary>
        /// 乘法運算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private float Mul(float x, float y)
        {
            return x * y;
        }

        /// <summary>
        /// 除法運算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private float Div(float x, float y)
        {
            return x / y;
        }

        //private void Calculation(object sender, EventArgs e)
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;
            float resultNum1, resultNum2;
            bool num1Parse = float.TryParse(num1,out resultNum1);
            bool num2Parse = float.TryParse(num2, out resultNum2);

            if (num1Parse && num2Parse)
            {
                MyCalculation add = new MyCalculation(Add);
                label1.Text = (add.Invoke(resultNum1,resultNum2).ToString());
            }
            else
            {
                MessageBox.Show("請務必輸入數字！！");
            }
        }
    }
}
