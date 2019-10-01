using PasswordStrengthChecker.PasswordStrengthMethods;
using System;
using System.Linq;

namespace PasswordStrengthChecker.ChainOfResponsibility
{
    public class RequirementIsNotOnTheListForbiddenPasswords : Requirement
    {
        public override void HandleRequest(string password)
        {
            Singleton singleton = Singleton.GetInstance;
            var listOfPasswords = singleton.ReadAllLinesAsync().Result.ToList();
            string msg = "";
           
            foreach (var item in listOfPasswords)
            {
                if (item == password)
                {
                    msg = "The password is on the list";
                    break;
                }
                else
                {
                    msg = "All requirements are met";

                }

            }
            Console.WriteLine(msg);


        }
    }
}
