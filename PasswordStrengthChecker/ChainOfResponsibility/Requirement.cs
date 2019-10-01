namespace PasswordStrengthChecker.ChainOfResponsibility
{
    public abstract class Requirement
    {

        protected Requirement requirement;
        public void SetRequirement(Requirement requirement)
        {
            this.requirement = requirement;
        }

        public abstract void HandleRequest(string password);
    }
}
