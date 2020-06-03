using System;
using System.Windows.Forms;

namespace WindowsFormsApps.FourteenthTaskGUI
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet2.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.dBDataSet2.Rooms);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            roomsTableAdapter.Update(dBDataSet2);
        }
    }
}
