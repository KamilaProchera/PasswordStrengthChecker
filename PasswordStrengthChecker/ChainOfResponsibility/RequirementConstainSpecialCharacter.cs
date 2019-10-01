using System;
using System.Text.RegularExpressions;

namespace PasswordStrengthChecker.ChainOfResponsibility
{
    class RequirementConstainSpecialCharacter : Requirement
    {
        public override void HandleRequest(string password)
        {

            if (!Regex.IsMatch(password, @"\D\d+\B\D|\W"))
            {
                Console.WriteLine("The password does not contain a special character");
            }
            else if (requirement != null)
            {
                requirement.HandleRequest(password);
            }
        }
    }
}
