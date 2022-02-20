using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_1
{
    class User
    {
        private string _userName;
        public string UserName 
        {
            set
            {
                if(value.Length > 7)
                {
                    _userName = value;
                    return;
                }
                Console.WriteLine("Adiniz 8 herfden artiq olmalidir");
            }
            get
            {
                return _userName;
            }

        }
        private string _password;
        public string Password 
        {
            set
            {
                int count = 0;
                if (!(value.Length > 7))
                {
                    Console.WriteLine("Your password should have more than 7 elements");
                    return;
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsUpper(value[i]))
                    {
                        count++;
                        break;
                    }
                    if (i == value.Length-1)
                    {
                        Console.WriteLine("There should be a Capital letter");
                        return;
                    }
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsLower(value[i]))
                    {
                        count++;
                        break;
                    }
                    if (i == value.Length-1)
                    {
                        Console.WriteLine("There should be a Lowercase letter");
                        return;
                    }
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsDigit(value[i]))
                    {
                        count++;
                        break;
                    }
                    if (i == value.Length-1)
                    {
                        Console.WriteLine("There should be a Digit");
                        return;
                    }
                }
                if (count == 3)
                {
                    _password = value;
                }
                return;
            }
            get
            {
                return _password;
            }

        }
    }
}
