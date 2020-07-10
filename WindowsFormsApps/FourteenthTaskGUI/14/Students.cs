using System;
using System.Windows.Forms;

namespace WindowsFormsApps.FourteenthTaskGUI
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.dBDataSet.Students);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentsTableAdapter.Update(dBDataSet);
        }
    }
}
