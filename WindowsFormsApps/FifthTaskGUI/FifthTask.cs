using System;
using System.Windows.Forms;

namespace WindowsFormsApps.FifthTaskGUI
{
    public partial class FifthTask : Form
    {
        public FifthTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && isValueTypeValid(textBox1.Text) &&
                textBox2.Text != "" && isValueTypeValid(textBox2.Text) &&
                textBox3.Text != "" && isValueTypeValid(textBox3.Text))
            {
                for (double i = Convert.ToDouble(textBox1.Text); i <= Convert.ToDouble(textBox2.Text); i += Convert.ToDouble(textBox3.Text))
                    try
                    {
                        textBox4.AppendText("y(" + i + ")=" + f(i));
                        textBox4.AppendText(Environment.NewLine);
                    }
                    catch
                    {
                        textBox4.AppendText("y(" + i + ")=error");
                        textBox4.AppendText(Environment.NewLine);
                    }
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
        private double f(double x)
        {
            try
            {

                if (2 * Math.Pow(x, 5) - 1 < 0) throw new Exception();
                else return Math.Log(Math.Abs(3 * x)) * Math.Sqrt(2 * Math.Pow(x, 5) - 1);
            }
            catch
            {
                throw;
            }
        }
    }
}
