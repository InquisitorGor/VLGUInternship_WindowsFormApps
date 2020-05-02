using System;
using System.Windows.Forms;

namespace WindowsFormsApps
{
    public partial class FirstTask : Form
    {
        public FirstTask()//
        {
            InitializeComponent();
        }
        private void FirstButtonListener(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(CountRingSquare(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }
        private static double CountRingSquare(double outerRadius, double innerRadius)
        {
            return Math.PI * (outerRadius * outerRadius - innerRadius * innerRadius);
        }
        private void SecondButtonListener(object sender, EventArgs e)
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
        private static bool AreSame(int number)
        {
            if (number % 111 == 0) return true;
            else return false;
        }

        
    }
}
