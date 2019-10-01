using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordStrengthChecker.TestStrategy
{
    public class StrengthLevel3 : StrengthLevel
    {
        public override void MinLength(string password)
        {

            Console.WriteLine("Level 3");
            if (password.Length < 12)
            {
                Console.WriteLine("The password is shorter than 12 characters");
            }
            else
            {
                Console.WriteLine("The length of password is ok");
            }
        }
    }
}
