using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * APP Name: Character Builder
 * Author: Zun Dai
 * Student ID: 300839401
 * Date modified: 2016-08-19
 * Program description: Final Test
 */

namespace COMP123_S2016_FinalExam_300839401
{
    public static class Program
    {
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}
