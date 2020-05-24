using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps.EleventhTask
{
    public partial class OneDimArray : Form
    {
        private int[] oneDimArray;
        public OneDimArray()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                defineDGVStricture(Convert.ToInt32(textBox1.Text));
            }
        }
        private void defineDGVStricture(int size)
        {
            dataGridView1.ColumnCount = size;
            oneDimArray = new int[size];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getDataForOneDimentionalArray();
            oneDimArray = oneDimArray.OrderBy(x => x).ToArray();
            showFiltredData();
        }
        private void getDataForOneDimentionalArray()
        {
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                {
                    oneDimArray[col] = Convert.ToInt32(dataGridView1.Rows[rows].Cells[col].Value);
                }
            }
        }
        private void showFiltredData()
        {
                for (int i = 0; i < oneDimArray.Length; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = oneDimArray[i];
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < oneDimArray.Length; i++)
                oneDimArray[i] = oneDimArray[i] * Convert.ToInt32(textBox2.Text);
            showFiltredData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < oneDimArray.Length; i++)
            {
                oneDimArray[i] = oneDimArray[i] + 1;
            }
            showFiltredData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < oneDimArray.Length; i++)
            {
                oneDimArray[i] = oneDimArray[i] - 1;
            }
            showFiltredData();
        }
    }
}
