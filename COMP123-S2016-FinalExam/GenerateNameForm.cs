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

        // constructor
        public GenerateNameForm()
        {
            InitializeComponent();


        }
        // private methods
        private void _generateNames()
        {

            Random ran = new Random();

            FirstNameTextBox.Text = FirstNameListBox.ToString();
            LastNameTextBox.Text = LastNameListBox.ToString();

            Program.character.FirstName = FirstNameTextBox.ToString();
            Program.character.LastName = LastNameTextBox.ToString();

            //int num_firstName = FirstNameListBox.Items.Count;
            //string[] firstName = new string[num_firstName];
            //FirstNameListBox.Items.CopyTo(firstName, 0);

            //int num_lastName = LastNameListBox.Items.Count;
            //String[] lastName = new string[num_lastName];
            //LastNameListBox.Items.CopyTo(lastName, 0);

            //for (int i = 0; i < num_firstName; i++)
            //{
            //    _character.FirstName = FirstNameTextBox.Text;
            //}

            //for (int i = 0; i < num_lastName; i++)
            //{
            //    _character.LastName = LastNameTextBox.Text;
            //}
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
