﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace student_management_admin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main_Form_Admin("abc"));
            Application.Run(new Login_Form_Admin());
        }
    }
}
