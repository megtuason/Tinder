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
    public partial class EditAgeRangeForm : Form
    {
        List<Profile> regUsers = new List<Profile>();
        string login;
        public EditAgeRangeForm(List<Profile> registeredusers, string name)
        {
            regUsers = registeredusers;
            login = name;
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int newstart = int.Parse(tbAgeStart.Text);
            int newlimit = int.Parse(tbAgeLimit.Text);
            foreach (Profile a in regUsers)
            {
                if (a.profName == login)
                {
                    if (newstart < 18)
                    {
                        MessageBox.Show("Age start is too low.");
                    }
                    else
                    {
                        if (newstart > newlimit)
                        {
                            MessageBox.Show("Age start is greater than age limit.");
                        }
                        else
                        {
                            a.AgeStart = newstart;
                            a.AgeLimit = newlimit;
                            DialogResult = DialogResult.OK;

                        }
                    }
                }
            }
        }
    }
}
/* Commands not taught in class: DialogResult
 * Source: obtained from: https//msdn.microsoft.com/en-us/library/system.windows.forms.dialogresult(v=vs.110).aspx
 * Date: November 29, 2017
 * Name of Author/Programmer: Microsoft Developer Official Website
 */
