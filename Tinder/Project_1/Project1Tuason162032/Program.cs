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
    class MainClass
    {
        public static void Main(string[] args)
        {
            int choice;
            Function func = new Function();
            do
            {
                Console.WriteLine();
                Console.WriteLine("=====WELCOME TO TINDER!=====");
                Console.WriteLine("1 for Register");
                Console.WriteLine("2 for Login");
                Console.WriteLine("0 to QUIT");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (choice == 1)
                {
                    func.Register();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("=====LOGIN=====");
                    if (func.registeredusers.Count == 0)
                    {
                        Console.WriteLine("NO ONE HAS REGISTERED YET.");
                    }
                    else
                    {
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        if (func.registeredusernames.Contains(name.ToUpper()))
                        {
                            int choicea;
                            Console.WriteLine("Welcome, {0}!", name);
                            do
                            {
                                Console.WriteLine();
                                Console.WriteLine("=====TINDER MENU=====");
                                Console.WriteLine("1 Match");
                                Console.WriteLine("2 View Matches");
                                Console.WriteLine("3 View People List");
                                Console.WriteLine("4 Unmatch");
                                Console.WriteLine("5 Edit User Settings");
                                Console.WriteLine("6 View Likes");
                                Console.WriteLine("0 to LOGOUT");
                                Console.Write("Enter choice: ");
                                choicea = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                if (choicea == 1)
                                {
                                    func.Match(name);
                                }
                                else if (choicea == 2)
                                {
                                    func.ViewMatches(name);
                                }
                                else if (choicea == 3)
                                {
                                    func.ViewPeopleList(name);
                                }
                                else if (choicea == 4)
                                {
                                    func.Unmatch(name);
                                }
                                else if (choicea == 5)
                                {
                                    func.EditUser(name);
                                }
                                else if (choicea == 6)
                                {
                                    func.ViewLikes(name);
                                }
                            }
                            while (choicea != 0);
                            {
                                Console.WriteLine("LOGGING OUT...");
                            }
                        }
                        else
                        {
                            Console.WriteLine("PERSON HAS NOT BEEN REGISTERED.");
                        }
                    }
                }


            }
            while (choice != 0);
        }
    }
}
