﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps.SeventeenthTaskGUI
{
    public partial class CatalogTreeViewForm : Form
    {
        public CatalogTreeViewForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем все диски (a:, c: и т.д.).
            string[] drives = Directory.GetLogicalDrives();
            foreach (string s in drives)
            {
                // Добавляем корневой элемент для каждого диска.
                TreeNode tn = treeView1.Nodes.Add(s);
                // Добавляем фиктивный подузел для каждого
                // диска (для появления квадратика с плюсиком).
                tn.Nodes.Add("");
                // Устанавливаем свойство tag.
                // Пустое значение свойства ("") - узел еще не раскрывался.
                // Плюс ("+") - узел раскрывался и в него были
                // добавлены нужные подузлы.
                tn.Tag = "";

            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // Добавление подузлов перед раскрытием.
            NodeExpand(e.Node);
        }
        private void NodeExpand(TreeNode tn)
        {
            // Если есть подузлы.
            if (tn.Nodes.Count != 0)
            {
                // Если раскрываем в первый раз.
                if (((string)tn.Tag) == "")
                {
                    // Удаляем фиктивный узел.
                    tn.Nodes.RemoveAt(0);
                    // Добавляем подузлы.
                    AddTreeNodes(tn);
                    // Устнавливаем признак того, что
                    // узел уже раскрывали и добавили в него все подузлы.
                    tn.Tag = "+";
                }
            }
        }
        // Получение полного имени папки по узлу.
        private String GetFullPath(TreeNode tn)
        {
            // Устанавливаем текуший узел на переданный в параметре.
            TreeNode currNode = tn;
            // В полное имя пока записываем текст,
            // показываемый в текущем узле.
            String fullPath = currNode.Text;
            // Двигаемся к корню дерева.
            while (currNode.Parent != null)
            {
                // Переходим на родительский узел.
                currNode = currNode.Parent;
                // К полному имени слева приписываем текст родитеского узла и символ "\".
                fullPath = currNode.Text + @"\" + fullPath;
            }
            // Возвращаем полный путь.
            return fullPath + @"\";
        }
        // Добавление подузлов.
        private void AddTreeNodes(TreeNode tn)
        {
            TreeNode aux;
            // Получаем полный путь для папки узла.
            DirectoryInfo d = new DirectoryInfo(GetFullPath(tn));
            // Массив для хранения подпапок.
            DirectoryInfo[] ds;
            try
            {
                // Получаем все подпапки для папки.
                ds = d.GetDirectories();

                // Для каждой папки выводим ее имя и имена всех подпапок.
                foreach (DirectoryInfo s in ds)
                {
                    // Добавляем каждую подпапку.
                    aux = tn.Nodes.Add(s.Name);
                    // Устанавливаем для нее признак, что ее еще не раскрывали.
                    aux.Tag = "";
                    try
                    {
                        // Если она не пуста,
                        if (s.GetDirectories().GetLength(0) != 0)
                        {
                            //  то добавляем в нее фиктивный узел.
                            aux.Nodes.Add("");
                        }
                    }
                    // Перехватываем исключение запрещенного доступа.
                    catch (UnauthorizedAccessException) { }
                }
            }
            //Перехват общего исключения (например, если диск a: не вставлен).
            catch (Exception)
            {
            }
        }


    }
}
