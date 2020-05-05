using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps.FourthTaskGUI
{
    public partial class FourthTask : Form
    {
        public FourthTask()
        {
            InitializeComponent();
            getWierdPicture('A', 80, "down", 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && isValueTypeValid(textBox1.Text) &&
                textBox2.Text != "" && isValueTypeValid(textBox2.Text)){
                if (Convert.ToInt32(textBox1.Text) < Convert.ToInt32(textBox2.Text)) textBox5.Text = "m не может быть больше n";
                else textBox3.Text = Convert.ToString(C(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
            }
                
        }
        private int C(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;
            else
                return C(n - 1, k - 1) + C(n - 1, k);
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
        private void getWierdPicture(Char character, int count, String direction, int spaceCount)
        {
            for (int i = 0; i < spaceCount; i++)
            {
                textBox4.AppendText(" ");
            }
            for (int i = 0; i < count; i++)
            {
                textBox4.AppendText(Convert.ToString(character));
            }
            textBox4.AppendText(Environment.NewLine);
            if (direction == "down" && count != 30) getWierdPicture(++character, count -= 2, "down", ++spaceCount);
            else
            {
                if (count == 80) return;
                getWierdPicture(--character, count += 2, "up", --spaceCount);
            }
        }
    }
}
