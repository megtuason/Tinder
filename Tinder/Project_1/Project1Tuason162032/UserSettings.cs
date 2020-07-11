/* Tuason, Margaret Camille L.
 * 162302
 * November 13, 2017
 * 
 * I have not discussed the C# language
 * code in my program with anyone other than my instructor or the
 * teaching assistants assigned to this course.
 * I have not used C# language code
 * obtianed from another person, or any other unauthorized source,
 * either modified or unmodified.
 * Any C# language code or documentation
 * used in my program that was obtained from another source, such as
 * a text book, a web page, or another person, have been clearly
 * noted with proper citation in the comments of my program.
 */
using System;
namespace Project1Tuason162032
{
    public class UserSettings
    {
        public UserSettings()
        {
        }

        public UserSettings(int agestart, int agelimit, string pref)
        {
            start = agestart;
            limit = agelimit;
            genderPref = pref;
        }

        public int start
        {
            get; set;
        }

        public int limit
        {
            get; set;
        }

        public string genderPref
        {
            get; set;
        }
    }
}
/* Get and set was not taught in class.
 * Source: obtained from: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties
 * Date: November 5, 2017
 * Name of Author/Programmer: Microsoft Contributors, Bill Wagner, Mike B, Maira Wenzel, Luke Latham
 */
