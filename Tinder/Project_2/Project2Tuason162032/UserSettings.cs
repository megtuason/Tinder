﻿/*Tuason, Margaret Camille L.
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
