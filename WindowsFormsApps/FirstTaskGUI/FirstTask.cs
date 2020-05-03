using System;
using System.Windows.Forms;

namespace WindowsFormsApps
{
    public partial class FirstTask : Form
    {
        public FirstTask()
        {
            InitializeComponent();
        }
        private void FirstButtonListener(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && isValueTypeValid(textBox1.Text) && textBox2.Text != "" && isValueTypeValid(textBox2.Text))
            textBox3.Text = Convert.ToString(CountRingSquare(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }
        private static double CountRingSquare(double outerRadius, double innerRadius)
        {
            return Math.PI * (outerRadius * outerRadius - innerRadius * innerRadius);
        }
        private void SecondButtonListener(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && isValueTypeValid(textBox4.Text))
            {
                if (AreSame(Convert.ToInt32(textBox4.Text)))
                {
                    textBox5.Text = "Цифры равны";
                }
                else
                {
                    textBox5.Text = "Цифры не равны";
                }
            }
        }
        private static bool AreSame(int number)
        {
            if (number % 111 == 0) return true;
            else return false;
        }
        private bool isValueTypeValid(String str)
        {
            char[] chArr = str.ToCharArray();
            for (int i = 0; i < chArr.Length; i++)
            {
                if (!(chArr[i] >= '0' && chArr[i] <= '9') && chArr[i] != '-')
                {
                    return false;
                }
            }
            return true;
        }


    }
}
