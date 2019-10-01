using PasswordStrengthChecker.PasswordStrengthMethods;

namespace PasswordStrengthChecker.Builder
{
    public class BuilderLevel2:BuilderPass
    {
        private readonly IPasswordStrengthMethods _passwordStrengthMethods;
        private readonly Level _level = new Level();
        public BuilderLevel2()
        {
            _passwordStrengthMethods = new PasswordStrengthMethod();
        }

        public override void ContainsDigit(string password)
        {

            var containsDigit = _passwordStrengthMethods.PassContainsDigit(password);
            _level.Add(containsDigit);
        }

        public override void ContainsSpecialChar(string password)
        {
            var containsSpecialChar = _passwordStrengthMethods.PassContainsSpecialChar(password);
            _level.Add(containsSpecialChar + "NOT REQUIRED");
        }

        public override void IsNotOnTheList(string password)
        {
            var isNotOnTheList = _passwordStrengthMethods.IsOnTheListForbiddenPass(password);
           _level.Add(isNotOnTheList);
        }

        public override void MinLength(string password)
        {

            var minLength = _passwordStrengthMethods.PassMinLength(8, password);
            _level.Add(minLength);
        }

        public override Level GetResult()
        {
            return _level;
        }
    }
}
