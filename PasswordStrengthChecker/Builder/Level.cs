using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordStrengthChecker.Builder
{
    public class Level
    {
        private List<string> _requirements = new List<string>();
        public void Add(string requirement)
        {
            _requirements.Add(requirement);
        }
        public void Show()
        {

            foreach (var item in _requirements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
