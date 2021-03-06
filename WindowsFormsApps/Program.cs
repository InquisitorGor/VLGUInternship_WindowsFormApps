﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApps.FourthTaskGUI;
using WindowsFormsApps.SecondTaskGUI;
using WindowsFormsApps.FifthTaskGUI;
using WindowsFormsApps.ThirdTaskGUI;
using WindowsFormsApps.SixthTask;
using WindowsFormsApps.SeventhTaskGUI;
using WindowsFormsApps.EightTaskGUI;
using WindowsFormsApps.NinthTaskGUI;
using WindowsFormsApps.TenthTaskGUI;
using WindowsFormsApps.EleventhTask;
using WindowsFormsApps.ThirteenthTaskGUI;
using WindowsFormsApps.FourteenthTaskGUI;
using WindowsFormsApps.SeventeenthTaskGUI;

namespace WindowsFormsApps
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FirstTask());
            //Application.Run(new SecondTaskCoordinate());
            //Application.Run(new OtherTasks());
            //Application.Run(new ThirdTask());
            //Application.Run(new FourthTask());
            //Application.Run(new FifthTask());
            //Application.Run(new SixthTask1());
            //Application.Run(new SevenTask());
            //Application.Run(new EightTask());
            //Application.Run(new NinthTask());
            //Application.Run(new TenthTask());
            //Application.Run(new OneDimArray());
            //Application.Run(new ThirteenthTask());
            Application.Run(new MainForm());
            //Application.Run(new SeventeenthTask());
            //Application.Run(new ThreadForm());
            //Application.Run(new XMLForm());
            //Application.Run(new MenuForm());
            //Application.Run(new ContexMenuForm());
            //Application.Run(new NonstandartForm());
            //Application.Run(new FontListForm());
            //Application.Run(new TreeViewForm());
            //Application.Run(new CatalogTreeViewForm());
            //Application.Run(new InstanceCreatorForm());
            //Application.Run(new HyperLinkForm());
            //Application.Run(new PopupForm());
            //Application.Run(new GetDataForm());
            //Application.Run(new ColorDialogForm());
            //Application.Run(new SettingsForm());
            //Application.Run(new FontForm());
            //Application.Run(new OpenFileForm());
            //Application.Run(new SaveDialogForm());
            //Application.Run(new ButtonForm());
        }
        
    }
}
