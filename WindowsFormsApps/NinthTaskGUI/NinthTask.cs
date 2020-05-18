using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApps.NinthTaskGUI
{
    public partial class NinthTask : Form
    {
        private const String PATH = "..\\..\\NinthTaskGUI\\File.txt";
        private const String PATH2 = "..\\..\\NinthTaskGUI\\File2.txt";

        public NinthTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") { 
                writeToFile();
                displayFileData();
            }

        }
        private void writeToFile()
        {
            FileStream f = new FileStream(PATH, FileMode.Open);
            BinaryWriter fOut = new BinaryWriter(f);
            char[] chArray = textBox1.Text.ToCharArray();
            for (int i = 0; i < chArray.Length; i++)
            {
                if (!Char.IsDigit(chArray[i])) fOut.Write(chArray[i]);
            }
            fOut.Close();
        }
        private void displayFileData()
        {
            String fileData = File.ReadAllText(PATH);
            textBox2.Text = fileData;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                correctText();
                displayData();
            }
        }
        private void correctText()
        {
            FileStream fileStream = new FileStream(PATH, FileMode.OpenOrCreate);
            StreamReader sR = new StreamReader(fileStream);
            String str1 = String.Empty;
            int count = 1;
            while ((str1 = sR.ReadLine()) != null && str1 != String.Empty)
            {
                File.AppendAllText(PATH2, str1 + " " + count++ + Environment.NewLine);
            }
            sR.Close();
            fileStream.Close();
        }
        private void displayData()
        {
            textBox3.Text = File.ReadAllText(PATH2);
        }
    }
}
