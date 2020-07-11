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
    public partial class MainForm : Form
    {
        public List<Profile> registeredusers = new List<Profile>();
        public List<string> registeredusernames = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm regform = new RegisterForm(registeredusernames);
            if (regform.ShowDialog() == DialogResult.OK)
            {
                registeredusernames.Add(regform.name.ToUpper());
                registeredusers.Add(new Profile(regform.name.ToUpper(), regform.age, regform.userGender.ToUpper(), new UserSettings(regform.agestart, regform.agelimit, regform.userPref.ToUpper())));
                MessageBox.Show(regform.name + " has been successfully registered.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm(registeredusernames);
            if (registeredusers.Count == 0)
            {
                MessageBox.Show("No one is registered into the system.");
            }
            else
            {
                if (loginform.ShowDialog() == DialogResult.OK)
                {
                    string login = loginform.loginName;
                    MenuForm menuform = new MenuForm(registeredusers, login.ToUpper());
                    menuform.welcomeMsg = "Welcome, " + login + " !";
                    if (menuform.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Successfully logged out.");
                    }
                }
                
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
/* Commands not taught in class: DialogResult
* Source: obtained from: https//msdn.microsoft.com/en-us/library/system.windows.forms.dialogresult(v=vs.110).aspx
* Date: November 29, 2017
* Name of Author/Programmer: Microsoft Developer Official Website
*/
