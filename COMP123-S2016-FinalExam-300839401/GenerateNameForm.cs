using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam_300839401
{
    public partial class GenerateNameForm : Form
    {
        private Random _random;

        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private Int32 Roll()
        {
            List<Int32> numbers = new List<Int32>();
            int result = 0;

            for (int count = 0; count < 50; count++)
            {
                int generatedNumber = this._random.Next(0, 49) + 1;
                numbers.Add(generatedNumber);
            }

            numbers.Remove(numbers.Min());

            foreach (int number in numbers)
            {
                result += number;
            }

            return result;
        }

        //Generates first name and last name
        public void GenerateNames()
        {
            FirstNameTextBox.Text = this.Roll().ToString();
            LastNameTextBox.Text = this.Roll().ToString();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinalForm AbilityGeneratorForm = new FinalForm();

            AbilityGeneratorForm.abilityGeneratorForm = this;

            AbilityGeneratorForm.Show();

            this.Hide();
        }
    }
}
