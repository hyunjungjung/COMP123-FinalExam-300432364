using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Author : Joanne Jung
 * Statudent # : 300432364
 * Date : August 19, 2016
 * Description : SplashForm class for Final Exam
 */ 
namespace COMP123_S2016_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            

        }

        private void SplashForm_Shown(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Interval = 3000;
            timer1.Start();
            timer1.Tick += timer1_Tick;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Stop();
            GenerateNameForm generateNameForm = new GenerateNameForm();
            generateNameForm.Show();
            this.Hide();
            this.Close();
            
        }
        


    }
}
