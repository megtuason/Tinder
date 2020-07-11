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
    public partial class MatchForm : Form
    {
        List<Profile> regUsers = new List<Profile>();

        public string genderPref
        {
            set { userGenderPref.Text = value; }
        }

        public string ageRange
        {
            set { userAgeRange.Text = value; }
        }

        public string matchedName
        {
            set { matchName.Text = value; }
        }

        public string matchedAge
        {
            set { matchAge.Text = value; }
        }

        public string matchedGender
        {
            set { matchGender.Text = value; }
        }
        string login;
        public MatchForm(List<Profile> registeredusers, string loginname)
        {
            regUsers = registeredusers;
            login = loginname;
            InitializeComponent();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            string name = matchName.Text;
            foreach (Profile a in regUsers)
            {
                if (a.profName == login)
                {
                    foreach (Profile b in regUsers)
                    {
                        if (b.profName == name.ToUpper())
                        {
                            if (b.userlikes.Contains(a))
                            {
                                a.matches[a.numAccounts] = b;
                                b.matches[b.numAccounts] = a;
                                a.numAccounts++;
                                b.numAccounts++;
                                b.userlikes.RemoveAt(b.userlikes.IndexOf(a));
                                MessageBox.Show(b.profName + " is a match!");
                                DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                a.userlikes.Add(b);
                                MessageBox.Show(b.profName + " has been liked!");
                                DialogResult = DialogResult.OK;
                            }
                        }
                    }
                }
            }  
        }

        private void btnNo_Click(object sender, EventArgs e)
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
