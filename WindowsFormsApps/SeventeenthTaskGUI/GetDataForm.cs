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
    public partial class GetDataForm : Form
    {
        public GetDataForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр класса, соответствующего второй форме
            GetDataForm2 f = new GetDataForm2();
            // Если нажата кнопка OK
            if (f.ShowDialog() == DialogResult.OK)
            {
                // то передаем данные из текстового поля второй формы в поле на первой форме
                textBox1.Text = f.textBox1.Text;
            }

        }
    }
}
