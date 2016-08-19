using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam_300839401
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Hides the SplashScreen
            Timer.Start();
            this.Hide();

            //Displays the GenerateName Form
            Form GenerateNameForm = new Form();
            GenerateNameForm.Show();
            Timer.Stop();
        }
    }
}
