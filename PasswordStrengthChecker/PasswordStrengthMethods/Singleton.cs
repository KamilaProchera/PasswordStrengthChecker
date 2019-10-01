using System.IO;
using System.Threading.Tasks;

namespace PasswordStrengthChecker.PasswordStrengthMethods
{
    public class Singleton
    {
        public async Task<string[]> ReadAllLinesAsync()
        {
            return await File.ReadAllLinesAsync("ForbiddenPasswords.txt");
        }

        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

    }
}
