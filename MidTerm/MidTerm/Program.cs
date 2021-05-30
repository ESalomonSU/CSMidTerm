using System;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = null;

            do
            {


                Console.WriteLine("User account\n" +
                    "\n1.- Log in" +
                    "\n2.- Sign up" +
                    "\n3.- Exit\n");

                user = Console.ReadLine();

                switch (user)
                {
                    case "1":
                        Console.WriteLine("Username:\n" +
                            "Pasword:\n");
                        break;

                    case "2":
                        Console.WriteLine("First name\n" +
                            "Second name:\n");
                        break;

                    case "3":
                        Console.WriteLine("Exit option");
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            while (user != "3");

            Console.ReadKey();
        }
    }
}
