namespace PasswordStrengthChecker.Builder
{
    public class Director
    {
        // Builder uses a complex series of steps
        public void Construct(BuilderPass builder, string password)
        {


           builder.MinLength(password);
           builder.ContainsDigit(password);
           builder.ContainsSpecialChar(password);
           builder.IsNotOnTheList(password);
        }
    }
}
