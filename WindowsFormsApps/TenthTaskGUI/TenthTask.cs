using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApps.TenthTaskGUI
{
    public partial class TenthTask : Form
    {
        public TenthTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillBoxes();
        }
        private void fillBoxes()
        {
            //1
            if (!Directory.Exists("C:\\temp"))
            {
                Directory.CreateDirectory("C:\\temp");
            }
            Directory.CreateDirectory("C:\\temp\\K1");
            Directory.CreateDirectory("C:\\temp\\K2");
            //2.a
            StreamWriter sw = new StreamWriter("C:\\temp\\K1\\t1.txt");
            sw.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
            sw.Close();
            //2.b
            sw = new StreamWriter("C:\\temp\\K1\\t2.txt");
            sw.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            sw.Close();
            //3
            sw = new StreamWriter("C:\\temp\\K2\\t3.txt");
            StreamReader sr = new StreamReader("C:\\temp\\K1\\t1.txt");
            sw.WriteLine(sr.ReadToEnd());
            sr.Close();
            sr = new StreamReader("C:\\temp\\K1\\t2.txt");
            sw.WriteLine(sr.ReadToEnd());
            sr.Close();
            sw.Close();
            //4
            DirectoryInfo directoryInfK1 = new DirectoryInfo("C:\\temp\\K1");
            DirectoryInfo directoryInfK2 = new DirectoryInfo("C:\\temp\\K2");
        
            FileInfo[] fileInf = directoryInfK1.GetFiles();
            foreach (FileInfo fi in fileInf)
            {
                textBox1.AppendText("Full Path: " + fi.FullName.ToString() + " Attributes: " + fi.Attributes.ToString() + " File extension: " + fi.Extension.ToString());
                textBox1.AppendText(Environment.NewLine);
            }
            fileInf = directoryInfK2.GetFiles();
            foreach (FileInfo fi in fileInf)
            {
                textBox2.AppendText("Full Path: " + fi.FullName.ToString() + " Attributes: " + fi.Attributes.ToString() + " File extension: " + fi.Extension.ToString());
                textBox2.AppendText(Environment.NewLine);
            }
            Console.WriteLine("--------------------");
            //5
            File.Move("C:\\temp\\K1\\t2.txt", "C:\\temp\\K2\\t2.txt");
            //6
            File.Copy("C:\\temp\\K1\\t1.txt", "C:\\temp\\K2\\t1.txt");
            //7
            Directory.Move("C:\\temp\\K2", "C:\\temp\\ALL");
            Directory.Delete("C:\\temp\\K1", true);
            //8
            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\temp\\ALL");
            FileInfo[] fileInfo = directoryInfo.GetFiles();
            foreach (FileInfo fi in fileInfo)
            {
                textBox3.AppendText("Full Path: " + fi.FullName.ToString() + " Attributes: " + fi.Attributes.ToString() + " File extension: " + fi.Extension.ToString());
                textBox3.AppendText(Environment.NewLine);
            }
        }
    }
}
