using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps.SeventeenthTaskGUI
{
    public partial class NonstandartForm : Form
    {
        public NonstandartForm()
        {
            InitializeComponent();
        }

        private void NonstandartForm_Load(object sender, EventArgs e)
        {
            // Создаем объект GraphicsPath.
            GraphicsPath gp = new GraphicsPath();
            // Прибавляем два круга.
            gp.AddEllipse(0, 0, 100, 100);
            gp.AddEllipse(110, 0, 100, 100);
            // Создаем регион на основе экземпляра GraphicsPath.
            Region r = new Region(gp);
            // Присваиваем созданный регион
            // региону нашего окна.
            this.Region = r;

        }
    }
}
