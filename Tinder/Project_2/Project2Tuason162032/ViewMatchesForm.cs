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
    public partial class ViewMatchesForm : Form
    {
        List<Profile> regUsers = new List<Profile>();
        public DataGridView dataGrid
        {
            get { return dataGridView1; }
        }

        public string totMatches
        {
            set { totalMatches.Text = value; }
        }
        string login;
        public ViewMatchesForm(List<Profile> registeredusers, string name)
        {
            regUsers = registeredusers;
            login = name;
            InitializeComponent();
        }

        private void btnUnmatch_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string delmatch = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                foreach (Profile a in regUsers)
                {
                    if (a.profName == login)
                    {
                        foreach (Profile b in regUsers)
                        {
                            if (b.profName == delmatch)
                            {
                                int y = Array.IndexOf(a.matches, b);
                                for (int i = y; i > a.numAccounts; i++)
                                {
                                    a.matches[i] = a.matches[i + 1];
                                }
                                a.matches[a.numAccounts - 1] = null;
                                a.numAccounts--;

                                int z = Array.IndexOf(b.matches, a);
                                for (int i = z; i > b.numAccounts; i++)
                                {
                                    b.matches[i] = b.matches[i + 1];
                                }
                                b.matches[b.numAccounts - 1] = null;
                                b.numAccounts--;
                                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                                totalMatches.Text = "Total Matches: " + a.numAccounts.ToString();
                                feedback.Text = "The match has been deleted.";
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select 1 row.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
