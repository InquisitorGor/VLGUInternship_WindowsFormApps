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
    public partial class MenuForm : Form
    {
        public int num = 0;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Увеличиваем счетчик пунктов меню.
            num++;
            // Создаем новый подпункт меню.
            // Для него задаем надпись
            // и обработчик выбора пользователем этого пункта.
            ToolStripMenuItem mi = new ToolStripMenuItem(num.ToString());
            mi.Click += this.ToolStripMenuItem_Click;
            // Подсоединяем новый пункт меню к главному меню формы.
            toolStripMenuItem1.DropDownItems.Add(mi);

        }
        private void ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // Читаем текст на выбранном пользователе пункте меню.
            string s = ((ToolStripMenuItem)sender).Text;
            // Выводим этот текст.
            MessageBox.Show(s);
        }

    }
}
