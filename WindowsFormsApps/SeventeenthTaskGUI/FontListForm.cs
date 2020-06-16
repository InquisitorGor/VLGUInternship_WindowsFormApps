using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps.SeventeenthTaskGUI
{
    public partial class FontListForm : Form
    {
        System.Drawing.Text.InstalledFontCollection fontList =
            new System.Drawing.Text.InstalledFontCollection();

        public FontListForm()
        {
            InitializeComponent();
        }

        private void FontListForm_Load(object sender, EventArgs e)
        {
            // Заполняем список названиями всех шрифтов.
            foreach (FontFamily ff in fontList.Families)
            {
                listBox1.Items.Add(ff.Name);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(listBox1.Text, 20);
        }
    }
}
