using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApps.EightTaskGUI
{
    public partial class EightTask : Form
    {
        public EightTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") findOccurrences();
        }
        private void findOccurrences()
        {
            String pattern = @"((https?|ftp)\:\/\/)?([a-z0-9]{1})((\.[a-z0-9-])|([a-z0-9-]))*\.([a-z]{2,6})(\/?)";
            Regex newReg = new Regex(pattern);
            MatchCollection matches = newReg.Matches(textBox1.Text);
            foreach (Match mat in matches)
            {
                textBox2.AppendText(String.Format("Значение найденного объекта {0}", mat.Value));
                textBox2.AppendText(Environment.NewLine);
            }
            textBox2.AppendText(String.Format("Число найденных совпадений {0}", matches.Count));
            textBox2.AppendText(Environment.NewLine);
        }
    }
}
