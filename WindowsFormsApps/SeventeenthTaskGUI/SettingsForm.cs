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
    public partial class SettingsForm : Form
    {
        Color color;
        string firstName;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Новые значения для настроек.
            color = Color.MediumPurple;
            firstName = "Ivan";
            Invalidate();

            // Запись настроек.
            Properties.Settings.Default.color = color;
            Properties.Settings.Default.firstName = firstName;
            Properties.Settings.Default.Save();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Новые значения для настроек.
            color = Color.Firebrick;
            firstName = "Roman";
            Invalidate();

            // Запись настроек.
            Properties.Settings.Default.color = Color.Firebrick;
            Properties.Settings.Default.firstName = firstName;
            Properties.Settings.Default.Save();


        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Восстановление настроек.
                color = Properties.Settings.Default.color;
                firstName = Properties.Settings.Default.firstName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SettingsForm_Paint(object sender, PaintEventArgs e)
        {
            // Использование настроек.
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);
            g.DrawString(firstName, font, new SolidBrush(color), 100, 100);
        }
    }
}
