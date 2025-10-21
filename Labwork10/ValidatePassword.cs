using System.Text.RegularExpressions;

namespace Labwork10
{
    public static class PasswordValidator
    {
        public static bool ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (!char.IsLetterOrDigit(c))
                {
                    hasSpecialChar = true;
                }

                if (hasDigit && hasLower && hasUpper && hasSpecialChar)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
