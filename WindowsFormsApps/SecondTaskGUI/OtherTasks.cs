using System;
using System.Windows.Forms;

namespace WindowsFormsApps.SecondTaskGUI
{
    public partial class OtherTasks : Form
    {
        public OtherTasks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && isValueTypeValid(textBox1.Text))
                textBox2.Text = getAgeCategory(Convert.ToInt32(textBox1.Text));
        }
        private string getAgeCategory(int year)
        {
            int age = 2020 - year;
            if (age <= 1) return "младенец";
            else if (age > 1 && age <= 11) return "ребенок";
            else if (age > 11 && age <= 15) return "подросток";
            else if (age > 15 && age <= 25) return "юноша";
            else if (age > 25 && age <= 70) return "мужчина";
            else return "старик";
        }
        private bool isValueTypeValid(String str)
        {
            char[] chArr = str.ToCharArray();
            for (int i = 0; i < chArr.Length; i++)
            {
                if (!(chArr[i] >= '0' && chArr[i] <= '9') && chArr[i]!='-')
                {
                    return false;
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "" && isValueTypeValid(textBox3.Text) && isValueTypeValid(textBox4.Text))
                textBox5.Text = ShowNegativeEvenNumbers(Convert.ToInt32(textBox3.Text),
                    Convert.ToInt32(textBox4.Text));
        }
        private string ShowNegativeEvenNumbers(int A1, int B1)
        {
            int A = A1;
            int B = B1;
            String str = "";
            while (A <= B && A < 0)
            {
                if (A % 2 != 0) A++;
                str += A + " ";
                A += 2;
            }
            return str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = getIDKWhatItIs();
        }
        private String getIDKWhatItIs()
        {
            int top = 8;
            String str = "";
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    str += top + " ";
                }
                top--;
                str += Environment.NewLine;
                for (int j = 0; j < i; j++)
                {
                    str += top + " ";
                }
                str += Environment.NewLine;
            }
            return str;
        }
    }
}
