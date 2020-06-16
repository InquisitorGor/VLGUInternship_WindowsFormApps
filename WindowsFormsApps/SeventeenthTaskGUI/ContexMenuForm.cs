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
    public partial class ContexMenuForm : Form
    {
        public ContexMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание контекстного меню
            ContextMenuStrip cms = new ContextMenuStrip();

            // Добавление существующих элементов меню к элементам контекстного меню
            cms.Items.AddRange(new ToolStripItem[]
            {

                this.cutToolStripMenuItem,
                this.copyToolStripMenuItem,
                this.pasteToolStripMenuItem
            });

            // Подсоединение контекстного меню к главному окну.
            this.ContextMenuStrip = cms;

        }
    }
}
