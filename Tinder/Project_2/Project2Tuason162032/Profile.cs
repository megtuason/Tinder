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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Tuason162032
{
    public class Profile
    {
        public List<Profile> userlikes = new List<Profile>();
        public Profile[] matches;
        public int numAccounts = 0;
        int max = 10;

        UserSettings usersettings = new UserSettings();

        public Profile (string name, int age, string gender, UserSettings us)
        {
            profName = name;
            profAge = age;
            profGender = gender;
            usersettings = us;
            matches = new Profile[max];
        }

        public string profName
        {
            get; set;
        }

        public int profAge
        {
            get; set;
        }

        public string profGender
        {
            get; set;
        }

        public string GenderPref
        {
            get { return usersettings.genderPref; }
            set { usersettings.genderPref = value; }
        }

        public int AgeStart
        {
            get { return usersettings.start; }
            set { usersettings.start = value; }
        }
        
        public int AgeLimit
        {
            get { return usersettings.limit; }
            set { usersettings.limit = value; }
        }
    }
}
/* Commands not taught in class: DialogResult
* Source: obtained from: https//msdn.microsoft.com/en-us/library/system.windows.forms.dialogresult(v=vs.110).aspx
* Date: November 29, 2017
* Name of Author/Programmer: Microsoft Developer Official Website
*/
