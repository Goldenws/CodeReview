using System;

namespace LoginCredentials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Login Form
             * login: user
             * password: user1234
             * Create a program that asks user's login credentials
             * Check if the user entered correct login and password
             * If the login and password are correct display 'Welcome'
             * If the login or password are incorrect dispay 'try again'
             
             */
           string Login;
            string Password;
            Console.WriteLine("Welcome Tovarish");
            Console.WriteLine("Enter your Login ");
            Login = Console.ReadLine();
            Console.WriteLine(" Enter your Password ");
            Password = Console.ReadLine();

            if ((Login == "Tovarish") && (Password == "Stalin-Forever"))
            {
                Console.WriteLine("Come in, my fellow communist.");
            }
            else if ((Login == "Tovarish") && (Password != "Stalin forever"))
            {
                Console.WriteLine("This is wrong Password,Good try  capitalist intruder");
            }
            else if ((Login != "Tovarish") && (Password == "Stalin-Forver"))
            {
                Console.WriteLine("Alright come with us we have some questions.");
            }
            else
            {
                Console.WriteLine("Get out of our border");
            }
        }
    }
}
