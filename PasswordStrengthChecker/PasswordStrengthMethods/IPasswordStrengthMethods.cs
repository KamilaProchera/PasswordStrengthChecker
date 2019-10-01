namespace PasswordStrengthChecker.PasswordStrengthMethods
{
    public interface IPasswordStrengthMethods
    {
        string PassMinLength(int length, string password);
        string PassContainsDigit(string password);
        string PassContainsSpecialChar(string password);
        string IsOnTheListForbiddenPass(string password);
    }
}
