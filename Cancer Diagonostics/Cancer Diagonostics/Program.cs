using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cancer_Diagonostics
{
    internal static class Program
    {
        /// <summary>
        /// The desktop application aims to provide a user-friendly platform for verifying medical results using AI technology. 
        /// It is intended to be used similarly to a calculator or traditional medical forms, offering quick validation of medical data.
        /// The interface is designed to be functional, and to be easy to use with frequency (i.e colour to help distinguing the diferent pages, to the point etc...
        /// the app isn't design to be used in "fullscreen", it will work but the label and button will not scale, this is due to my lack of knowlegde of how to do suchs
        /// 
        /// Also I am obligated to say this, DO NOT TAKE THE RESULT SERIOUSRLY, although it can be use as such, the datasets used to train them are limited in scope and size,
        /// and due to being unable to test the application on real people, accurace is not guarantee so be advised
        /// 
        /// 
        /// Made by:
        /// Miguel Relvas
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            // this line is to allow the application to be sharp as possible i.e match the moniter quality of pixels or in short words it makes the application HD
            if(Environment.OSVersion.Version.Major >= 6) { SetProcessDPIAware(); }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        //Execute this in x64, this AI model is very picky 
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
