using System;
using System.Windows.Forms;

namespace WindowsFormsApps.ThirdTaskGUI
{
    public partial class ThirdTask : Form
    {
        public ThirdTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && isValueTypeValid(textBox1.Text) &&
                textBox2.Text != "" && isValueTypeValid(textBox2.Text) &&
                textBox3.Text != "" && isValueTypeValid(textBox3.Text) &&
                textBox4.Text != "" && isValueTypeValid(textBox4.Text) &&
                textBox5.Text != "" && isValueTypeValid(textBox5.Text) &&
                textBox6.Text != "" && isValueTypeValid(textBox6.Text) &&
                textBox7.Text != "" && isValueTypeValid(textBox7.Text) &&
                textBox8.Text != "" && isValueTypeValid(textBox8.Text) &&
                textBox9.Text != "" && isValueTypeValid(textBox9.Text) &&
                textBox10.Text != "" && isValueTypeValid(textBox10.Text) &&
                textBox11.Text != "" && isValueTypeValid(textBox11.Text) &&
                textBox12.Text != "" && isValueTypeValid(textBox12.Text))
            {
                fillBoxes();
            }
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
        private double f(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1));
        }
        private double d(double a, double b, double c)
        {
            return a + b + c;
        }
        private void fillBoxes()
        {
            textBox13.Text = Convert.ToString(f(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text),
                Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text)));
            textBox14.Text = Convert.ToString(f(Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text),
                Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox8.Text)));
            textBox15.Text = Convert.ToString(f(Convert.ToDouble(textBox9.Text), Convert.ToDouble(textBox10.Text),
                Convert.ToDouble(textBox11.Text), Convert.ToDouble(textBox12.Text)));
            textBox16.Text = Convert.ToString(d(Convert.ToDouble(textBox13.Text), Convert.ToDouble(textBox14.Text), Convert.ToDouble(textBox15.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox17.Text != "" && isValueTypeValid(textBox17.Text)&&
                textBox18.Text != "" && isValueTypeValid(textBox18.Text)&&
                textBox19.Text != "" && isValueTypeValid(textBox19.Text)){
                createTableOfValues(Convert.ToDouble(textBox17.Text), Convert.ToDouble(textBox18.Text),
                    Convert.ToDouble(textBox19.Text));
            }
        }
        private double fX(double x)
        {
            if (x - 1 < 1) return 1;
            if (x - 1 == 1) return 0;
            if (x - 1 > 1) return -1;
            return 0;
        }
        private void createTableOfValues(double a, double b,double h)
        {
            for (double i = a; i <= b; i += h) { 
                textBox20.AppendText("f(" + i + ")" + " = " + fX(i));
                textBox20.AppendText(Environment.NewLine);
            }

        }
    }
}
