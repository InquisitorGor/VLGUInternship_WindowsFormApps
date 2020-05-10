using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps.SixthTask
{
    public partial class SixthTask1 : Form
    {
        private int[] oneDimArray;
        private int[,] twoDimArray;
        public SixthTask1()
        {
            InitializeComponent();
        }

        private void DGVStructureListiner(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text == "")
            {
                defineDGVStricture(Convert.ToInt32(textBox1.Text));
            }
            else
            {
                defineDGVStricture(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            }
        }
        private void defineDGVStricture(int size)
        {
            dataGridView1.ColumnCount = size;
            oneDimArray = new int[size];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void DGVGetDataListiner(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text == "")
            {
                getDataForOneDimentionalArray();
            }
            else
            {
                getDataForTwoDimentionalArray();
            }

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
            showFiltredData();
        }
        private void showFiltredData()
        {
            if (textBox1.Text != "" && textBox2.Text == "")
            {
                oneDimArray = oneDimArray.Where(x => x > Convert.ToInt32(textBox4.Text) || x < Convert.ToInt32(textBox3.Text)).ToArray();
                dataGridView1.ColumnCount = oneDimArray.Length;
                for (int i = 0; i < oneDimArray.Length; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = oneDimArray[i];
                }
            }
            else
            {
                int count = 0;
                foreach (var x in twoDimArray)
                {
                    if (x > Convert.ToInt32(textBox4.Text) || x < Convert.ToInt32(textBox3.Text)) count++;
                }
                oneDimArray = new int[count];
                int index = 0;
                foreach (var x in twoDimArray)
                {
                    if (x > Convert.ToInt32(textBox4.Text) || x < Convert.ToInt32(textBox3.Text)) oneDimArray[index++] = x; ;
                }
                dataGridView1.RowCount = 1;
                dataGridView1.ColumnCount = count;
                for (int i = 0; i < oneDimArray.Length; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = oneDimArray[i];
                }

            }
        }
        private void defineDGVStricture(int lines, int columns)
        {
            dataGridView1.RowCount = lines;
            dataGridView1.ColumnCount = columns;
            twoDimArray = new int[lines, columns];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void getDataForTwoDimentionalArray()
        {
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                {
                    twoDimArray[rows, col] = Convert.ToInt32(dataGridView1.Rows[rows].Cells[col].Value);
                }
            }
            showFiltredData();
        }

        private void MaxABSButtonListiner(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text == "")
            {
                findMaxABS();
            }
        }
        private void findMaxABS()
        {
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                {
                    oneDimArray[col] = Convert.ToInt32(dataGridView1.Rows[rows].Cells[col].Value);
                }
            }
            textBox5.Text = Convert.ToString(oneDimArray.Select(Math.Abs).Max());
        }
        private void strangeOrderButtonListiner(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                int lines = Convert.ToInt32(textBox1.Text);
                int columns = Convert.ToInt32(textBox2.Text);

                dataGridView1.RowCount = lines;
                dataGridView1.ColumnCount = columns;

                int value = 1;

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        dataGridView1.Rows[j].Cells[i].Value = Convert.ToString(value++);
                    }
                    if (i + 1 == columns) break;
                    dataGridView1.Rows[lines - 1].Cells[++i].Value = Convert.ToString(value++);
                    if (i + 1 == columns) break;
                    ++i;
                    for (int j = lines - 1; j >= 0; j--)
                    {
                        dataGridView1.Rows[j].Cells[i].Value = Convert.ToString(value++);
                    }
                    if (i + 1 == columns) break;
                    dataGridView1.Rows[0].Cells[++i].Value = Convert.ToString(value++);
                    if (i + 1 == columns) break;

                }
            }

        }
        private void getLineSum()
        {
            int sum = 0;
            for (int i = 0; i < twoDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimArray.GetLength(1); j++)
                {
                    if (twoDimArray[i,j] < Convert.ToInt32(textBox3.Text) || 
                        twoDimArray[i,j] > Convert.ToInt32(textBox4.Text)) sum += twoDimArray[i, j];
                }
                oneDimArray[i] = sum;
                sum = 0;

            }
        }

        private void sumButtonListiner(object sender, EventArgs e)
        {
            getDataForTwoDimentionalArray1();
        }
        private void getDataForTwoDimentionalArray1()
        {
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                {
                    twoDimArray[rows, col] = Convert.ToInt32(dataGridView1.Rows[rows].Cells[col].Value);
                }
            }
            oneDimArray = new int[Convert.ToInt32(textBox1.Text)];
            getLineSum();
            dataGridView1.ColumnCount = oneDimArray.Length;
            dataGridView1.RowCount = 1;
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                {
                    dataGridView1.Rows[rows].Cells[col].Value = Convert.ToString(oneDimArray[col]);
                }
            }
        }
    }
}
