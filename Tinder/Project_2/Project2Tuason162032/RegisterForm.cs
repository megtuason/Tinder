/*Tuason, Margaret Camille L.
 * 162032
 * December 4, 2017
 * I have not discussed the C# language
 * code in my program with anyone other than my instructor or the
 * teaching assistants assigned to this course.
 * I have not used C# language code
 * obtained from another person, or any other unauthorized source,
 * either modified or unmodified. 
 * Any C# language code or documentation
 * used in my program that was obtained from another source, such as
 * a text book, a web page, or another person, have been clearly 
 * noted with proper citation in the comments of my program.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2Tuason162032
{
    public partial class RegisterForm : Form
    {
        List<string> regusers = new List<string>();
        public RegisterForm(List<string> registeredusernames)
        {
            regusers = registeredusernames;
            InitializeComponent();
        }

        public string name
        {
            get { return tbName.Text; }
        }
        public int age
        {
            get { return int.Parse(tbAge.Text); }
        }
        public int agestart
        {
            get { return int.Parse(tbAgeStart.Text); }
        }
        public int agelimit
        {
            get { return int.Parse(tbAgeLimit.Text); }
        }
        string gender;
        string pref;

        public string userPref
        {
            get { return pref; }
        }
        public string userGender
        {
            get { return gender; }
        }
        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (regusers.Contains(name.ToUpper()))
            {
                MessageBox.Show("The person has already been registered.");
            }
            else if (age < 18)
            {
                MessageBox.Show("The person is too young to join.");
            }
            else if (agestart < 18)
            {
                MessageBox.Show("Age start is too low.");
            }
            else if (agestart > agelimit)
            {
                MessageBox.Show("Age start is higher than age limit.");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = !checkBox1.Checked;
            gender = checkBox1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox2.Checked;
            gender = checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = !checkBox3.Checked;
            pref = checkBox3.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = !checkBox4.Checked;
            pref = checkBox4.Text;
        }
    }
}
/* Commands not taught in class: DialogResult
* Source: obtained from: https//msdn.microsoft.com/en-us/library/system.windows.forms.dialogresult(v=vs.110).aspx
* Date: November 29, 2017
* Name of Author/Programmer: Microsoft Developer Official Website
*/
