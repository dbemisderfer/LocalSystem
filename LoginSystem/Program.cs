using System;

namespace LoginSystem
{
    class MainClass
    {
        static string user;
        static string pass;
        static string userName;
        static string userPass;

        // Just testing with Github
        // Making first update
        // Testing Git branch
        // Still testing
        // Testing one more time
        // Test test test branch

        public static string storeUsername()
        {
            Console.Write("Enter a username: ");
            string username = Console.ReadLine();
            return username;
        }

        public static string storePassword()
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            return password;
        }

        public static string confirmUsername()
        {
            Console.Write("Enter your username: ");
            string loginName = Console.ReadLine();
            return loginName;
        }

        public static string confirmPassword()
        {
            Console.Write("Enter your password: ");
            string loginPass = Console.ReadLine();
            return loginPass;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please register.");
            user = storeUsername();
            pass = storePassword();
            Console.WriteLine("You may now login.");
            /////////////////////////////////////////
            ///////// Solution One //////////////////
            /////////////////////////////////////////
            //do
            //{
            //    userName = confirmUsername();
            //} while (!userName.Equals(user));
            //do
            //{
            //    userPass = confirmPassword();
            //} while (!userPass.Equals(pass));
            //Console.WriteLine("You are now logged in!");


            /////////////////////////////////////////
            ///////// Solution Two //////////////////
            /////////////////////////////////////////
            userName = confirmUsername();
            if (userName.Equals(user))
            {
                userPass = confirmPassword();
                if (userPass.Equals(pass))
                {
                    Console.WriteLine("You are now logged in!");

                }
                else
                {

                    Console.WriteLine("Sorry, that is not a valid password. Please restart the app and try again.");

                }

            }
            else
            {

                Console.WriteLine("Sorry, that is not a valid username. Please restart the app and try again.");

            }



        }
    }
}
