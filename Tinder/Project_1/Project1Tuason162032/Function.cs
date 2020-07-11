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
using System.Collections.Generic;
namespace Project1Tuason162032
{
    public class Function
    {
        public List<Profile> registeredusers = new List<Profile>();
        public List<string> registeredusernames = new List<string>();

        public Function()
        {
        }

        public void Register()
        {
            Console.WriteLine("=====REGISTER=====");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            if (registeredusernames.Contains(name.ToUpper()))
            {
                Console.WriteLine("{0} HAS ALREADY BEEN REGISTERED.", name);
            }
            else
            {
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.Write("Gender: ");
                    string gender = Console.ReadLine();
                    if ((gender.ToUpper() == "F") || (gender.ToUpper() == "M"))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter your preferences");
                        Console.WriteLine("M for MALES, F for FEMALES");
                        Console.Write("Show Me: ");
                        string pref = Console.ReadLine();
                        if ((pref.ToUpper() == "F") || (pref.ToUpper() == "M"))
                        {
                            Console.Write("Age Start: ");
                            int agestart = int.Parse(Console.ReadLine());
                            if (agestart < 18)
                            {
                                Console.WriteLine("AGE START IS TOO LOW");
                            }
                            else if (agestart >= 18)
                            {
                                Console.Write("Age Limit: ");
                                int agelimit = int.Parse(Console.ReadLine());
                                if (agestart < agelimit)
                                {
                                    registeredusernames.Add(name.ToUpper());
                                    registeredusers.Add(new Profile(name.ToUpper(), age, gender.ToUpper(), new UserSettings(agestart, agelimit, pref.ToUpper())));
                                    Console.WriteLine("{0} HAS BEEN SUCCESSFULLY REGISTERED.", name.ToUpper());
                                }
                                else
                                {
                                    Console.WriteLine("AGE START IS GREATER THAN THE AGE LIMIT");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("INVALID GENDER");
                        }
                    }
                    else
                    {
                        Console.WriteLine("INVALID GENDER");
                    }
                }
                else
                {
                    Console.WriteLine("PERSON IS TOO YOUNG TO JOIN");
                }

            }
        }

        public void Match(string name)
        {
            Console.WriteLine();
            Console.WriteLine("=====MATCH=====");
            if (registeredusers.Count == 1)
            {
                Console.WriteLine();
                Console.WriteLine("NO OTHER PEOPLE HAVE BEEN REGISTERED.");
            }
            else if (registeredusers.Count >= 2)
            {
                foreach (Profile a in registeredusers)
                {
                    if (a.profName == name.ToUpper())
                    {
                        Console.WriteLine("Show Me: {0}", a.GenderPref);
                        Console.WriteLine("Age Range: {0} - {1}", a.AgeStart, a.AgeLimit);
                        Console.WriteLine();
                        int i = 0;
                        do
                        {
                            if (a.numAccounts < 10)
                            {
                                if (a.userlikes.Contains(registeredusers[i]))
                                {
                                    i++;
                                }
                                else
                                {
                                    int pos = Array.IndexOf(a.matches, registeredusers[i]);
                                    if (pos > -1)
                                    {
                                        i++;
                                    }
                                    else if ((registeredusers[i] != a) && (registeredusers[i].profGender == a.GenderPref) && (a.profGender == registeredusers[i].GenderPref) && (registeredusers[i].profAge >= a.AgeStart) && (registeredusers[i].profAge <= a.AgeLimit))
                                    {
                                        Console.WriteLine("Name: {0}", registeredusers[i].profName);
                                        Console.WriteLine("Age: {0}", registeredusers[i].profAge);
                                        Console.WriteLine("Gender: {0}", registeredusers[i].profGender);
                                        Console.WriteLine();
                                        Console.WriteLine("1 Like");
                                        Console.WriteLine("2 No");
                                        Console.Write("Enter choice: ");
                                        int choice = int.Parse(Console.ReadLine());
                                        Console.WriteLine();
                                        if (choice == 1)
                                        {
                                            if (registeredusers[i].userlikes.Contains(a))
                                            {
                                                a.matches[a.numAccounts] = registeredusers[i];
                                                registeredusers[i].matches[registeredusers[i].numAccounts] = a;
                                                a.numAccounts++;
                                                registeredusers[i].numAccounts++;
                                                registeredusers[i].userlikes.RemoveAt(registeredusers[i].userlikes.IndexOf(a));
                                                Console.WriteLine("{0} IS A MATCH!", registeredusers[i].profName);
                                                i++;
                                            }
                                            else
                                            {
                                                a.userlikes.Add(registeredusers[i]);
                                                Console.WriteLine("{0} HAS BEEN LIKED!", registeredusers[i].profName);
                                                Console.WriteLine();
                                                i++;
                                            }
                                        }
                                        else if (choice == 2)
                                        {
                                            i++;
                                        }
                                    }
                                    else
                                    {
                                        i++;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("YOUR MATCHES ARE FULL.");
                                break;
                            }

                        }
                        while (i != registeredusers.Count);
                        {
                            Console.WriteLine("NO MORE MATCHES AVAILABLE.");
                        }
                    }
                }
            }
        }

        public void Unmatch (string name)
        {
            foreach(Profile a in registeredusers)
            {
                if (a.profName == name.ToUpper())
                {
                    Console.WriteLine("=====UNMATCH=====");
                    if (a.numAccounts == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("YOU HAVE NO MATCHES.");
                    }
                    else
                    {
                        Console.WriteLine("ID\tNAME\tGENDER\tAGE");
                        for (int i = 0; i < a.numAccounts; i++)
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", i+1, a.matches[i].profName, a.matches[i].profGender, a.matches[i].profAge);
                        }
                        Console.WriteLine("TOTAL MATCHES: {0}", a.numAccounts);
                        Console.Write("Enter ID: ");
                        int id = int.Parse(Console.ReadLine());
                        if (id <= a.numAccounts)
                        {
                            for (int i = id - 1; i < a.numAccounts; i++)
                            {
                                a.matches[i] = a.matches[i+1];
                            }
                            a.matches[a.numAccounts - 1] = null;
                            a.numAccounts--;

                            foreach (Profile b in registeredusers)
							{
								if (b.profName == a.matches[id - 1].profName)
								{
                                    int y = Array.IndexOf(b.matches, a);
                                    for (int i = y; i > b.numAccounts; i++)
                                    {
                                        b.matches[i] = b.matches[i+1];
                                    }
                                    b.matches[b.numAccounts - 1] = null;
                                    b.numAccounts--;
								}
							}
                            Console.WriteLine("THE MATCH HAS BEEN DELETED.");
                        }
                        else
                        {
                            Console.WriteLine("INVALID ID");
                        }
                    }
                }
            }
        }

        public void EditUser(string name)
        {
            Console.WriteLine("=====EDIT USER SETTINGS=====");
            foreach (Profile a in registeredusers)
            {
                if (a.profName == name.ToUpper())
                {
                    Console.WriteLine("Show Me: {0}", a.GenderPref);
                    Console.WriteLine("Age Range: {0} - {1}", a.AgeStart, a.AgeLimit);
                    Console.WriteLine();
                    Console.WriteLine("1 Change Show Me");
                    Console.WriteLine("2 Change Age Range");
                    Console.Write("Enter choice: ");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("M for MALES, F for FEMALES");
                        Console.Write("Show Me: ");
                        string changepref = Console.ReadLine();
                        if ((changepref.ToUpper() == "F") || (changepref.ToUpper() == "M"))
                        {
                            a.GenderPref = changepref;
                            Console.WriteLine("SHOW ME SETTINGS HAVE CHANGED.");
                        }
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Set Age Start: ");
                        int newages = int.Parse(Console.ReadLine());
                        if (newages >= 18)
                        {
                            a.AgeStart = newages;
                            Console.Write("Set Age Limit: ");
                            int newagel = int.Parse(Console.ReadLine());
                            if (newages > newagel)
                            {
                                Console.WriteLine("AGE START IS GREATER THAN AGE LIMIT.");
                            }
                            else
                            {
                                a.AgeLimit = newagel;
                                Console.WriteLine("AGE RANGE HAS CHANGED.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("AGE START IS TOO LOW");
                        }
                    }
                }
            }
        }

        public void ViewMatches(string name)
        {
            Console.WriteLine("=====VIEW MATCHES=====");
            foreach(Profile a in registeredusers)
            {
                if (a.profName == name.ToUpper())
                {
                    if(a.numAccounts != 0)
                    {
                        Console.WriteLine("ID\tNAME\tGENDER\tAGE");
                        for (int i = 0; i < a.numAccounts; i++)
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", i+1, a.matches[i].profName, a.matches[i].profGender, a.matches[i].profAge);
                        }
                        Console.WriteLine("TOTAL MATCHES: {0}", a.numAccounts);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("YOU HAVE NO MATCHES.");
                    }
                }
            }
        }

        public void ViewLikes(string name)
        {
            Console.WriteLine("=====VIEW LIKES=====");
            Console.WriteLine();
            foreach(Profile a in registeredusers)
            {
                if (a.profName == name.ToUpper())
                {
                    if(a.userlikes.Count == 0)
                    {
                        Console.WriteLine("YOU HAVE NO LIKES.");
                    }
                    else
                    {
                        Console.WriteLine("ID\tNAME\tGENDER\tAGE");
                        foreach(Profile b in a.userlikes)
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", a.userlikes.IndexOf(b) + 1, b.profName, b.profGender, b.profAge);
                            Console.WriteLine();
                        }
                        Console.WriteLine("TOTAL LIKES: {0}", a.userlikes.Count);
                    }
                }
            }
        }

        public void ViewPeopleList(string name)
        {
            Console.WriteLine("=====VIEW PEOPLE LIST=====");
            if(registeredusers.Count == 1)
            {
                Console.WriteLine();
                Console.WriteLine("YOUR LIST OF PEOPLE IS EMPTY.");
            }
            else
            {
                Console.WriteLine("ID\tNAME\tGENDER\tAGE");
                foreach (Profile a in registeredusers)
                {
                    if(a.profName != name.ToUpper())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", registeredusers.IndexOf(a) + 1, a.profName, a.profGender, a.profAge);
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("TOTAL REGISTERED: {0}", registeredusers.Count);
            }
        }
    }
}
/* List commands used that were not taught in class: Contains, IndexOf, RemoveAt
 * Source: obtained from:
 * Date: November 5, 2017
 * Name of Author/Programmer: Microsoft Developer Official Website
 * 
 * Array commands used that were not taught in class: IndexOf
 * Source: obtained from: https://stackoverflow.com/questions/7867377/checking-if-a-string-array-contains-a-value-and-if-so-getting-its-position
 * Date: November 6, 2017
 * Name of Author/Programmer: Darin Dimitrov
 */
