/*********************************************************************
 * SixSence.PoolTime.Client: Program.cs
 * By: Mitch Trainham
 * Last Updated:
 * 
 * The entry point of the application which initializes the main/parent
 * form.
 *********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DiamondBilliards.PoolTime.Business;

namespace DiamondBilliards.PoolTime.Presentation
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new AppForm() ); // start main/parent form (AppForm)
        }
    }
}
