using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApps.FourteenthTaskGUI
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection sqlConnection = new OleDbConnection("Provider = Microsoft.Jet.OleDb.4.0; Data Source = DB.mdb");
            sqlConnection.Open();
            string s = "";
            if (radioButton1.Checked) { s = "SELECT * FROM Students"; }
            if (radioButton2.Checked) { s = "SELECT SNP, Group, Address FROM Students"; }
            if (radioButton3.Checked) { s = "SELECT DISTINCT Group FROM Students"; }
            if (radioButton4.Checked) { s = "SELECT * FROM rooms where Flour=3"; }
            if (radioButton5.Checked) { s = "SELECT * FROM Students where Students.Group like 'ПО%'"; }
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(s, sqlConnection);
            DataTable dataTable = new DataTable();
            dbDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Columns.RemoveAt(0);
            }

        }
    }
}
