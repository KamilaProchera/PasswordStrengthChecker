using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordStrengthChecker.TestStrategy
{
    public abstract class StrengthLevel
    {
        public abstract void MinLength(string password);
    }
}
