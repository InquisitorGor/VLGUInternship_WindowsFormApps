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
    public partial class InstanceCreatorForm : Form
    {
        public InstanceCreatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type t = Type.GetType("WindowsFormsApp" + textBox1.Text);
            // Создаем переменную по типу.
            ISomeInterface w = (WindowsFormsApps.SeventeenthTaskGUI.ISomeInterface)Activator.CreateInstance(t);
            // Вызываем метод.
            w.SomeMethod();

        }
    }
    public class Class1 : ISomeInterface
    {
        public void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Class1");
        }
    }

    public class Class2 : ISomeInterface
    {
        public void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Class2");
        }
    }
    public interface ISomeInterface
    {
        void SomeMethod();
    }


}
