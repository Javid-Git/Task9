using System;

namespace Task9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            while (user.UserName == null)
            {
                Console.WriteLine("Username daxil edin");
                user.UserName = Console.ReadLine();

            }

            while (user.Password == null)
            {
                Console.WriteLine("Password daxil edin");
                user.Password = Console.ReadLine();
            }
            

            Console.WriteLine(user.UserName);
            Console.WriteLine(user.Password);

        }
    }
}
