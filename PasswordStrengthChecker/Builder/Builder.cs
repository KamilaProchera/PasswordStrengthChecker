namespace PasswordStrengthChecker.Builder
{
    public abstract class  BuilderPass
    {
        public abstract void MinLength(string pass);
        public abstract void ContainsDigit(string pass);
        public abstract void ContainsSpecialChar(string pass);
        public abstract void IsNotOnTheList(string pass);
        public abstract Level GetResult();
    }
}
