using System;
using System.Windows.Forms;

namespace WindowsFormsApps.SeventhTaskGUI
{
    public partial class SevenTask : Form
    {
        public SevenTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = getChangedString(textBox1.Text);
            }
        }
        
        private String getChangedString(String str)
        {
            String temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ':') return temp;
                temp += str[i];
            }
            return temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox2.Text = getCorrectedSentence(textBox2.Text);
            }
        }
        private String getCorrectedSentence(String str)
        {
            String temp = "";
            for (int i = 1; i < str.Length; i++)
            {
                char previousChar = str[i - 1];
                char followingChar = str[i];
                if (char.IsPunctuation(previousChar) && char.IsLetterOrDigit(followingChar))
                {
                    temp += previousChar + " ";
                }
                else
                    temp += previousChar;
            }
            temp += str[str.Length - 1];
            return temp;
        }
    }
}
