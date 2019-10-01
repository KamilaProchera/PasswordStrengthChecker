using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordStrengthChecker.TestStrategy
{
    public class Context
    {
        private StrengthLevel _strengthLevel;
        private string password;

        public Context(StrengthLevel strengthLevel)
        {
            this._strengthLevel = strengthLevel;
        }
        public void ContextInterface(string password)
        {
            _strengthLevel.MinLength(password);
        }
    }
}
