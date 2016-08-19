using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
/**
 * Author : Joanne Jung
 * Statudent # : 300432364
 * Date : August 19, 2016
 * Description : generateNameForm class for Final Exam
 */ 
namespace COMP123_S2016_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        // Private Instance Variables
        private List<string> _firstName = new List<string>();
        private List<string> _lastName = new List<string>();
        private Random _random = new Random();
        private Character _character = new Character();

        public GenerateNameForm()
        {
            InitializeComponent();


        }
        private void _generateNames()
        {
            string ranFirstName = this._firstName[this._random.Next(this._firstName.Count)];
            string ranLastName = this._lastName[this._random.Next(this._lastName.Count)];

            FirstNameTextBox.Text = ranFirstName;
            LastNameTextBox.Text = ranLastName;

            _character.FirstName = FirstNameTextBox.Text;
            _character.LastName = LastNameTextBox.Text;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this._generateNames();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            this._generateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityForm = new AbilityGeneratorForm();
            this.Hide();

            abilityForm.Show();
        }



    }
}
