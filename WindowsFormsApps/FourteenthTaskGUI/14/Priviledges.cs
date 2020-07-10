using System;
using System.Windows.Forms;

namespace WindowsFormsApps.FourteenthTaskGUI
{
    public partial class Priviledges : Form
    {
        public Priviledges()
        {
            InitializeComponent();
        }

        private void Priviledges_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet3.Priviledge". При необходимости она может быть перемещена или удалена.
            this.priviledgeTableAdapter.Fill(this.dBDataSet3.Priviledge);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            priviledgeTableAdapter.Update(dBDataSet3);
        }
    }
}
