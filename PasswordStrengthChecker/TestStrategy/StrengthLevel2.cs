using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordStrengthChecker.TestStrategy
{
    public class StrengthLevel2 : StrengthLevel
    {
        public override void MinLength(string password)
        {
            Console.WriteLine("Level 2");
            if (password.Length < 8)
            {
                Console.WriteLine("The password is shorter than 8 characters");
            }
            else
            {
                Console.WriteLine("The length of password is ok");
            }
        }
    }
}
