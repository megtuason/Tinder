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
    public partial class MenuForm : Form
    {
        List<Profile> regUsers = new List<Profile>();
        string login;
        public MenuForm(List<Profile> registeredusers, string name)
        {
            login = name;
            regUsers = registeredusers;
            InitializeComponent();
        }

        public string welcomeMsg
        {
            set { label2.Text = value; }
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            if (regUsers.Count == 1)
            {
                MessageBox.Show("No other person has registered.");
            }
            else
            {
                foreach (Profile a in regUsers)
                {
                    if (a.profName == login.ToUpper())
                    {
                        MatchForm matchform = new MatchForm(regUsers, login);
                        matchform.genderPref = "Show Me: " + a.GenderPref;
                        matchform.ageRange = "Age Range " + a.AgeStart + " - " + a.AgeLimit;
                        int i = 0;
                        do
                        {
                            if (a.numAccounts == 10)
                            {
                                MessageBox.Show("Your matches are full.");
                                break;
                            }
                            else
                            {
                                if (a.userlikes.Contains(regUsers[i]))
                                {
                                    i++;
                                }
                                else
                                {
                                    int pos = Array.IndexOf(a.matches, regUsers[i]);
                                    if (pos > -1)
                                    {
                                        i++;
                                    }
                                    else if ((regUsers[i] != a) && (regUsers[i].profGender == a.GenderPref) && (a.profGender == regUsers[i].GenderPref) && (regUsers[i].profAge >= a.AgeStart) && (regUsers[i].profAge <= a.AgeLimit) && (a.profAge <= regUsers[i].AgeLimit) && (a.profAge >= regUsers[i].AgeStart))
                                    {
                                        matchform.matchedName = regUsers[i].profName;
                                        matchform.matchedAge = regUsers[i].profAge.ToString();
                                        matchform.matchedGender = regUsers[i].profGender;
                                        if (matchform.ShowDialog() == DialogResult.OK)
                                        {
                                            MessageBox.Show("Changes have been made.");
                                        }
                                    }
                                    else
                                    {
                                        i++;
                                    }
                                }
                            }

                        }
                        while (i != regUsers.Count);
                        {
                            MessageBox.Show("No more matches available.");
                        }   
                    }
                }
            }
        }

        private void btnViewMatches_Click(object sender, EventArgs e)
        {
            ViewMatchesForm vmf = new ViewMatchesForm(regUsers, login);
            foreach (Profile a in regUsers)
            {
                if (a.profName == login)
                {
                    if (a.numAccounts == 0)
                    {
                        MessageBox.Show("You have no matches.");
                    }
                    else
                    {
                        for (int i = 0; i < a.numAccounts; i++)
                        {
                            string num = (i + 1).ToString();
                            string nameview = a.matches[i].profName;
                            string genderview = a.matches[i].profGender;
                            string ageview = a.matches[i].profAge.ToString();
                            vmf.dataGrid.Rows.Add(num, nameview, genderview, ageview);
                        }
                        vmf.totMatches = "Total Matches: " + a.numAccounts.ToString();
                        if(vmf.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Going back to menu..");
                        }
                    }
                }
            }

        }

        private void btnViewPeopleList_Click(object sender, EventArgs e)
        {
            ViewPeopleForm vpf = new ViewPeopleForm();
            if (regUsers.Count == 1)
            {
                MessageBox.Show("There are no other registed users.");
            }
            else
            {
                foreach (Profile a in regUsers)
                {
                    if (a.profName != login)
                    {
                        string num = (regUsers.IndexOf(a) + 1).ToString();
                        string nameview = a.profName;
                        string genderview = a.profGender;
                        string ageview = a.profAge.ToString();
                        vpf.dataGridP.Rows.Add(num, nameview, genderview, ageview);
                    }
                }
                vpf.vpfUsers = "Total Registered: " + regUsers.Count;
                if (vpf.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Going back to menu..");
                }
            }
        }

        private void btnEditUserSettings_Click(object sender, EventArgs e)
        {
            EditUserSettingsForm eusf = new EditUserSettingsForm(regUsers, login);
            foreach (Profile a in regUsers)
            {
                if (a.profName == login)
                {
                    eusf.editShow = "Show Me: " + a.GenderPref;
                    eusf.editAge = "Age Range: " + a.AgeStart + " - " + a.AgeLimit;
                    if (eusf.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Going back to menu..");
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
/* Commands not taught in class: DialogResult
* Source: obtained from: https//msdn.microsoft.com/en-us/library/system.windows.forms.dialogresult(v=vs.110).aspx
* Date: November 29, 2017
* Name of Author/Programmer: Microsoft Developer Official Website
*/
