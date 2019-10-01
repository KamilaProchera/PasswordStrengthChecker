using System.Linq;
using System.Text.RegularExpressions;

namespace PasswordStrengthChecker.PasswordStrengthMethods
{
    public class PasswordStrengthMethod : IPasswordStrengthMethods
    {
        public string PassMinLength(int length, string password)
        {
            if (password.Length < length)
            {
                return $"Password shorter than {length}";
            }
            else
            {
                return $"Password is ok";
            }
        }

        public string PassContainsDigit(string password)
        {
            if (Regex.IsMatch(password, @"\D\d+\B\D|\W"))
            {
                return "The password contains a digit";
            }
            else
            {
                return "The password does not contain a digit";
            }
        }

        public string PassContainsSpecialChar(string password)
        {
            if (Regex.IsMatch(password, @"\W+"))
            {
                return "The password contains a special character";
            }
            else
            {
                return "The password does not contain a special character";
            }
        }

        public string IsOnTheListForbiddenPass(string password)
        {
            Singleton singleton = Singleton.GetInstance;
            var listOfPasswords =  singleton.ReadAllLinesAsync().Result.ToList();
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
                    msg = "The password is not on the list";

                }

            }

            return msg;
        }
    }
}
