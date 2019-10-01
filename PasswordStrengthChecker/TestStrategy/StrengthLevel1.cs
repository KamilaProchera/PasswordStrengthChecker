using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordStrengthChecker.TestStrategy
{
    public class StrengthLevel1 : StrengthLevel
    {
        public override void MinLength(string password)
        {

            Console.WriteLine("Level 1");
            if (password.Length < 5)
            {
                Console.WriteLine("The password is shorter than 5 characters");
            }
            else
            {
                Console.WriteLine("The length of password is ok");
            }
        }
    }
}
