using System;

namespace PasswordStrengthChecker.ChainOfResponsibility
{
    public  class RequirementMinLength : Requirement
    {
        public override void HandleRequest(string password)
        {
            if (password.Length < 5)
            {
                Console.WriteLine($"{this.GetType().Name} is not met.");
            }
            else if (requirement != null)
            {
                requirement.HandleRequest(password);
            }
        }
    }
}
