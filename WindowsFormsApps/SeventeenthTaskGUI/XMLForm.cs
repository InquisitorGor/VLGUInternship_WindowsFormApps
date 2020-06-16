using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApps.SeventeenthTaskGUI
{
    public partial class XMLForm : Form
    {
        public XMLForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем новый xml-документ.
            XmlDocument xml = new XmlDocument();
            // Загружаем в xml-документ xml-файл.
            xml.Load("1.xml");
            // Берем корневой узел (тег) xml-документа.
            XmlNode d = xml.DocumentElement;
            // Берем все дочерние теги.
            XmlNodeList xnl = d.ChildNodes;
            // Перебираем все дочерние теги.
            for (int i = 0; i < d.ChildNodes.Count; i++)
            {
                // Выводим атрибуты тегов.
                MessageBox.Show(xnl[i].Attributes["text"].Value + " " +
                    xnl[i].Attributes["rustext"].Value);
            }

        }
    }
}
