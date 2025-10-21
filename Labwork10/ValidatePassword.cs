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
            bool hasLetter = false;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else if (char.IsLetter(c))
                {
                    hasLetter = true;
                }

                if (hasDigit && hasLetter)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
