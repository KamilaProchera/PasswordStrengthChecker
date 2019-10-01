using System;
using System.Text.RegularExpressions;

namespace PasswordStrengthChecker.ChainOfResponsibility
{
    public class RequirementContainsDigit : Requirement
    {
        public override void HandleRequest(string password)
        {

            if (!Regex.IsMatch(password, @"\W+"))
            {
                Console.WriteLine("The password does not contain a digit");
            }
            else if (requirement != null)
            {
                requirement.HandleRequest(password);
            }
        }
    }
}
