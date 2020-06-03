using System;
using System.Windows.Forms;

namespace WindowsFormsApps.FourteenthTaskGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Students().ShowDialog();
        }

        private void комнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Rooms().ShowDialog();
        }

        private void льготыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Priviledges().ShowDialog();
        }

        private void расселениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Resettlement().ShowDialog();
        }

        private void запросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QueryForm().ShowDialog();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Report().ShowDialog();
        }
    }
}
